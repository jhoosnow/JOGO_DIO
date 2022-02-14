using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.entities
{
    // CLASS MAGE
    public class Mage : Hero
    {
        public Mage(string Name, int level, string heroType) : base(Name, level, heroType)
        {
             this.Name = Name;
             this.level = level;
             this.heroType = heroType;   
        }
        public override string attack(){
            return this.Name + " Lançou sua Magia!!";
        }
        public  string attack(int Bonus){

        if(Bonus> 6)
        {
            return this.Name + " Lançou sua Magia super efetiva!!" + Bonus;
            }
            else
            {
                return this.Name + "Lançou uma magia com força fraca com bonus de " + Bonus;
            }
           
        }
    }
}