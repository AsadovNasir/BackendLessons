using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balinizi Daxil Edin");
            int score = Convert.ToInt32(Console.ReadLine());    

            if (score == 0|| score<60)
            {
                Console.WriteLine("Sizin Neticeniz F olaraq qiymetlendirilir");
            }
            else if (score == 60 || score <70 )
            {
                Console.WriteLine("Sizin Neticeniz D olaraq qiymetlendirilir");
            }
            else if (score == 70 || score < 80)
            {
                Console.WriteLine("Sizin Neticeniz C olaraq qiymetlendirilir");
            }
            else if (score == 80 || score < 90)
            {
                Console.WriteLine("Sizin Neticeniz B olaraq qiymetlendirilir");
            }
            else if (score == 90 || score < 101)
            {
                Console.WriteLine("Sizin Neticeniz A olaraq qiymetlendirilir");
            }

            else
            {
                Console.WriteLine("Tessuf ki Bu Movzuda Hec Bir Melumatimiz Yoxdur.(");
            }
        }
    }
}
