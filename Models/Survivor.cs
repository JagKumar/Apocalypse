using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apocalypse.Models
{
    public class Survivor
    {
        [Key]
        public int SurvivorId { get; set; }
        public string Name { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public bool  asinfected { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
