// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using dio_project_net_poo_rpg.src.Entities;

Hero hero = new Hero();
hero.Name = "Arus";
hero.Level = 12;
hero.HeroType = "Warrior";

Wizard whiteWizard = new Wizard("Jenica", 15, "Mago branco");


System.Console.WriteLine($"{hero}");

Hero opponent = new Hero("Malevicus", 59, "Devil");

System.Console.WriteLine(hero.Attack());
System.Console.WriteLine();
System.Console.WriteLine(whiteWizard);
System.Console.WriteLine(whiteWizard.Attack());
System.Console.WriteLine(whiteWizard.Attack(20));

