using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Kantor
{
    public class ArrayOfExchangeRatesTable
    {
        public ExchangeRatesTable ExchangeRatesTable { get; set; }
    }
    public class ExchangeRatesTable
    {
        public String Table { get; set; }
        public List<Rate> Rates { get; set; }
    }
    public class Rate
    {
        public String Currency { get; set; }
        public String Code { get; set; }
        public double Mid { get; set; }
    }
}
