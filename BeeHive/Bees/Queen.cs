using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive.Bees
{
    public class Queen : Bee
    {
        public Queen()
        {
            this.MinHealth = 20;
            this.BeeType = "Queen";
        }
        
    }
}
