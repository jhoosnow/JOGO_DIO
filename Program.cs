using System;
using src.entities;
namespace dotnet__POO{

    class program{

        static void Main(string[] args){
           
           Mage mage = new Mage("Janx", 20, "Mage");
           Vampire vampire = new Vampire("Thefus", 14, "Vampiro"); 
           //attack of vampire
           Console.WriteLine(vampire.attack());
           //attack of mage
           Console.WriteLine(mage.attack());
           
        }
    }
}

