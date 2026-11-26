using System;
using System.Collections.Generic;
using System.Text;

namespace _05_CRUD_MVC_base.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
