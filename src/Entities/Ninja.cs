using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealthPoints += 50 + level;
            this.ManaPoints += 50 + level;
            this.AttackPoints += 100 + level;
            this.DefensePoints += 20 + level;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com a kunai.";
        }

        public override string Magic()
        {
            if (this.ManaPoints > 20)
            {
                this.ManaPoints -= 20;
                return $"{this.Name} atacou com jutsu de sombras.";
            }
            else
            {
                return $"{this.Name} não possui mana o bastante para lançar um jutsu.";
            }
        }
    }
}