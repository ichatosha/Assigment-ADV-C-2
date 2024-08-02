using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_ADV_C__2
{
    using System.Collections;
    internal class FixedSizeList<T>

    {
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");
            }
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("The list is full.");
            }
            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return items[index];
        }

        public int Count => count;
        public int Capacity => items.Length;


    }
  
    public static void Main6(string[] args)
    {
        
        try
        {
            var fixedSizeList = new FixedSizeList<int>(3);
            fixedSizeList.Add(1);
            fixedSizeList.Add(2);
            fixedSizeList.Add(3);

            Console.WriteLine("Items in the list:");
            for (int i = 0; i < fixedSizeList.Count; i++)
            {
                Console.WriteLine(fixedSizeList.Get(i));
            }

            Console.WriteLine("Attempting to add another item...");
            fixedSizeList.Add(4); // This should throw an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        try
        {
            var anotherFixedSizeList = new FixedSizeList<int>(2);
            anotherFixedSizeList.Add(10);
            anotherFixedSizeList.Add(20);

            Console.WriteLine("Attempting to get an item at an invalid index...");
            Console.WriteLine(anotherFixedSizeList.Get(3)); // This should throw an exception
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}