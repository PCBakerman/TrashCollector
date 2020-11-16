using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
   
    public class Customer
    {   [Key]
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public char CustomerAddress { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public char CustomerEmailAddress { get; set; }
    }
}
