using System;
namespace project
{
    public class Employee : Person
    {
        public int salary;

        public Employee(string name, string surname, int age, int salary) : base(name,surname,age)
        {
            this.salary = salary;
        }
        public override void Info()
        {
            Console.WriteLine($"{name} {surname} {age} {salary} ");



        }

    }
}