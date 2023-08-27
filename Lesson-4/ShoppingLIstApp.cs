using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mehsul = new ArrayList();

            Console.WriteLine("Mehsulun sayini daxil edin");
            int say = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=say; i++)
            {
                Console.WriteLine("Mehsulun adini daxil edin");
                string mehsulAdi = Console.ReadLine();
                mehsul.Add(mehsulAdi);
            }


            foreach (var item in mehsul)
            {
                Console.WriteLine(item);
            }

        }
    }
}
