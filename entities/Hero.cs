using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.entities
{
    // MODEL CLASS FOR EVERYTHING
    public abstract class Hero
    {

        public Hero(string Name, int level, string heroType){
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
        }

        public string Name;
        public int level;
        public string heroType;

        
        public virtual string attack(){
            return this.Name + "Atacou!!";
        }
    }
}