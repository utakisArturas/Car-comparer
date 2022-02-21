using System;

namespace CA0221
{
    public abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        public int GasTankCapacity { get; set; }

        public Car(string model, int fuel, int gasTankCapacity)
        {
            Model = model;
            Fuel = fuel;
            GasTankCapacity = gasTankCapacity;
        }

        public void Drive() 
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"You can drive. Gas in tank - {Fuel}l. ");
            }
            else
            {
                Console.WriteLine("Gas tank is empty, refuel");
            }

        }

        public void Refuel(int liters)
        {   
            
            if (liters > 0 && Fuel <= GasTankCapacity)
            {
                Fuel =  liters + Fuel;
                Console.WriteLine($"You filled you gas tank with {liters}l. of gas. Gas in tank {Fuel}");
                GasTankCapacity = GasTankCapacity - Fuel;
            }
            else
            {
                Console.WriteLine($"Cant refill. Gass in the tank {Fuel}");
            }
        }
        
    }
}
