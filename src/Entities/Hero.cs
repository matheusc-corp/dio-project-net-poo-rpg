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
            this.HealthPoints = 100 + Level;
            this.ManaPoints = 10 + Level;
            this.AttackPoints = 15 + Level;
            this.DefensePoints = 5 + Level;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }

        public override string ToString()
        {
            return
                $"\nName: {Name}\n" +
                $"Level: {Level}\n" +
                $"Class: {HeroType}\n" +
                $"HP: {HealthPoints}\n" +
                $"MP: {ManaPoints}\n" +
                $"Attack: {AttackPoints}\n" +
                $"Defense: {DefensePoints}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com os punhos.";
        }

        public virtual string Magic()
        {
            if (this.ManaPoints > 10)
            {
                this.ManaPoints -= 10;
                return $"{this.Name} atacou com magia simples.";
            }
            else
            {
                return $"{this.Name} não possui mana o bastante para lançar magia.";
            }
        }

    }
}