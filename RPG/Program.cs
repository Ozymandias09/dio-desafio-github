using System;
using RPG.src.entities;
namespace RPG
{
    class Program
    {
        static void Main(string [] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 220, "White Mage");
            
            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }
}
