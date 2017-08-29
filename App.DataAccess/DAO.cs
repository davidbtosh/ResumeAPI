using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.DataAccess
{
    public class DAO : IDAO
    {
        public List<Job> GetJobs()
        {
            using (var db = new MtoshDbContext())
            {
                return db.Jobs.ToList();
            }
        }
    }
}
