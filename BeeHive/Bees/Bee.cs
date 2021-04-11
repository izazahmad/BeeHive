using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive.Bees
{
    public class Bee
    {
        public float Health { get; set; } = 100;
        public string BeeType { get; set; }
        public float MinHealth { get; set; }
        public bool Status()
        {
            //return true when health is less than minimum health
            return this.Health < this.MinHealth;
        }
        public void Damage(int randomNo)
        {
            //if status is not true than reduce random no percentage
            if(!this.Status())
            {
                this.Health = this.Health * (100 - randomNo) / 100;
            }
            else if(this.Health<0)
            {
                this.Health = 0;//if health is negative than return 0
            }
            else if (randomNo < 0 || randomNo > 100)
            {
                throw new ArgumentException("The percentage must be between 0 and 100 (including).");
            }
            else
                
            return;//if all bees are dead than return
        }
        
    }
}
