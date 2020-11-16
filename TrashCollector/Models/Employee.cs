using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {   [Key]
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public char EmployeeAddress { get; set; }
        public int EmployeePhoneNumber { get; set; }
        public char EmployeeEmailAddress { get; set; }
    }
}
