using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0221
{
    public class BmwComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
