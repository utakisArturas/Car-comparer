using System;

namespace CA0221
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bmwCar = new BmwCar("x5", 25, 80, true);
            var audiCar = new AudiCar("A5", 60, 77, false);
            var audiCar2 = new AudiCar("A2", 44, 68, true);
            var bmwCar2 = new BmwCar("X6", 70, 100, true);
            var compare = new BmwComparer();
            var compare2 = new AudiComparer();
            Console.WriteLine(compare.Compare(bmwCar, bmwCar2));
            Console.WriteLine(compare2.Compare(audiCar, audiCar2));

        }
    }
}
