using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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
            IEnumerable<CultureInfo> commaCultures =
            from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
            where culture.NumberFormat.NumberDecimalSeparator == ","
            select culture;
            foreach (CultureInfo culture in commaCultures)
            {
                Console.WriteLine(culture.Name);
            }
            Console.WriteLine(commaCultures.Count());
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
            var q = new SillyLinqProvider().Where(x => int.Parse(x)).Select(x => x.Hour);
            Console.WriteLine(q);
            #endregion
            #endregion


        }
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
}
