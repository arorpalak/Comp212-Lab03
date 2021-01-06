using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********** Palak Arora- 301112908 ************

namespace Palak_Arora_Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Random Number
            var random = new Random();
            int[] values = Enumerable.Range(1, 1000000).Select(x => random.Next(1, 1000)).ToArray();
            /**---------------------------Sum of all the elements in the array. b)Counting the distinct elements in thearray using LINQ **/
            var linqStart = DateTime.Now;// get time before method calls
            var sum = values.Sum();
            var distinct = values.Distinct().Count();
            var linqEnd = DateTime.Now;// get time after method calls

            Console.WriteLine("\nUsing Linq\n******************************");
            // display results and total time in milliseconds
            var linqTime = linqEnd.Subtract(linqStart).TotalMilliseconds;
            DisplayResults(sum, distinct, linqTime);

            /**---------------------------Sum of all the elements in the array. b)Counting the distinct elements in thearray using PLINQ **/
            var plinqStart = DateTime.Now;// get time before method calls
            var sum1 = values.AsParallel().Sum();
            var distinct1 = values.AsParallel().Distinct().Count();
            var plinqEnd = DateTime.Now;// get time after method calls
            Console.WriteLine("\nUsing PLinq\n ***********************************");
            // display results and total time in milliseconds
            var plinqTime = plinqEnd.Subtract(plinqStart).TotalMilliseconds;
            DisplayResults(sum1, distinct1, plinqTime);

            // display time difference as a percentage
            Console.WriteLine("\nLINQ took " + $"{((plinqTime - linqTime) / plinqTime):P0}" + " less time than PINQ");
            Console.ReadLine();
        }
        // displays results and total time in milliseconds
        static void DisplayResults(int sum, int distinct, double time)
        {
            Console.WriteLine($"Sum: {sum}" + $"\nDistinct: {distinct}" + $"\nTotal time in milliseconds: {time:F}");
        }
    }
}
