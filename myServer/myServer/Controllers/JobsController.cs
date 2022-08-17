using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myServer.Controllers
{
    public class JobsController : ApiController
    {
        [HttpGet]
        public List<JobAndViewByDay> GetJobsAndViewsList(string beginDate, string endDate)
        {
            var dates = new List<DateTime>();
            DateTime begin= Convert.ToDateTime(beginDate);
            DateTime end= Convert.ToDateTime(endDate);
            for (var dt =begin; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }
            return JobsBL.GetJobModelFromDB(dates);
        }
    }

}
