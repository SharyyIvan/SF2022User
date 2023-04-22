using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SF2022User.Calculations calculations=new SF2022User.Calculations();

            var text = calculations.AvailablePeriods(new TimeSpan[]
            {
                new TimeSpan(10,00,00),
                new TimeSpan(11,00,00),
                new TimeSpan(15,00,00),
                new TimeSpan(15,30,00),
                new TimeSpan(16,50,00)
            },
            new int[]
            {
                60,30,10,10,40
            },
            new TimeSpan(8, 00, 00), new TimeSpan(18, 00, 00), 30);

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
