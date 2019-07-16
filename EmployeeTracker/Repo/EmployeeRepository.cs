using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            var employeeItem = _employeeContext.Employees.SingleOrDefault(e => e.EmployeeID == employee.EmployeeID);

            if (employeeItem != null)
            {
                _employeeContext.Employees.Remove(employee);
                _employeeContext.SaveChanges();
            }
        }

        public void Update(Employee employeeUpdateChange)
        {
            _employeeContext.Employees.FirstOrDefault(a => a.EmployeeID == employeeUpdateChange.EmployeeID);
            _employeeContext.SaveChanges();
        }
    }
}
