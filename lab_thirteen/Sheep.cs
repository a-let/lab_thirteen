using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    class Sheep: Countable, Cloneable
    {
        private int _count = 0;
        private string _name = "Blackie";

        void Countable.incrementCount()
        {
            _count++;
        }

        void Countable.resetCount()
        {
            _count = 0;
        }

        int Countable.getCount()
        {
            return _count;
        }

        string Countable.getCountString()
        {
            return _count.ToString();
        }

        Cloneable Cloneable.cloneAnimal(Cloneable animal)
        { 
            animal = new Sheep();
            animal.setCloneName("Dolly");

            return animal;
        }

        void Cloneable.setCloneName(string name)
        {
            _name = name;
        }

        string Cloneable.getCloneName()
        {
            return _name;
        }
    }
}
