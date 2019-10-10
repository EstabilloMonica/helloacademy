using System;
using System.Collections.Generic;
using System.Text;

namespace HelloAcademy.Entities
{
    class menu
    {
        public static void mostraMenu()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*** HELLO ACADEMY MENU ***");
            Console.WriteLine("**************************");
            Console.WriteLine("");
            Console.WriteLine("* 1 - Divisione");
            Console.WriteLine("* 2 - Rubrica semplice");
            Console.WriteLine("* 3 - Rubrica complessa");
            Console.WriteLine("* 0 - Exit");
            Console.Write("* Selezione: ");
        }
    }
}
