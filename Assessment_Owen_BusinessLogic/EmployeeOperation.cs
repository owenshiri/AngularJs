using Assesment_Owen_Repository;
using Assesment_Owen_Repository.Interfaces;
using Assessment_Owen_BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Owen_BusinessLogic
{
    public class EmployeeOperation:IEmployeeOperation
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeOperation(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        public Employee GetEmployee()
        {
            return _employee.GetEmployee();
        }
        public void SaveEmployee(Employee employee)
        {
            _employee.SaveEmployee(employee);
        }
    }
}
