using Assesment_Owen_Repository;
using Assessment_Owen_BusinessLogic.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assessment_Owen.Controllers
{
   // [Authorize]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeOperation _employee; 
        public EmployeeController(IEmployeeOperation employeeOperation)
        {
            _employee = employeeOperation;
        }
        public Employee GetEmployee()
        {
            return _employee.GetEmployee();
        }

       // [HttpPost]
        public void SaveEmployee(HttpRequestMessage request)
        {
            var sp = this.Request.Content.Headers.AsQueryable();
            var data = request.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Employee>(data);
            _employee.SaveEmployee(result);
        }
        
    }
}
