using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreapi.Models;
using System.Linq;

namespace coreapi.Controllers
{
    [Route("api/[controller]")]
    public class TimeController : Controller // Change to ODataController when it is released for core
    {
        [HttpGet]
        public IEnumerable<TimeEntry> Get()
        {
            return new List<TimeEntry>
                {
                new TimeEntry { ActivityId=1001, Id=1, UserId=1001, Workday = DateTime.Now, WorkHours= 6.25m },
                new TimeEntry { ActivityId = 1001, Id = 2, UserId = 1001, Workday = DateTime.Now, WorkHours = 4 },
                new TimeEntry { ActivityId = 1001, Id = 3, UserId = 1002, Workday = DateTime.Now, WorkHours = 1.5m }
            }.Where(e=>e.UserId.Equals(1002));
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public TimeEntry Get(int id)
        {
               return new List<TimeEntry>
                {
                new TimeEntry { ActivityId=1001, Id=1, UserId=1001, Workday = DateTime.Now, WorkHours= 6.25m },
                new TimeEntry { ActivityId = 1001, Id = 2, UserId = 1001, Workday = DateTime.Now, WorkHours = 4 },
                new TimeEntry { ActivityId = 1001, Id = 3, UserId = 1002, Workday = DateTime.Now, WorkHours = 1.5m }
            }.Where(e => e.Id.Equals(id)).FirstOrDefault();
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
