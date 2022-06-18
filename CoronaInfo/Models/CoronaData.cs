using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaInfo.Models
{
    public class CoronaData
    {
        private long cases;
        private long deaths;
        private long recovered;

        public CoronaData(long cases, long deaths, long recovered)
        {
            this.cases = cases;
            this.deaths = deaths;
            this.recovered = recovered;
        }

        public long Cases { get { return cases; } }
        public long Deaths { get { return deaths; } }
        public long Recovered { get { return recovered; } }
    }
}
