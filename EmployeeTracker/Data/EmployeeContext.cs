using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTracker.Models;

namespace EmployeeTracker.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=con")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
