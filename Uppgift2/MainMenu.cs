using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class MainMenu
    {
        public static int PrintStartMenu()
        {
            Console.WriteLine("Kassa");

            int Choice;

            Console.WriteLine("1. Ny Kund");
            Console.WriteLine("0. AvSluta");

            while (true)
            {
                bool Check = Int32.TryParse(Console.ReadLine(), out Choice);


                if (Check == false) Console.WriteLine("Änge ett Tal 1 eller 0");

                if ((Check == true && Choice == 1) || (Check == true && Choice == 0)) break;
            }
            return Choice;

        }
    }
}
