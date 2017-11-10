using Assesment_Owen_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Owen_BusinessLogic.Interfaces
{
    public interface IEmployeeOperation
    {
            Employee GetEmployee();
            void SaveEmployee(Employee employee);
    }
}
