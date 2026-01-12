using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student_App_Info
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
              "Server=.;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}
