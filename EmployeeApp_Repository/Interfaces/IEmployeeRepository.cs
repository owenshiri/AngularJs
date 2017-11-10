using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_Owen_Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee();
        void SaveEmployee(Employee employee);
    }
}
