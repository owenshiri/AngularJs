using Assesment_Owen_Repository.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_Owen_Repository
{
    public class Employee:IEmployeeRepository
    {
        public string Surname { get; set; }
        public string FirstNames { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public string DateOfBirth { get; set; }

        private const string path = @"C:\Assessment\Employee.json";

        public Employee GetEmployee()
        {
            var jsonText = File.ReadAllText(path);
            var employee = JsonConvert.DeserializeObject<Employee>(jsonText);
            return employee;
        }
        public void SaveEmployee( Employee employee)
        {
            JObject emp = new JObject(
            new JProperty("Surname", employee.Surname),
            new JProperty("FirstNames", employee.FirstNames),
            new JProperty("IdentityNumber", employee.IdentityNumber),
            new JProperty("IdentityType", employee.IdentityType),
            new JProperty("DateOfBirth", employee.DateOfBirth));
            File.WriteAllText(path, emp.ToString());
            //using(StreamWriter file = File.CreateText(@"Employee.json"))
            //using(JsonTextWriter writer = new JsonTextWriter(file))
            //{
            //     emp.WriteTo(writer);
            //}
        }
    }
}
