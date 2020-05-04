using System;

namespace UE_Schreiben_Lesen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib deinen Namen ein");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello {name}, on {date:d} at {date:t}");
            Console.WriteLine("\n Drücken einen Knopf um das Programm zu verlassen...");
            Console.ReadKey(true);
        }
    }
}
