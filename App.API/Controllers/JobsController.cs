using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.DTO;
//using App.API.Models;
//using App.Business;

namespace ResumesAPI.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        //private readonly IResumeService _resumeSvc;

        //public JobsController(IResumeService resumeSvc)
        //{
        //    _resumeSvc = resumeSvc;
        //}

        // GET api/values
        [HttpGet]
        public List<Job> Get()
        {
            var jobs = new List<Job>
            {
                new Job { Company = "Monash University", Project = "Victorian Cardiac Outcomes Registry (VCOR)", TimeFrame = "Apr 2017 - Present", Details = "Did stuff for Monash<br/>2nd line of stuff." },
                new Job  { Company = "Avant", Project = "Bizpack", TimeFrame = "Nov 2016 - Mar 2017", Details = "Did stuff for Avant<br/>2nd line of stuff." }
            };

            return jobs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
