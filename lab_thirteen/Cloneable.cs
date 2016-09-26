using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_thirteen
{
    interface Cloneable: Countable
    {
        Cloneable cloneAnimal(Cloneable animal);
        void setCloneName(string name);
        string getCloneName();
    }
}
