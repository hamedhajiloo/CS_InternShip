using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace P9
{
    class Program
    {
        private readonly Func<string, string, bool> _authenticationStrategy;
        public Program(Func<string, string, bool> authenticationStrategy)
        {
            _authenticationStrategy = authenticationStrategy;
        }
        public delegate int MyDelegate(int a, int b);
        public delegate void MyDelegate2(string text);
        static void Main(string[] args)
        {
            #region 1
            //MyDelegate del = new MyDelegate(Sum);
            //Console.WriteLine(del(9, 5));
            //Console.WriteLine(del(19, 10));
            //Console.WriteLine("//*****************//");

            //MyDelegate del2 = new MyDelegate(Sub);
            //Console.WriteLine(del2(9, 5));
            //Console.WriteLine(del2(19, 10));
            //Console.WriteLine("//*****************//");

            #region 1-2
            //MyDelegate Mul = (a, b) => { return a * b; }; // 1
            //Console.WriteLine(Mul(10, 3));
            #endregion

            #endregion

            #region 2
            //Predicate<int> p1 = IsGreaterThanZero;
            //Predicate<int> p2 = IsLessThanZero;
            #endregion

            #region 3
            //Calculator calc = new Calculator(5, 10);
            //double sum = calc.Calculate((num1, num2) => num1 + num2);
            //double divided = calc.Calculate((num1, num2) => num1 / num2);
            //double sub = calc.Calculate((num1, num2) => num1 - num2);
            //Console.WriteLine($"sum : {sum} | div : {divided} | sub : {sub}");
            #endregion

            #region 4
            //MyDelegate2 del2 = test1;
            //del2 += test2;
            //del2 += test3;
            //del2("test ");
            #endregion

            #region 5
            #region 5-1
            //Predicate<object> po = IsLongString;
            //Predicate<string> ps = po;
            //Console.WriteLine(ps("Too short"));
            #endregion

            #region 5-2
            //Predicate<string> pred = IsLongString;
            //Func<string, bool> f = pred; // Will fail with compiler error
            #endregion


            #region 5-3

            //Predicate<string> pred = IsLongString;
            //var pred2 = new Func<string, bool>(pred);
            #endregion

            #region 5-4
            //Predicate<string> pred = IsLongString;
            //var pred2 = (Func<string, bool>)Delegate.CreateDelegate(
            //typeof(Func<string, bool>), pred.Target, pred.Method);
            #endregion
            #endregion

            #region 6 - lambda
            #region 6-1
            //Predicate<int> p1 = value => value > 0;
            //Predicate<int> p2 = (value) => value > 0;
            //Predicate<int> p3 = (int value) => value > 0;
            //Predicate<int> p4 = value => { return value > 0; };
            //Predicate<int> p5 = (value) => { return value > 0; };
            //Predicate<int> p6 = (int value) => { return value > 0; };
            #endregion

            #region 6-2
            //Func<bool> isAfternoon = () => DateTime.Now.Hour >= 12;
            #endregion

            #region 6-3
            //EventHandler clickHandler = delegate { Debug.WriteLine("Clicked!"); };
            #endregion
            #endregion


            #region student

            #region without lambda

            //Student st = new Student()
            //{
            //    ID = 10,
            //    Firstname = "hamed",
            //    Lastname = "hajiloo",
            //    AverageGrade = 17.93
            //};
            //IsValid checkStudent = HasValidGrade;
            //if (!checkStudent(st))
            //    Console.WriteLine("Invalid");
            //else
            //    Console.WriteLine("Valid");
            #endregion

            #region Lambda
            //Student st = new Student()
            //{
            //    ID = 10,
            //    Firstname = "hamed",
            //    Lastname = "hajiloo",
            //    AverageGrade = 17.93
            //};
            //IsValid checkStudent = (item) =>
            //{
            //    if (item.AverageGrade >= 0 && item.AverageGrade <= 20)
            //        return true;
            //    return false;
            //};
            //if (!checkStudent(st))
            //    Console.WriteLine("Invalid");
            //else
            //    Console.WriteLine("Valid");
            #endregion

            #region ساده شده عبارت لامبدا

            // IsValid checkStudent = student => student.AverageGrade >= 0 && student.AverageGrade <= 20;
            #endregion

            #endregion

            #region 8 
            //List<int> alaki = new List<int>
            //{
            //    1,2,4,5,32,32,12,45,65,3,5908
            //};
            //ParameterExpression valueParam = Expression.Parameter(typeof(int), "value");
            //ConstantExpression constantZero = Expression.Constant(110);
            //BinaryExpression comparison = Expression.GreaterThan(valueParam, constantZero);
            //Expression<Func<int, bool>> greaterThanZero =
            //Expression.Lambda<Func<int, bool>>(comparison, valueParam);

            //Console.WriteLine(constantZero.Value);
            #region 8-2
            //// Creating an expression tree.  
            //Expression<Func<int, bool>> expr = num => num < 5;

            //// Compiling the expression tree into a delegate.  
            //Func<int, bool> result = expr.Compile();

            //// Invoking the delegate and writing the result to the console.  
            //Console.WriteLine(result(4));

            #endregion
            #endregion

            #region 9

            //Console.WriteLine($@"Hello {((Func<string>)(() =>
            //{
            //    Console.Write("What's your name ? ");
            //    return Console.ReadLine();
            //})).Invoke()}");
            #endregion

            
            #region 10
            //Action Hello = () => Console.WriteLine("Hello:");

            //Hello += () => Console.WriteLine("  World");
            //Hello += () => Console.WriteLine("  .NET");
            //Hello += () => Console.WriteLine("  Khali");

            //Hello();
            #endregion
        }

        public static bool Aut(string name,string pass)
        {
            return name == "hamed" && pass == "123";
        }
        public static int Sum(int x, int y) => x + y;
        public static int Sub(int x, int y) => x - y;
        public static void test1(string text) => Console.WriteLine(text + "test1");
        public static void test2(string text) => Console.WriteLine(text + "test2");
        public static void test3(string text) => Console.WriteLine(text + "test3");



        public static int GetIndexOfFirstNonEmptyBin(int[] bins)
        {
            return Array.FindIndex(bins, IsGreaterThanZero);
        }
        private static bool IsGreaterThanZero(int value)
        {
            return value > 0;
        }
        private static bool IsLessThanZero(int value)
        {
            return value > 0;
        }
        public static bool IsLongString(object o)
        {
            var s = o as string;
            return s != null && s.Length > 20;
        }

        public static bool HasValidGrade(Student item)
        {
            if (item.AverageGrade >= 0 && item.AverageGrade <= 20)
                return true;
            return false;
        }

    }


}
