using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup5.Models;

namespace FinalProjectGroup5.Data
{
    public class FinalProjectGroup5Context : DbContext
    {
        public FinalProjectGroup5Context(DbContextOptions<FinalProjectGroup5Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectGroup5.Models.Course> Course { get; set; } = default!;
        public DbSet<FinalProjectGroup5.Models.Hobby> Hobbies { get; set; } = default!;
    }
}