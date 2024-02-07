using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight() { }
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealthPoints += 150 + level;
            this.ManaPoints += level;
            this.AttackPoints += 50 + level;
            this.DefensePoints += 50 + level;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com a espada.";
        }

    }
}