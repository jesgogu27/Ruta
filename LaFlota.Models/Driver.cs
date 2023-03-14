using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFlota.Models
{
    public class Driver
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string last_Name { get; set; }
        [Required]
        public string first_Name { get; set; }
        [Required]
        public string ssd { get; set;}
        [Required]
        public DateTime dob { get; set; }        
        public string? address { get; set; }
        public string? city { get; set; }
        public string? zip { get; set; }
        public string? phone { get; set; }
        [Required]
        public bool active { get; set; }

    }
}
