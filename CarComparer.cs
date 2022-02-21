using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0221
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
