using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0221
{
    public class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public BmwCar(string model, int fuel, int gasTankCapacity, bool isXDrive) : base(model, fuel, gasTankCapacity)
        {
            IsXDrive = isXDrive;
        }

        
    }
}
