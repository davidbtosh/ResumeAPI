using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataAccess
{
    public interface IDAO
    {
        List<Job> GetJobs();
    }
}
