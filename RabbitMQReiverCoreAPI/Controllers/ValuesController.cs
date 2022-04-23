using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMQReiverCoreAPI.Models;

namespace RabbitMQReiverCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MedicineSystemContext _context;
        // GET api/values

        public ValuesController(MedicineSystemContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<TblEmployee>> Get()
        {
            return   _context.TblEmployee.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("post3/{value}")]
        public void Post(string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpPost("savedata")]
        public ActionResult<string> savedata(List<User> userList)
        {
            TblEmployee emp;
            List<User> failList = new List<User>();
            foreach (User user in userList)
            {
               emp = new TblEmployee();
                failList.Add(user);
                Thread.Sleep(1000);//fake waiting 
                emp.FirstName = user.FirstName;
                emp.LastName = user.LastName;


                _context.TblEmployee.Add(emp);
                _context.SaveChangesAsync();
            }

            UserSaveFeedback saveFeedback = new UserSaveFeedback();
            saveFeedback.successCount = 1;
            saveFeedback.failedCount = 1;
            saveFeedback.failedList = failList;//Add fake failed Items

            return failList.ToString();
        }
    }
}
