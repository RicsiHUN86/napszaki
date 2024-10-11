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
        public static void sebesseg()
        {
            double kezdoSebesseg;

            do
            {
                Console.Write("Add meg a kezdő sebességet (m/s) 3.00 és 5.00 között: ");
                kezdoSebesseg = Convert.ToDouble(Console.ReadLine());

                if (kezdoSebesseg < 3.00 || kezdoSebesseg > 5.00)
                {
                    Console.WriteLine("A sebességnek 3.00 és 5.00 m/s között kell lennie. Próbáld újra.");
                }

            } while (kezdoSebesseg < 3.00 || kezdoSebesseg > 5.00);

            Console.WriteLine("Sebességek 10 méterenként (km/h-ban):");

            double aktualisSebesseg = kezdoSebesseg;

            for (int tav = 0; tav <= 100; tav += 10)
            {
                if (tav <= 50)
                {
                    aktualisSebesseg += 0.2; 
                }
                else if (tav >= 90)
                {
                    aktualisSebesseg -= 0.2;
                }

                double sebessegKmH = aktualisSebesseg * 3.6;

                Console.WriteLine($"{tav} méternél: {sebessegKmH} km/h");
            }

            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            koszon();
            kamat();
            sebesseg();
        }
    }
}
