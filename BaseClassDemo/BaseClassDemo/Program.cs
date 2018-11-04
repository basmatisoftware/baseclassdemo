using System;

namespace BaseClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Class Demo");

            Monster targu = new Monster("Targu the Terrible", true, 20, 15, 5, 10);


            Console.WriteLine("Press ANY KEY to quit.");
            Console.ReadKey();
        }
    }
}
