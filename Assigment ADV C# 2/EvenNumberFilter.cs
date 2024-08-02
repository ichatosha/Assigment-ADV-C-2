using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_ADV_C__2
{
    internal class EvenNumberFilter
    {


        public static List<int> FilterEvenNumbers(List<int> list)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

        public static void Main()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = FilterEvenNumbers(numbers);

            Console.WriteLine("Even numbers:");
            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
