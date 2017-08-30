using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.API.Models
{
    public class Job
    {
        public string Project { get; set; }

        public string TimeFrame { get; set; }

        public string Company { get; set; }

        public string Details { get; set; }
    }
}
