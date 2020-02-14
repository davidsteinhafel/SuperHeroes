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
        public string name;
        public string alterEgo;
        public string primeAbility;
        public string secondAbility;
        public string catchphrase;
        
    }
}
