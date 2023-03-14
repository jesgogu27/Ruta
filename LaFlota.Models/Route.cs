using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFlota.Models
{
    public class Route
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public bool active { get; set; }
    }
}
