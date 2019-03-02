using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class Form1 : Form
    {
        static string[] headers = new string[6];
        SortedDictionary<string, Countries> countries = new SortedDictionary<string, Countries>(); //Dictionary where all countries are stored
        Countries selectedCountry = new Countries(); //this object contains the currently selected country

        public Form1()
        {
            InitializeComponent();

            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];
            AllLines = File.ReadAllLines("countries.csv");

            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country")) headers = line.Split(',');
                else
                {
                    string[] columns = line.Split(',');
                    countries.Add(columns[0], new Countries
                    {
                        GdpGrowth = Convert.ToDouble(columns[1]),
                        Inflation = Convert.ToDouble(columns[2]),
                        TradeBalance = Convert.ToDouble(columns[3]),
                        HdiRank = Int32.Parse(columns[4]),
                        TradePartners = columns[5]
                    });
                }
            }
            refreshForm();
            findTradePotential();
        }

        private void refreshListBox1() //method to update ListBox1
        {
            listBox1.DataSource = new BindingSource(countries, null); //bind listBox1 to countries
            listBox1.ValueMember = "Key"; //display the entries by key
        }

        private void refreshForm() //method to update the entire form
        {
            refreshListBox1();
            updateView();
        }

        private void removeBtn_Click(object sender, EventArgs e) //remove country
        {
            countries.Remove(listBox1.SelectedValue.ToString()); //remove the selected country
            refreshForm(); // update Form1            
        }

        private void updateView(object sender, EventArgs e) //updates the selectedCountry object, listBox2 and country properties
        {
            if (countries.ContainsKey(listBox1.SelectedValue.ToString()))   //update selectedCountry
                selectedCountry = countries[listBox1.SelectedValue.ToString()];

            //update listbox2 and country properties
            listBox2.DataSource = selectedCountry.TradingPartners;
            partnersCountLbl.Text = listBox2.Items.Count.ToString();
            gdpBox.Text = selectedCountry.GdpGrowth.ToString();
            inflationBox.Text = selectedCountry.Inflation.ToString();
            tradeBalanceBox.Text = selectedCountry.TradeBalance.ToString();
            hdiBox.Text = selectedCountry.HdiRank.ToString();
            countriesCountLbl.Text = countries.Count.ToString();
        }

        //saves changes to the selectedCountry and applies them inside the dictionary
        private void SaveBtn_Click(object sender, EventArgs e) 
        {
            //save changes to the selectedCountry
            selectedCountry.GdpGrowth = Convert.ToDouble(gdpBox.Text);
            selectedCountry.Inflation = Convert.ToDouble(inflationBox.Text);
            selectedCountry.TradeBalance = Convert.ToDouble(tradeBalanceBox.Text);
            selectedCountry.HdiRank = Convert.ToInt32(hdiBox.Text);

            //save selectedCountry inside countries dictionary
            if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                countries[listBox1.SelectedValue.ToString()] = selectedCountry;
        }

        //add new country
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCountry ac = new AddCountry(); //create new AddCountry form
            ac.FormClosed += new FormClosedEventHandler(acClosed); //execute acClosed() on form closed
            ac.Show(); //show form
        }

        void acClosed(object sender, FormClosedEventArgs e)
        {
            //capitalise first letter of the name of the country
            if (Program.newCountryName != null)
                Program.newCountryName = Program.newCountryName.First().ToString().ToUpper() + String.Join("", Program.newCountryName.Skip(1));

            //add country properties
                countries.Add(Program.newCountryName, new Countries
                {
                    GdpGrowth = 0,
                    Inflation = 0,
                    TradeBalance = 0,
                    HdiRank = 0,
                    TradePartners = "[none]"
                });

                Program.newCountryName = null;
                refreshListBox1(); //refresh listBox1
        }

        //add new trading partner
        private void tradePAddBtn_Click(object sender, EventArgs e)
        {
            AddTradingPartner ap = new AddTradingPartner(); //create new AddTradingPartner form
            ap.FormClosed += new FormClosedEventHandler(apClosed); //execute apClosed() on form closed
            ap.Show(); //show form
        }

        void apClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.newPartnerName != "" && Program.newPartnerName != null)
            {
                selectedCountry.TradingPartners.Add(Program.newPartnerName); //add tradingPartner to selectedCountry
                Program.newPartnerName = null;

                //save selectedCountry inside countries dictionary
                if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                    countries[listBox1.SelectedValue.ToString()] = selectedCountry;

                //refresh listBox2
                listBox2.DataSource = null;
                listBox2.DataSource = selectedCountry.TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString(); //refresh tradingPartners count label
            }
        }

        //remove trading partner
        private void tradePRemBtn_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1) //check if trading partner is selected
            {
                selectedCountry.TradingPartners.RemoveAt(listBox2.SelectedIndex); //remove trading partner from selectedCountry

                //save selectedCountry inside countries dictionary
                if (countries.ContainsKey(listBox1.SelectedValue.ToString()))
                    countries[listBox1.SelectedValue.ToString()] = selectedCountry;

                //refresh listBox2
                listBox2.DataSource = null;
                listBox2.DataSource = selectedCountry.TradingPartners;
                partnersCountLbl.Text = listBox2.Items.Count.ToString(); //refresh tradingPartners count label
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //method to update search result as letters are typed inside searchBox
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "") //check if searchBox is empty
            {
                if (searchBox.Text.Length == 1) //check if there is only one letter entered in searchBox
                {
                    //capitalise the letter
                    searchBox.Text = searchBox.Text.ToString().ToUpper();
                    searchBox.Select(searchBox.Text.Length, 0);
                }

                //create dictionary "filtered" which stores all countries that contain letters that are entered in searchBox
                var filtered = countries.Where(d => d.Key.Contains(searchBox.Text)).ToDictionary(d => d.Key, d => d.Value);

                if (filtered.Count > 0) //check if filtered dictionary contains entries
                {
                    //show results in listBox1
                    listBox1.DataSource = new BindingSource(filtered, null);
                    listBox1.ValueMember = "Key";
                    noResultLbl.Visible = false; //hide noResultsLbl
                    resultsLbl.Visible = true; //show resultsLbl which contains the number of mathes

                    if (filtered.Count == 1) resultsLbl.Text = filtered.Count + " match"; //if filtered contains only one match output "match"
                    else resultsLbl.Text = filtered.Count + " matches"; //if filtered contains more than one match output "matches"
                }
                else
                {
                    noResultLbl.Visible = true; //show noResultsLbl
                    resultsLbl.Visible = false; //hide resultsLbl
                }
            }
            else
            {
                refreshListBox1();
                resultsLbl.Visible = noResultLbl.Visible = false;                
            }
        }

        private void updateView()
        {

        }

        //method to search by trading partners
        private void tpSearch_Click(object sender, EventArgs e)
        {
            BindingList<String> results = new BindingList<string>(); //list of results

            //search all entries inside countries for ones that contain the entered trading partner
            foreach (var entry in countries)
                if (entry.Value.TradingPartners.Contains(tpSearchBox.Text))
                    results.Add(entry.Key);

            if (results.Count == 0) results.Add("No matches"); //display "No mathes" if no results have been found            

            tpResultBox.DataSource = results; //display results to tpResultBox
        }

        //method to capitalise text entered in tpSearchBox
        private void tpSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (tpSearchBox.Text.Length == 1) //check if there is only one letter in tpSearchBox
            {
                //capitalise letter
                tpSearchBox.Text = tpSearchBox.Text.ToString().ToUpper();
                tpSearchBox.Select(tpSearchBox.Text.Length, 0);
            }
        }

        //method to find the country which has the best trading potential
        private void findTradePotential()
        {
            double bestPotential = 0, tempPotential = 0;
            string bestCountry = "";
            Countries tempCountry = new Countries();        

            foreach(var entry1 in countries)
            {
                foreach(var entry2 in entry1.Value.TradingPartners)
                {   
                    if(countries.ContainsKey(entry2))
                    tempCountry = countries[entry2];

                    tempPotential += tempCountry.GdpGrowth;
                    if (tempPotential > bestPotential)
                    {
                        bestPotential = tempPotential;
                        bestCountry = entry1.Key;
                    }
                }
                tempPotential = 0;
            }

            potentialResLbl.Text = bestCountry;
        }

        private void refreshPotential_Click(object sender, EventArgs e)
        {
            findTradePotential();
        }
    }
}
