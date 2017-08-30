using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.DataAccess.Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        public string Project { get; set; }

        public string TimeFrame { get; set; }

        public string Company { get; set; }

        public string Details { get; set; }
    }
}
