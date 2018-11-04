using System;

namespace BaseClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Class Demo");

            Monster targu = new Monster("Targu the Terrible", true, 20 ,10, 15, 5, 10);
            Player poohbear = new Player("Pooh Bear", true, 20,20, 20, true, 5, 50);

            targu.ReportStats();
            Console.WriteLine();
            poohbear.ReportStats();

            GameEngine.H2HPlayerBattleMonster(poohbear, targu);

            Console.WriteLine("Press ANY KEY to quit.");
            Console.ReadKey();
        }
    }
}
