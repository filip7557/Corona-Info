using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaInfo.Models
{
    public class CoronaCountryData : CoronaData
    {
        private long todayCases;
        private long todayDeaths;
        private long active;
        private long critical;
        private long totalTests;

        public CoronaCountryData(long cases, long deaths, long recovered, long todayCases, long todayDeaths, long active, long critical, long totalTests)
            : base(cases, deaths, recovered)
        {
            this.todayCases = todayCases;
            this.todayDeaths = todayDeaths;
            this.active = active;
            this.critical = critical;
            this.totalTests = totalTests;
        }

        public long TodayCases { get => todayCases; }
        public long TodayDeaths { get => todayDeaths; }
        public long Active { get => active; }
        public long Critical { get => critical; }
        public long TotalTests { get => totalTests; }
    }
}
