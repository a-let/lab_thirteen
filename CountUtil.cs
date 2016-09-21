using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    class CountUtil
    {
        public static void count(Countable animal, int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                animal.incrementCount();

                Console.WriteLine(animal.getCountString() + " " + animal.GetType().ToString().Split('.')[1]);
            }
                
        }

        public static void count(Cloneable animal, int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                animal.incrementCount();

                Console.WriteLine(animal.getCountString() + " " + animal.getCloneName());
            }

        }
    }
}
