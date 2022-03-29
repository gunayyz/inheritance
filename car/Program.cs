using System;
namespace car
{
    class program
    {

        static void Main()
        {
            Car car = new Car("TESLA", "S5", "BLACK", 200);
            car.Info();
            Car bus = new Bus("BAKUBUS", "BAKU", "YELLOW", 120, 20);
            bus.Info();
            Console.WriteLine();
        }


    }
}
