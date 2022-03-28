using System;
namespace car
{
    class program
    {

        static void Main()
        {
            Car car = new Car("TESLA", "S5", "BLACK", 120);
            Bus bus = new Bus("BAKUBUS", "BAKU", "YELLOW", 30, 20);
            car.Info();
            bus.Info();

            Console.WriteLine();
        }


    }
}
