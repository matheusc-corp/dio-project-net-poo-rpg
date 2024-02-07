using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType) { }

        public override string Attack()
        {
            return $"{this.Name} lançou uma magia.";
        }

        public string Attack(int bonus)
        {
            return $"{this.Name} lançou magia com bonus de ataque de {bonus}";
        }

    }
}