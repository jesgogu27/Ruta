using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFlota.Models
{
    public class Schedule
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int week_num { get; set; }
        [Required]
        public DateTime from { get; set; }
        [Required]
        public DateTime to { get; set; }
        [Required]
        public bool active { get; set; }
    }
}
