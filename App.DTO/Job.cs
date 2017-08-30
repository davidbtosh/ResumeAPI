using System;
using System.ComponentModel.DataAnnotations;

namespace App.DTO
{
    public class Job
    {   
        public string Project { get; set; }

        public string TimeFrame { get; set; }

        public string Company { get; set; }

        public string Details { get; set; }
    }
}
