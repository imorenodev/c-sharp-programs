using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person();
            try
            {
                p1.Age = int.Parse(Console.ReadLine());
            } catch (FormatException e) {
                Console.WriteLine("Error: " + e);
            }

            Console.WriteLine("Hello Again! You are " + p1.Age);
        }
    }

    class Person
    {
        public int Age { get; set; } = 5;
    }
}
