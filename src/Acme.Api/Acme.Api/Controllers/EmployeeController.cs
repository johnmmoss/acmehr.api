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
        public IActionResult Post(EmployeeUpdateRequest request)
        {
            var current = _acmeContext.Employees.FirstOrDefault(x => x.EmployeeID == request.EmployeeID);

            if (current != null)
            {
                current.Title = request.Title;
                current.FirstName = request.FirstName;
                current.LastName = request.LastName;
                current.BirthDate = request.BirthDate;

                _acmeContext.Update(current);
                _acmeContext.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(EmployeeAddRequest request)
        {
            var employee = new Employee();

            employee.DepartmentID = 1;
            employee.Title = request.Title;
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.BirthDate = request.BirthDate;

            _acmeContext.Employees.Add(employee);
            _acmeContext.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(EmployeeDeleteRequest request)
        {
            var employee = _acmeContext.Employees.FirstOrDefault(x => x.EmployeeID == request.EmployeeId);
            if (employee != null)
            {
                _acmeContext.Employees.Remove(employee);
                _acmeContext.SaveChanges();
            }

            return Ok();
        }
    }
}
