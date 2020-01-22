using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Culture

            #region without linq
            //CultureInfo[] allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (CultureInfo culture in allCultures)
            //{
            //    if (culture.NumberFormat.NumberDecimalSeparator == ",")
            //    {
            //        Console.WriteLine(culture.Name);
            //    }
            //}
            #endregion


            #region with linq
            //IEnumerable<CultureInfo> commaCultures =
            //from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            //where culture.NumberFormat.NumberDecimalSeparator == ","
            //select culture;
            //foreach (CultureInfo culture in commaCultures)
            //    Console.WriteLine(culture.Name);
            //Console.WriteLine(commaCultures.Count());
            #endregion


            #region return Name
            //IEnumerable<string> commaCultures =
            //from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            //where culture.NumberFormat.NumberDecimalSeparator == ","
            //select culture.Name;
            //foreach (string cultureName in commaCultures)
            //{
            //    Console.WriteLine(cultureName);
            //}


            #region let

            //IEnumerable<string> commaCultures =
            //from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            //let numFormat = culture.NumberFormat
            //where numFormat.NumberDecimalSeparator == ","
            //select culture.Name;
            //foreach (string cultureName in commaCultures)
            //{
            //    Console.WriteLine(cultureName);
            //}


            //IEnumerable<string> commaCultures2 =
            //    CultureInfo.GetCultures(CultureTypes.AllCultures)
            //    .Select(c => new { c, num = c.NumberFormat }).Where(a => a.num.NumberGroupSeparator == ",").Select(c => c.c.Name);

            #endregion
            #endregion


            #endregion


            #region 2 - A meaningless query
            //var q = from x in new SillyLinqProvider()
            //        where int.Parse(x)
            //        select x.Hour;

            //Console.WriteLine(q);

            #region How the compiler transforms the meaningless query
            //var q = new SillyLinqProvider().Where(x => int.Parse(x)).Select(x => x.Hour);
            //Console.WriteLine(q);
            #endregion
            #endregion


            #region 3
            //var evenfib = from n in Fibonacci()
            //              where n < 1000
            //              select n;
            //foreach (BigInteger n in evenfib)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region 4 - Filtering (Where operator with index)
            //IEnumerable<Course> a = Course.Catalog.Where((course, index)
            //    => (index % 2 == 0) && course.Duration.TotalHours >= 3);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.Title);
            //}
            #endregion


            #region 5 - select operatoe with index
            //IEnumerable<string> nonIntro = Course.Catalog.Select((course, index) =>
            //                string.Format("Course {0}: {1}", index + 1, course.Title));

            //foreach (var item in nonIntro)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 6 - SelectMany
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //string[] letters = { "A", "B", "C" };
            //IEnumerable<string> combined = from number in numbers
            //                               from letter in letters
            //                               select letter + number;
            //foreach (string s in combined)
            //    Console.WriteLine(s);

            #region selectmany operator
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //string[] letters = { "A", "B", "C" };
            //var combined = numbers.SelectMany(numbers => letters, (numbers, letters) => letters + numbers);
            //foreach (string s in combined)
            //    Console.WriteLine(s);
            #endregion

            #endregion

            #region jagged array
            // int[][] arrays =
            // {
            //new[] { 1, 2 },
            //new[] { 1, 2, 3, 4, 5, 6 },
            //new[] { 1, 2, 4 },
            //new[] { 1 },
            //new[] { 1, 2, 3, 4, 5 }
            //};
            // IEnumerable<int> combined = from item in arrays
            //                             from number in item
            //                             select number;


            // var combined = arrays.SelectMany(item => item);

            // foreach (var item in combined)
            //     Console.WriteLine(item);
            #endregion

            #region 7
            // SelectManyExample.SelectManyEx2();
            #endregion

            #region 8


            //Console.WriteLine("Average course length in hours: {0}",
            //    Course.Catalog.Average(course => course.Duration.TotalHours));


            #endregion

            #region 9 - Aggregate
            //double t1 = Course.Catalog.Sum(course => course.Duration.TotalHours);
            //double t2 = Course.Catalog.Aggregate(
            //    0.0, (hours, course) => hours + course.Duration.TotalHours);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            #endregion

            #region 10 - Implementing Max with Aggregate
            //DateTime m = Course.Catalog.Aggregate(new DateTime(), (date, c) => date > c.PublicationDate ? date : c.PublicationDate);
            //Console.WriteLine(m);
            #endregion


            #region 11 -  Implementing average with Aggregate

            //double average = Course.Catalog.Aggregate(
            //                new { TotalHours = 0.0, Count = 0 },
            //                (totals, course) => new
            //                {
            //                    TotalHours = totals.TotalHours + course.Duration.TotalHours,
            //                    Count = totals.Count + 1
            //                },
            //                totals => totals.TotalHours / totals.Count);

            //Console.WriteLine(average);
            #endregion

            #region 12 - Grouping query expression
            //var subjectGroups = from course in Course.Catalog
            //                    group course by course.Category;
            //foreach (var group in subjectGroups)
            //{
            //    Console.WriteLine("Category: " + group.Key);
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course.Title);
            //    }
            //    Console.WriteLine();
            //    Console.ResetColor();
            //}
            #endregion

            #region 13
            //var subjectGroups = Course.Catalog.GroupBy(course => course.Category);
            //foreach (var group in subjectGroups)
            //{
            //    Console.WriteLine("Category: " + group.Key);
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course.Title);
            //    }
            //    Console.WriteLine();
            //    Console.ResetColor();
            //}
            #endregion

            #region 14
            //var subjectGroups = Course.Catalog.GroupBy(course => course.Category, course => course.Title);
            //foreach (var group in subjectGroups)
            //{
            //    Console.WriteLine("Category: " + group.Key);
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course);
            //    }
            //    Console.WriteLine();
            //    Console.ResetColor();
            //}
            #endregion

            #region 15
            //IEnumerable<string> subjectGroups = Course.Catalog.GroupBy(
            //course => course.Category,
            //course => course.Title,
            //(category, titles) =>
            //string.Format("Category '{0}' contains {1} courses: {2}",
            //category, titles.Count(), string.Join(", ", titles)));
            //foreach (var item in subjectGroups)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 16 -  Composite group key

            //var bySubjectAndYear =
            //        from course in Course.Catalog
            //        group course by new { course.Category, course.PublicationDate.Year };
            //foreach (var group in bySubjectAndYear)
            //{
            //    Console.WriteLine("{0} ({1})", group.Key.Category, group.Key.Year);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course.Title);
            //    }
            //    Console.ResetColor();
            //}
            #endregion

            #region 17 - How not to cast a sequence
            //IEnumerable<object> sequence = Course.Catalog.Select(c => (object)c);
            //var courseSequence = (IEnumerable<Course>)sequence; // InvalidCastException

            #endregion

            #region 18 - How to cast a sequence
            IEnumerable<object> sequence = Course.Catalog.Select(c => (object)c);
            var courseSequence = sequence.Cast<Course>();
            #endregion

        }

        

        static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger n1 = 1;
            BigInteger n2 = 1;
            yield return n1;
            while (true)
            {
                yield return n2;
                BigInteger t = n1 + n2;
                n1 = n2;
                n2 = t;
            }
        }


        //static IEnumerable<T2> MySelectMany<T, T2>( this  IEnumerable<T> src,
        //    Func<T, IEnumerable<T2>> getInner)
        //{
        //    foreach (T itemFromOuterCollection in src)
        //    {
        //        IEnumerable<T2> innerCollection = getInner(itemFromOuterCollection);
        //        foreach (T2 itemFromInnerCollection in innerCollection)
        //            yield return itemFromInnerCollection;
        //    }
        //}
    }

    public class SillyLinqProvider
    {
        public SillyLinqProvider Where(Func<string, int> pred)
        {
            Console.WriteLine("Where invoked");
            return this;
        }
        public string Select<T>(Func<DateTime, T> map)
        {
            Console.WriteLine("Select invoked, with type argument " + typeof(T));
            return "This operator makes no sense";
        }
    }



    //public static class CustomLinqProvider
    //{
    //    public static CultureInfo[] Where(this CultureInfo[] cultures,
    //    Predicate<CultureInfo> filter)
    //    {
    //        return Array.FindAll(cultures, filter);
    //    }
    //    public static T[] Select<T>(this CultureInfo[] cultures,
    //    Func<CultureInfo, T> map)
    //    {
    //        var result = new T[cultures.Length];
    //        for (int i = 0; i < cultures.Length; ++i)
    //        {
    //            result[i] = map(cultures[i]);
    //        }
    //        return result;
    //    }
    //}



    public class Course
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Number { get; set; }
        public DateTime PublicationDate { get; set; }
        public TimeSpan Duration { get; set; }
        public static readonly Course[] Catalog =
        {
                                    new Course
{
Title = "Elements of Geometry",
Category = "MAT", Number = 101, Duration = TimeSpan.FromHours(3),
PublicationDate = new DateTime(2009, 5, 20)
},
                                    new Course
{
Title = "Squaring the Circle",
Category = "MAT", Number = 102, Duration = TimeSpan.FromHours(7),
PublicationDate = new DateTime(2009, 4, 1)
},
                                    new Course
{
Title = "Recreational Organ Transplantation",
Category = "BIO", Number = 305, Duration = TimeSpan.FromHours(4),
PublicationDate = new DateTime(2002, 7, 19)
},
                                    new Course
{
Title = "Hyperbolic Geometry",
Category = "MAT", Number = 207, Duration = TimeSpan.FromHours(5),
PublicationDate = new DateTime(2007, 10, 5)
},
                                    new Course
{
Title = "Oversimplified Data Structures for Demos",
Category = "CSE", Number = 104, Duration = TimeSpan.FromHours(2),
PublicationDate = new DateTime(2012, 2, 21)
},
                                    new Course
{
Title = "Introduction to Human Anatomy and Physiology",
Category = "BIO", Number = 201, Duration = TimeSpan.FromHours(12),
PublicationDate = new DateTime(2001, 4, 11)
},
        };
    }
}
