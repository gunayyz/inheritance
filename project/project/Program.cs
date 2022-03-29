using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("eli","agayev",20);
            person.Info();
            Person employee = new Employee("gunay","abbasova",20,1900);
            employee.Info();
            Console.WriteLine();
        }
    }
}