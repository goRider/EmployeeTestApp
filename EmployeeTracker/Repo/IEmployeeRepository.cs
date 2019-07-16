using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTracker.Models;

namespace EmployeeTracker.Repo
{
    interface IEmployeeRepository
    {
        void Insert(Employee employee);
        void Save();
        void Delete(Employee employee);
    }
}
