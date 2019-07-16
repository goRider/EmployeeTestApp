using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeTracker.Data;
using EmployeeTracker.Models;
using EmployeeTracker.Repo;

namespace EmployeeTracker
{
    public partial class EmployeeForm : Form
    {
        private Employee _employee = new Employee();
        private EmployeeRepository _employeeRepository = new EmployeeRepository();
        private EmployeeContext _employeeContext = new EmployeeContext();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(Employee employee, EmployeeRepository employeeRepository)
        {
            _employee = employee;
            _employeeRepository = employeeRepository;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _employee.EmployeeName = employeeNameTextBox.Text.Trim();
            _employee.JobTitle = employeeJobTitleTextBox.Text.Trim();
            if (!_employeeContext.Employees.Equals(null) || !employeeJobTitleTextBox.Equals(String.Empty) || !employeeNameTextBox.Equals(String.Empty))
            {
                _employeeRepository.Insert(_employee);
                _employeeRepository.Save();
                MessageBox.Show("Insert Complete");
            }
            else
            {
                MessageBox.Show("Cannot add");
            }
        }
    }
}
