using System;
using System.Globalization;

namespace Uebung1._2
{
    class Program
    {
        static void Main()
        {
            string description, description2;
            int regID, regID2;
            char category, category2;
            double luminosity, luminosity2;
            try
            {
                //Hardcoded, for now...
                //Datentypen müssen nicht immer angegeben werden, dann einfach var regID = 123
                 description = "Günther";
                Console.Write("Enter description ");
                 description2 = Console.ReadLine();
                 regID = 123;
                Console.Write("Enter ID ");
                 regID2 = int.Parse(Console.ReadLine());
                 category = 'B';
                Console.Write("Gib Kategorie ein ");
                 category2 = char.Parse(Console.ReadLine());
                 luminosity = 123.456;
                Console.Write("Gib Leuchtkraft ein ");
                 luminosity2 = double.Parse(Console.ReadLine()); //mit Komma eingeben, wegen Deutschland
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input formate!");
                return;
            }


            //Print output:
            Console.WriteLine("Bezeichnung: "+description);
            Console.WriteLine("Bezeichnung: " + description2);
            Console.WriteLine("Registriernummer: {0}, Category: {1}", regID2, category2);
            Console.WriteLine($"Luminosity:  {luminosity2}");
            Console.WriteLine("Registriernummer: {0:x}, Nochmal: {0:e}", regID);

            var formattedLum = luminosity.ToString("f2", CultureInfo.InvariantCulture); //Ausgabe mit . anstatt,

            Console.WriteLine("Luminosity: {0}", formattedLum); //f2-> Zweinachkommastellen + runden

        }
    }
}
