using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_project_net_poo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight() { }
        public Knight(string name, int level, string heroType) : base(name, level, heroType) { }

    }
}