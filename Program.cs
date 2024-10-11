using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napszak
{
    internal class Program
    {
        public static void koszon()
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 5 && currentTime.Hour < 12)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                Console.WriteLine("Jó napot!");
            }
            else if (currentTime.Hour >= 18 && currentTime.Hour < 22)
            {
                Console.WriteLine("Jó estét!");
            }
            else
            {
                Console.WriteLine("Jó éjszakát!");
            }
        }

       public static void kamat()
        {
            Console.Write("Add meg a lekötni kívánt összeget (HUF): ");
            double osszeg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a lekötés időtartamát (években): ");
            int evek = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a kamatlábat (%): ");
            double kamatLab = Convert.ToDouble(Console.ReadLine());

            double vegosszeg = osszeg * Math.Pow((1 + kamatLab / 100), evek);

            Console.WriteLine("A megadott idő elteltével a végösszeg: {vegosszeg} HUF");

            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            koszon();
            kamat();
        }
    }
}
