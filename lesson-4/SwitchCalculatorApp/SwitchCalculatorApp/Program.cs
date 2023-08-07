using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birinci Ededi Daxil Edin");
            int num1= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ikinci Ededi Daxil Edin");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operatoru Daxil Edin");
            string symb = Console.ReadLine();


            int netice = 0;



            switch (symb)
            {
                case "+":
                    Console.WriteLine(netice = num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(netice= num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(netice= netice *num2);
                    break;

                case "/":
                    Console.WriteLine(netice=-num1 /num2);
                    break;

                default: Console.WriteLine("Bele bir islem yoxdur(");
                    break;
            }

        }
    }
}