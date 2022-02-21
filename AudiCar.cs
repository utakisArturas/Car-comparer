using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0221
{
    internal class AudiCar :Car
    {
        public bool IsQuadro;

        public AudiCar(string model, int fuel, int gasTankCapacity,bool isQuadro) : base(model, fuel, gasTankCapacity)
        {
            IsQuadro = isQuadro;
        }
    }
}
