using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_ADV_C__2
{


    public class ArrayListReversal
    {
        public static void ReverseArrayList(ArrayList arrayList)
        {
            int count = arrayList.Count;
            for (int i = 0; i < count / 2; i++)
            {
                var temp = arrayList[i];
                arrayList[i] = arrayList[count - 1 - i];
                arrayList[count - 1 - i] = temp;
            }
        }

        public static void Main()
        {
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList:");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            ReverseArrayList(arrayList);

            Console.WriteLine("\nReversed ArrayList:");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
