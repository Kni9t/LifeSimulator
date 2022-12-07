using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    public abstract class BaseObj
    {
        string Name { get; set; }
        public BaseObj(string Name)
        {
            this.Name = Name;
        }
    }
}
