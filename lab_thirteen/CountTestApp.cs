using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    class CountTestApp
    {
        static void Main(string[] args)
        {
            alligators();

            sheep();
        }

        static void alligators()
        {
            Countable alligator = new Alligator();

            Console.Write("Counting Alligators...\n\n");

            CountUtil.count(alligator, 3);
        }

        static void sheep()
        {
            Cloneable sheep = new Sheep();

            Console.Write("\nCounting Sheep...\n\n");

            CountUtil.count(sheep, 2);

            Console.Write("\n");

            Cloneable sheepClone = sheep.cloneAnimal(sheep);
            CountUtil.count(sheepClone, 3);

            Console.Write("\n");

            sheep.resetCount();
            CountUtil.count(sheep, 1);
        }
    }
}
