using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesProject.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string primeAbility { get; set; }
        public string secondAbility { get; set; }
        public string catchphrase { get; set; }
    }
}
