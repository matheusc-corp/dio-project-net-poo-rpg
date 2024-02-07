using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public abstract class Hero
    {
        public Hero() { }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return $"\nName: {Name}\nLevel: {Level}\nClass: {HeroType}\n";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com a espada.";
        }

    }
}