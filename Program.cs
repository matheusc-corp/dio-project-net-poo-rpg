// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using dio_project_net_poo_rpg.src.Entities;

Knight hero = new Knight("Arus", 42, "Guerreiro");

WhiteWizard whiteWizard = new WhiteWizard("Jenica", 42, "Mago de luz");

BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Mago de sombras");

Ninja ninja = new Ninja("Wedge", 42, "Ninja");

Knight opponent = new Knight("Malevicus", 68, "Guerreiro demonio");

System.Console.WriteLine("\n--------Hero Party--------");
System.Console.WriteLine(hero);
System.Console.WriteLine(whiteWizard);
System.Console.WriteLine(blackWizard);
System.Console.WriteLine(ninja);
// System.Console.WriteLine(whiteWizard.Attack());
// System.Console.WriteLine(whiteWizard.Attack(2));
// System.Console.WriteLine(whiteWizard.Magic());

System.Console.WriteLine("\n--------Enemy Party-------");
System.Console.WriteLine($"{opponent}");

// System.Console.WriteLine(opponent.Attack());

