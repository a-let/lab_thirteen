using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    class Alligator: Countable
    {
        private int _count = 0;

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
    }
}
