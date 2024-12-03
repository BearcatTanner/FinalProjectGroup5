using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CoursesController : ControllerBase
    {
        private readonly FinalProjectGroup5Context _context;

        public CoursesController(FinalProjectGroup5Context context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            
            Course course = _context.Course.Find(id);

            if (id == 0 || course == null)
            {
                return Ok(_context.Course.ToList().Slice(0, 5));
            }

            return Ok(course);
        }

        [HttpPost]
        public IActionResult PostStudent(Course course)
        {
            _context.Course.Add(course);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Course course = _context.Course.Find(id);
            if (course == null)
                return NotFound();

            try
            {
                _context.Course.Remove(course);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult PutStudent(Course course)
        {
            try
            {
                _context.Entry(course).State = EntityState.Modified;
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
