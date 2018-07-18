using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interval between drips in seconds");
            string ns = Console.ReadLine();
            int n = Convert.ToInt32(ns);
            double ph = (3600 / n) * 0.00025;
            double pd = (86400 / n) * 0.00025;
            double pw = (604800 / n) * 0.00025;
            Console.WriteLine("This wastes "+ph+" liters per hour");
            Console.WriteLine("This wastes "+pd+" liters per day");
            Console.WriteLine("This wastes "+pw+" liters per week");
            Console.ReadLine();

            double cupsH = (ph * 1000) / 250;
            double cupsH = (ph * 1000) / 250;



        }
    }
}
