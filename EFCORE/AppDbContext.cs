using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE
{
    internal class AppDbContext:DbContext
    {
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-GTVND9D;database=AB109_EF;Trusted_connection = true;Encrypt= false; TRUSTSERVERCERTIFICATE=true;");


        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }


}
