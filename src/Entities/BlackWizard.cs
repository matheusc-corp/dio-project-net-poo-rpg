using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealthPoints += 80 + level;
            this.ManaPoints += 150 + level;
            this.AttackPoints += 70 + level;
            this.DefensePoints += 30 + level;
        }

        public override string Attack()
        {
            return $"{this.Name} bateu com o cajado.";
        }

        public string Attack(int bonus)
        {
            if (this.ManaPoints >= 10)
            {
                this.ManaPoints -= 10;
                return $"{this.Name} encantou o cajado e causou {bonus} de bonus de ataque";
            }
            else
            {
                return $"{this.Name} não possui mana o bastante para lançar magia.";
            }
        }

        public virtual string Magic()
        {

            if (this.ManaPoints >= 35)
            {
                this.ManaPoints -= 35;
                return $"{this.Name} atacou com magia avançada.";
            }
            else
            {
                return $"{this.Name} não possui mana o bastante para lançar magia.";
            }
        }
    }
}