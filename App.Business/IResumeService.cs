using App.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Business
{
    public interface IResumeService
    {
        List<Job> GetJobs();
    }
}
