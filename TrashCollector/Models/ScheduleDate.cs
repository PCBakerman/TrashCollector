using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class ScheduleDate
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        
        [ForeignKey("LocationId")]
        public string LocationId { get; set; }
        public Location Location { get; set; }
        
        [ForeignKey("EmployeeId")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
