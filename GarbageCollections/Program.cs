using System;

namespace GarbageCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           /* Division S = new Division();
            S.Mul(2, 5);
            S.Div(10, 5);*/
            Console.WriteLine("no of gen" + GC.MaxGeneration);
            Console.WriteLine("");
            Console.WriteLine("memory" + GC.GetTotalMemory(false));
            Division  d = new Division();
            Console.WriteLine("cal " + GC.GetGeneration(d) + "Generation");
            Console.WriteLine("before gc 0th gen" + GC.CollectionCount(0));
            Console.WriteLine("before gc 1th gen" + GC.CollectionCount(1));
            Console.WriteLine("before gc 2th gen" + GC.CollectionCount(2));
            GC.Collect();
            Console.WriteLine("after gc 0th gen" + GC.CollectionCount(0));
            Console.WriteLine("after gc 1th gen" + GC.CollectionCount(1));
            Console.WriteLine("after gc 2th gen" + GC.CollectionCount(2));
        }
    }
}
