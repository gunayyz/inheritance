using System;
namespace car
{
    public class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public double MaxSpeed;

        public virtual void Info()
        {
            Console.WriteLine($"brand-{Brand} Model-{Model} Color-{Color} MaxSpeed-{MaxSpeed}");                
        }
        public Car()
        {
            Console.WriteLine("Car Created");
        }
        public Car(string Brand,string Model):this()
        {
            this.Brand = Brand;
            this.Model = Model;
        }
        public Car(string Brand, string Model, string Color, double MaxSpeed):this(Brand,Model)
        {
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }
    }
}

