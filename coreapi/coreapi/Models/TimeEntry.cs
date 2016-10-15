using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreapi.Models
{
    public class TimeEntry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ActivityId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTimeOffset Workday { get; set; }

        [Required]
        public decimal WorkHours { get; set; }
        
    }
}
