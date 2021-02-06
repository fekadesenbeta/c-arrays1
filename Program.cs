using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -5 };
            Test(a);
            Console.WriteLine(a[0]);
        }

        static void Test(int[] a)
        {
            a[0] = 100;

        }
    }
}
