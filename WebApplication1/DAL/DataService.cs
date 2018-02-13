using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class DataService
    {
        public IEnumerable<SuperHero> InitializeData()
        {
            IEnumerable<SuperHero> superHeroes = new List<SuperHero>()
            {
                new SuperHero()
                {
                    Id = 0,
                    Name = "Superman",
                    Universe = "DC",
                    Age = 30
                },
                new SuperHero()
                {
                    Id = 1,
                    Name = "Iron Man",
                    Universe = "Marvel",
                    Age = 45
                },
                new SuperHero()
                {
                    Id = 2,
                    Name = "Batman",
                    Universe = "DC",
                    Age = 40
                },
                new SuperHero()
                {
                    Id = 3,
                    Name = "Thor",
                    Universe = "Marvel",
                    Age = 30
                }


            };

            return superHeroes;
        }
    }
}
