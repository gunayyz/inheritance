using System;
namespace project
{
    public class Person
    {
        public string name;
        public string surname;
        public int age;

        public virtual void Info()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
        public Person()
        {
            Console.WriteLine("person created");
        }
        public Person(string name, string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
      






        }





    }



