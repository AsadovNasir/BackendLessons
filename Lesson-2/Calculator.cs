using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Ededi Daxil Edin");
            int number1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci Ededi Daxil Edin");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simvolu Daxil Edin");
            string symb= Console.ReadLine();

            //ISLEM KODLARI

            if (symb == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (symb == "-")
            {
                Console.WriteLine(number1 - number2);
            }

            else if (symb == "/")
            {
                Console.WriteLine(number1 / number2);
            }

            else if (symb == "*")
            {
                Console.WriteLine(number1 * number2);
            }

        }
    }
}
