using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JobAndViewByDay
    {
        public DateTime date { get; set; }
        public int totalOfJobsPerDay { get; set; }
        public int totalOfViewsForTheseJobs { get; set; }
        public int totalOfViewForTheseJobsPerDay { get; set; }
    }
}
