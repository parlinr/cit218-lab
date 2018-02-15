using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SuperHero
    {
        public int Id { get; set; }

        [Display(Name = "Name of Superhero")]
        public string Name { get; set; }
        public string Universe { get; set; }

        public int Age { get; set; }
    }
}
