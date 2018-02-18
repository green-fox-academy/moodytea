using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApp.Model
{
    public class Quote
    {
        public int ID { get; set; }
        public string QuoteString { get; set; }
        public bool IsItPositive { get; set; }
    }
}
