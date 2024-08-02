using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_ADV_C__2
{
    public class Part1
    {

        #region arrayList
        /* Structure
                Type: Non-generic collection.
                Underlying Data Structure: Array.
                Dynamic Resizing: Resizes dynamically as elements are added.
          *Time Complexity
                Access: O(1)
                Search: O(n)
                Insertion: O(n) (worst case due to resizing)
                Deletion: O(n)
           *Business Case
                ArrayList is useful when the number of elements is unknown and there is a need for a collection that can store objects of different types. However, its lack of type safety and lower performance compared to generic collections often make it less preferable in modern applications.
        */

        public static void Main()
        {
            ArrayList arrayList = new ArrayList() { 1, "two", 3.0 };
            arrayList.Add(4);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region LinkedList

        /*
         * Structure
                Type: Generic collection.
                Underlying Data Structure: Doubly linked list.
         * Time Complexity
                Access: O(n)
                Search: O(n)
                Insertion: O(1) (at the head or tail)
                Deletion: O(1) (with reference to the node)
         * Business Case
                LinkedList<T> is beneficial when frequent insertions and deletions are required at the beginning or end of the list. It is not as efficient for indexed access due to its O(n) time complexity for such operations. 

        */

        public static void Main1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddFirst(0);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region List 

        /*   Structure
                Type: Generic collection.
                Underlying Data Structure: Array.
                Dynamic Resizing: Resizes dynamically as elements are added.
           * Time Complexity
                Access: O(1)
                Search: O(n)
                Insertion: O(n) (worst case due to resizing)
                Deletion: O(n)
           * Business Case
                List<T> is the most commonly used collection for storing a sequence of elements due to its type safety, performance, and ease of use. It is ideal for cases where the size of the collection can change dynamically, but fast indexed access is also required./*


                */

        public static void Main2()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            list.Add(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Queue

        /*  Structure
                Type: Generic collection.
                Underlying Data Structure: Circular array or linked list.
                Order: First-In-First-Out (FIFO).
            Time Complexity
                Enqueue: O(1)
                Dequeue: O(1)
                Peek: O(1)
            Business Case
                Queue<T> is useful for scenarios where order matters, such as processing tasks in the order they were added, implementing breadth-first search algorithms, or handling asynchronous data./*


                */





        public static void Main3()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        #endregion

        #region Stack


        /*  Structure
                Type: Generic collection.
                Underlying Data Structure: Array or linked list.
                Order: Last-In-First-Out (LIFO).
            Time Complexity
                Push: O(1)
                Pop: O(1)
                Peek: O(1)
            Business Case
                Stack<T> is suitable for scenarios where the last added element is the first to be processed, such as depth-first search algorithms, expression evaluation, or undo functionality in applications./*

                */

        public static void Main4()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    #endregion
    }
}
















