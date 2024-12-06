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
    public class GroupMembersController : ControllerBase
    {
        private readonly FinalProjectGroup5Context _context;

        public GroupMembersController(FinalProjectGroup5Context context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult GetMembers(int id)
        {

            GroupMembers groupMembers = _context.GroupMembers.Find(id);

            if (id == 0 || groupMembers == null)
            {
                return Ok(_context.GroupMembers.ToList().Slice(0, 5));
            }

            return Ok(groupMembers);
        }

        [HttpPost]
        public IActionResult PostMember(GroupMembers groupMembers)
        {
            _context.GroupMembers.Add(groupMembers);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMember(int id)
        {
            GroupMembers groupMembers = _context.GroupMembers.Find(id);
            if (groupMembers == null)
                return NotFound();

            try
            {
                _context.GroupMembers.Remove(groupMembers);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult PutMember(GroupMembers groupMembers)
        {
            try
            {
                _context.Entry(groupMembers).State = EntityState.Modified;
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
