using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    interface Countable
    {
        void incrementCount();
        void resetCount();
        int getCount();
        String getCountString();
    }
}
