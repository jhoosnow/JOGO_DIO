using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.entities
{

    //CLASS VAMPIRE
    public class Vampire : Hero
    {
        public Vampire(string Name, int level, string heroType) : base(Name, level, heroType)
        {
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
        }
         public override string attack(){
            return this.Name + " Sugou seu Sangue!";
        }

    }
}