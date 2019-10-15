using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class DepmanContext : DbContext
    {
        public DepmanContext() : base("DepmanDbConnection")
        {

        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<ProjectDetail> ProjectDetail { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Report> Report { get; set; }

        public DbSet<User> User { get; set; }

    }
}
