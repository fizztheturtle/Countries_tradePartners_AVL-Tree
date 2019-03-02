using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
class Countries
{
    private double gdpGrowth;
    private double inflation;
    private double tradeBalance;
    private int hdiRank;
    private List<string> tradingPartners = new List<string>();

    public double GdpGrowth
    {
        get { return gdpGrowth; }
        set { gdpGrowth = value; }
    }

    public double Inflation
    {
        get { return inflation; }
        set { inflation = value; }
    }

    public double TradeBalance
    {
        get { return tradeBalance; }
        set { tradeBalance = value; }
    }

    public int HdiRank
    {
        get { return hdiRank; }
        set { hdiRank = value; }
    }

    public string TradePartners
    {
        set
        {
            StringBuilder sb = new StringBuilder(value);            

            sb.Length--;
            sb.Remove(0, 1);
            string[] partners = sb.ToString().Split(';');
            tradingPartners = new List<string>(partners);
            tradingPartners.Sort();            
        }
    }

    public List<string> TradingPartners
    {
        get 
        {
            tradingPartners.Sort();
            return tradingPartners; 
        }
    }
}