using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive.Bees
{
    public class Worker : Bee
    {
        public Worker()
        {
            this.MinHealth = 70;
            this.BeeType = "Worker";
        }
        
    }
}
