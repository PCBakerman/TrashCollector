using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class ScheduleDates
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string LocationId { get; set; }
        [ForeignKey("Id")]
        public Location Location { get; set; }
        public string EmployeeId { get; set; }
        [ForeignKey("Id")]
        public Employee Employee { get; set; }

    }
}
