using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int number in fibArray)
            {
                Console.WriteLine(number);
            }

            AddArray(fibArray);
            Console.ReadLine();
        }

        public static void AddArray(int[] numbers)
        {
            int numberSum = 0;
            foreach (int number in numbers)
            {
                numberSum += number;
            }
            Console.WriteLine(numberSum);
        }
    }
}
