using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class JobsBL
    {
        public static List<JobAndViewByDay> GetJobModelFromDB(List<DateTime> dateArray)
        {
            using (JobsEntities je = new JobsEntities())
            {
                List<JobAndViewByDay> jobAndViewByDayList = new List<JobAndViewByDay>();
                foreach (DateTime date in dateArray)
                {
                    JobAndViewByDay jobAndViewByDay = new JobAndViewByDay();
                    jobAndViewByDay.date = date;
                    jobAndViewByDay.totalOfJobsPerDay=0;
                    jobAndViewByDay.totalOfViewsForTheseJobs = 0;
                    jobAndViewByDay.totalOfViewForTheseJobsPerDay = 0;
                    foreach (tbl_jobs jobs_tbl in je.tbl_jobs.Where(j => j.beginDate <= date && j.endDate > date))
                    {
                        jobAndViewByDay.totalOfJobsPerDay += 1;
                        jobAndViewByDay.totalOfViewForTheseJobsPerDay += je.tbl_views.Where(v => v.jobNum == jobs_tbl.jobNum && v.date == date).Count();
                        jobAndViewByDay.totalOfViewsForTheseJobs+= je.tbl_views.Where(v => v.jobNum == jobs_tbl.jobNum&&v.date <= date).Count();
                    }
                    jobAndViewByDayList.Add(jobAndViewByDay);
                }
                return jobAndViewByDayList;
            }
        }
    }
}
