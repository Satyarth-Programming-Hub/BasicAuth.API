using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public static List<Employee> GetEmployees() 
        {
            List<Employee> employees = new List<Employee>()
            {
               new Employee{ Id=1,FirstName="Ramesh",LastName="Chandra",Gender="Male",City="Lucknow",IsActive=true },
                new Employee{ Id=2,FirstName="Kamal",LastName="Kumar",Gender="Male",City="Chennai",IsActive=true },
                new Employee{ Id=3,FirstName="Rohit",LastName="Singh",Gender="Male",City="Jaipur",IsActive=true },
                new Employee{ Id=4,FirstName="Seema",LastName="Gupta",Gender="Female",City="Kanpur",IsActive=true },
                new Employee{ Id=5,FirstName="Neha",LastName="Kumari",Gender="Female",City="New Delhi",IsActive=true },
                new Employee{ Id=6,FirstName="Santosh",LastName="J",Gender="Male",City="Hyderabad",IsActive=true },
                new Employee{ Id=7,FirstName="Srikant",LastName="P",Gender="Male",City="Banglore",IsActive=true }
            };
            return employees;
        }
    }
}