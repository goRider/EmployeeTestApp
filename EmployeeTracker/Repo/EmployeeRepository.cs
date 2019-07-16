using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTracker.Data;
using EmployeeTracker.Models;

namespace EmployeeTracker.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext = new EmployeeContext();

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public EmployeeRepository()
        {
        }

        public void Insert(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
        }

        public void Save()
        {
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
        }
    }
}
