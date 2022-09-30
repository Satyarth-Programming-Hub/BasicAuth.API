using BasicAuth.API.BasicAuth;
using BasicAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicAuth.API.Controllers
{
    [BasicAuthenticationAttribute]
    public class EmployeesController : ApiController
    {
        public List<Employee> GetEmployees() 
        {
            return Employee.GetEmployees();
        }
    }
}
