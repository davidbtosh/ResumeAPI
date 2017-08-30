//using App.DataAccess;
using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Business
{
    public class ResumeService : IResumeService
    {
        //private IDAO _dao;

        //public ResumeService(IDAO dao)
        //{
        //    _dao = dao;
        //}

        //public ResumeService()
        //{
        //    _dao = new DAO();
        //}

        //public List<Job> GetJobs()
        //{
        //    return _dao.GetJobs().Select(s => new Job
        //    {
        //        Company = s.Company,
        //        Details = s.Details,
        //        Project = s.Project,
        //        TimeFrame = s.TimeFrame
        //    }).ToList();
        //}


        public List<Job> GetJobs()
        {
            var jobs = new List<Job>
            {
                new Job { Company = "Monash University", Project = "Victorian Cardiac Outcomes Registry (VCOR)", TimeFrame = "Apr 2017 - Present", Details = "Did stuff for Monash<br/>2nd line of stuff." },
                new Job { Company = "Avant", Project = "Bizpack", TimeFrame = "Nov 2016 - Mar 2017", Details = "Did stuff for Avant<br/>2nd line of stuff." }
            };

            return jobs;
        }


    }
}
