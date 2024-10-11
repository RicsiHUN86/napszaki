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
        static void Main(string[] args)
        {
            koszon();
        }
    }
}
