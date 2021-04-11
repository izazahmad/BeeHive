using BeeHive.Bees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive.Services
{
    public class BeeService
    {
        //10 istnace for each bee
        private const int BeeEachType = 10;
        private List<Bee> BeesList = new List<Bee>();
        Random random = new Random();
        public List<Bee> CreateBeesList()
        {
            this.BeesList.Clear();
            //add range in beeType list
            int[] beeType = { BeeEachType, BeeEachType, BeeEachType };
            for (int i = 0; i < beeType.Length*BeeEachType; i++)
            {
                int type;
                do
                {
                    
                    type = random.Next(beeType.Length);
                } while (beeType[type]==0);
                    beeType[type]--;
                    BeesList.Add(
                         type == 0 ? new Worker() :
                         (type == 1 ? (Bee)new Queen() : new Drone())
                                );
            }
            return BeesList;

        }
        
        public List<Bee> Attack()
        {
            for (int i = 0; i < BeesList.Count; i++)
            {
                BeesList[i].Damage(random.Next(81));
            }
            return BeesList;
        }

    }
}
