using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolWpf.Models;

namespace SchoolWpf.Data
{
    public class Context : DbContext
    {
        public DbSet<People> People { get; set; }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=DBTask;Trusted_Connection=true");
        }


    }
}
