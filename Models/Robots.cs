using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apocalypse.Models
{
    public class Robots
    {
        [Key]
        public int Id { get; set; }
        public string model { get; set; }
        public string serialNumber { get; set; }
        public DateTime manufacturedDate { get; set; }
        public string category { get; set; }
    }
}
