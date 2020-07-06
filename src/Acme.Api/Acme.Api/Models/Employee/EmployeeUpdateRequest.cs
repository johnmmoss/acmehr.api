using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Api.Models.Employee
{
    public class EmployeeUpdateRequest
    {
        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
