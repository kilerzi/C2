using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date and time (example, 2025-03-17 14:30): ");
            string input = Console.ReadLine();

            DateTime dateTime = DateTime.Parse(input); 
            Console.WriteLine("Date and Time: " + dateTime);
            DateTime now = DateTime.Now;
            //ova timespan command ja zemav od chat gpt neznaev kako da go napraam.
            //prvo mislev da gi odzemam nekako ama nemase da ispadne tocno ako rodendenot mu e posle u godinata,mozev samo da minusiram edna od godinite ako ne e pominato 
            //ama toa ne bi mi dalo da pisuvam od readline bidejki neznam koja data kje ja stavat.
            //zatoa iskoristiv chat gpt da mi kaze kako da gi minusiram i on mi kaza da napravam so time span 
            TimeSpan difference = now - dateTime;
            Console.WriteLine(difference.TotalDays/365);
            //pocnuvam so vtoriot del od domasnata
            DateTime now2 = DateTime.Now;
            DateTime AddedDays = now2.AddDays(3);
            Console.WriteLine(AddedDays);
            DateTime AddedMonths = now2.AddMonths(1);
            Console.WriteLine(AddedMonths);
            DateTime AddedMonths2 = now2.AddMonths(1).AddDays(3);
            Console.WriteLine(AddedMonths2);
            DateTime Year = now2.AddYears(-1).AddMonths(-2);
            Console.WriteLine(Year.ToString("yyyy-MM-dd"));

            Console.WriteLine(now2.ToString("MMMM")); 
            Console.WriteLine(now2.Month);  

            Console.WriteLine(now2.Year);
        }
    }
}
