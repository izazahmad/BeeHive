using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive.Bees
{
    public class Drone: Bee
    {
        public Drone()
        {
            this.MinHealth = 50;
            this.BeeType = "Drone";
        }
        
    }
}
