using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Collections
    {
        /// <summary>
        /// using generics in collections followings methods are done
        /// </summary>
        public static void DoListDemo()
        {
            //array of list
            Console.WriteLine("do list demo");
            List<string> list = new List<string>();
            list.Add("ravi");
            list.Add("anu");
            list.Add("ram");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        public static void DoStackDemo()
        {
            //stack method
            Console.WriteLine("**************************");
            Console.WriteLine("do stack demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Akhila");
            stack.Push("Anuhya");
            stack.Push("Nani");
            stack.Push("Rahul");
            stack.Push("Sandeep");
            string pop = stack.Pop();
            //iterating stack elememts
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element:" + pop);
        }
        public static void DoQueueDemo()
        {
            //using queue method
            Console.WriteLine("**************************");
            Console.WriteLine("do queue demo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Shrma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Raju sharma");
            queue.Enqueue("Sharth varma");
            Console.WriteLine("head:" + queue.Peek());
            Console.WriteLine("iterating the queue elements");
            //iterating queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("dequeue element:" + dequeue);
            Console.WriteLine("iterating the queue elements after dequeue one element ");
            //iterating queue elements using enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DoDictionaryDemo()
        {
            //using dictionary 
            Console.WriteLine("**************************");
            Console.WriteLine("do dictionary demo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100,"amit");
            dictionary.Add(200, "Ram");
            dictionary.Add(500, "jhon");
            dictionary.Add(90, "Harsha");
            Console.WriteLine("access value using key(key=100):" + dictionary[100]);
            Console.WriteLine("iterating dictionary");
            //iterating dictionary elements
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }

        }
    }
}
