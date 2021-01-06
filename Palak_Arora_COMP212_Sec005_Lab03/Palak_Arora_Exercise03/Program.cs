using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********Palak Arora 301112908 *************

namespace Palak_Arora_Exercise03
{
    class Program
    {
         static void Main(string[] args)
            {
                var rand = new Random();
                var values = new List<int>();
                values = Enumerable.Range(1, 10).Select(x => rand.Next(1, 100)).ToList();
                Console.Write("Original values: ");
                values.Display();
                Console.Write("\nAfter getting values > 50 and adding 10 to each values:= ");
            values.Where(value => value > 50)// find values greater than 50
                      .Select(value => value + 10)
                      .OrderBy(value => value) // sort the remaining  values
                      .Display();
            Console.ReadLine();
            }
     }
        static class Extensions
        {
            // extension method that displays all elements separated by spaces
            public static void Display<T>(this IEnumerable<T> data)
            {
                Console.WriteLine(string.Join(" ", data));
            }
        }
    }


