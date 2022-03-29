using System;
namespace car
{
    public class Bus:Car
    {
        public int PassengerCount;

        public Bus(string Brand, string Model, string Color, double MaxSpeed, int PassengerCount):base(Brand,Model,Color, MaxSpeed)
        {
            this.PassengerCount = PassengerCount;
        }
        public override void Info()
        {
            Console.WriteLine($"brand-{Brand}  model-{Model} color-{Color} max speed-{MaxSpeed} passanger count-{PassengerCount}");
        }
    }
}
