using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFundamentos
{
    class Tabuada
    {
        public static void TabuadaCompleta(int numero)
        {
            Console.WriteLine("Tabuada:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + "X" + i + "=" + (numero * i));
            }
        }
    }
}
