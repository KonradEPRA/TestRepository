using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Kantor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayOfExchangeRatesTable a = GetExchange();
            cb_Rates.DataSource = a.ExchangeRatesTable.Rates;
            cb_Rates.DisplayMember = "Currency";
        }
        private ArrayOfExchangeRatesTable GetExchange()
        {
            WebClient client = new WebClient();
            Stream exchangeString = client.OpenRead("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(ArrayOfExchangeRatesTable));
            ArrayOfExchangeRatesTable aert = (ArrayOfExchangeRatesTable)x.Deserialize(exchangeString);
            return aert;
        }
    }
}
