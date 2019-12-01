using System;

namespace P9
{
    class Program
    {
        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            #region 1
            MyDelegate del = new MyDelegate(Sum);
            Console.WriteLine(del(9,5));
            Console.WriteLine(del(19,10));
            Console.WriteLine("//*****************//");

            MyDelegate del2 = new MyDelegate(Sub);
            Console.WriteLine(del2(9, 5));
            Console.WriteLine(del2(19, 10));
            Console.WriteLine("//*****************//");

            #endregion
        }

        public static int Sum(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
    }
}
