using Acme.Api.Models.Employee;
using Acme.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Api.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private AcmeContext _acmeContext;

        public EmployeeController(AcmeContext acmeContext)
        {
            _acmeContext = acmeContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _acmeContext.Employees.ToList();

            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post(EmployeeAddRequest request)
        {
            // TODO Validate request and add to database

            return Ok();
        }
    }
}
