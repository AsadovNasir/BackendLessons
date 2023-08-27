using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yasinizi daxil edin");
            int num1 =Convert.ToInt32(Console.ReadLine());  
            if (num1 ==  12 || num1 < 12) {
                Console.WriteLine("Qiymet 5$");
            }
            else if (num1 == 13 || num1<65)
            {
                Console.WriteLine("Qiymet 10$");
            } 
            else if (num1> 65) {
                Console.WriteLine("Qiymet 7$");
            }
            else
            {
                Console.WriteLine("Bilet verilmir");
            }

        }
    }
}
