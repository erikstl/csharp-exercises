using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,12,14 };
            SumList(numbers);
            Console.ReadLine();
        }

        public static void SumList(List<int> numbers)
        {
            int sum = 0;

            for (int i=0; i<numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
