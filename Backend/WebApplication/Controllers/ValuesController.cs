using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T.Domain;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly TDbContext context;

        public ValuesController(TDbContext context)
        {
            this.context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
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

        [HttpGet("test1")]
        public int Test()
        {
            var result = context.Histories
                .Where(p=>!p.IsDelete)
                .Include(p => p.DynamicRule)
                .Include(p => p.Product)
                .Include(p => p.Supplier)
                .Where(p=>!p.DynamicRule.IsDelete)
                //.Where(p => !p.IsDelete)
                //.Where(p => !p.Product.IsDelete)
                .Count();
            return result;
        }

        [HttpGet("test2")]
        public List<History> Test2()
        {
            var result = GetHistory()
                .Include(p => p.DynamicRule)
                .Include(p=>p.Product)
                .Include(p=>p.Supplier)
                .ToList();
                //.Where(p => !p.IsDelete)
                //.Count();
            return result;
        }
                //.Where(p => !p.Student.IsDelete)

        private IQueryable<Student> GetStudents()
        {
            return context.Students.Where(p => !p.IsDelete);
        }

        private IQueryable<History> GetHistory()
        {
            return context.Histories.Where(p => !p.IsDelete);
        }
    }
}
