using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Exercise_2
{
    internal abstract class WildlifeAnimal
    {
        private string name;
        private int weight;

        public WildlifeAnimal(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void Show() { }
        public virtual void Setme(int w,string n) {
            weight = w;
            name = n;
        }
    }
}
