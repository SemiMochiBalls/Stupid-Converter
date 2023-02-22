using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stupid_Converter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            americanMenu();
        }
        static int getYear()
        {
            return DateTime.Now.Year;
        }

        public static void europeanMenu()
        {

        }
        public static void americanMenu()
        {   int year = getYear();
            Console.WriteLine("CHOOSE A MEASRUENT TO CONVERT TO AMERICAN");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("A.) CRAPPY EURO LINE MEASURMENT TO PATRIOTIC");
            Console.WriteLine("AMERICAN FOOTBALLFIELDS");
            Console.WriteLine("B.) WIMP DICKED EUROPEAN FASTNESS MEASRUMENT TO");
            Console.WriteLine("FAST AS FUCK AMERICAN BALD EAGLES");
            Console.WriteLine("C. SCARY EURO (COMMIE) MEASRUMENT OF BIG SQUARE TO");
            Console.WriteLine($"AMERICAN FOOTBALL FIELDS RAHHHH LETS GO SUPERBOWL {year}");
        }
    }
}
