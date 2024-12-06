using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup5.Data;
using FinalProjectGroup5.Models;

namespace FinalProjectGroup5.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly FinalProjectGroup5Context _context;

        public JobsController(FinalProjectGroup5Context context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult GetJobs(int id)
        {

            Jobs jobs = _context.Jobs.Find(id);

            if (id == 0 || jobs == null)
            {
                return Ok(_context.Jobs.ToList().Slice(0, 5));
            }

            return Ok(jobs);
        }

        [HttpPost]
        public IActionResult PostMember(Jobs jobs)
        {
            _context.Jobs.Add(jobs);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMember(int id)
        {
            Jobs jobs = _context.Jobs.Find(id);
            if (jobs == null)
                return NotFound();

            try
            {
                _context.Jobs.Remove(jobs);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult PutMember(Jobs jobs)
        {
            try
            {
                _context.Entry(jobs).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
