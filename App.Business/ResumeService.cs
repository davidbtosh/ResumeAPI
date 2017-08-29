using App.DataAccess;
using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ResumeService
    {
        private IDAO _dao;

        public ResumeService(IDAO dao)
        {
            _dao = dao;
        }

        public List<Job> GetJobs()
        {
            return _dao.GetJobs().Select(s => new Job
            {
                Company = s.Company,
                Details = s.Details,
                Project = s.Project,
                TimeFrame = s.TimeFrame
            }).ToList();
        }
    }
}
