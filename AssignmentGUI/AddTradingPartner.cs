using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class AddTradingPartner : Form
    {
        public AddTradingPartner()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Program.newPartnerName = newTradingPartnerBox.Text;
            this.Close();
        }

        private void newTradingPartnerBox_TextChanged(object sender, EventArgs e)
        {
            if (newTradingPartnerBox.Text.Length == 1)
            {
                newTradingPartnerBox.Text = newTradingPartnerBox.Text.ToString().ToUpper();
                newTradingPartnerBox.Select(newTradingPartnerBox.Text.Length, 0);
            }
        }
    }
}
