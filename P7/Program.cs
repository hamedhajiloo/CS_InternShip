using P7.WeakReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //var res1 = GetBlogEntry("2018/04/12/deconstruct-keyvaluepair");
            //Console.WriteLine(res1);

            #endregion
            #region 1-2
            //var numbers = new List<string>();
            //long total = 0;
            //for (int i = 1; i <= 10; ++i)
            //{
            //    numbers.Add(i.ToString());
            //    total += i;
            //}
            //Console.WriteLine("Total: {0}, average: {1}",
            //total, total / numbers.Count);


            ///// n*(n+1)/2 
            //Console.WriteLine("//////////Recursive Function /////////////");
            //Console.WriteLine(AddNumbers(10));

            #endregion

            #region 2
            //var cache = new WeakCache<string, byte[]>();
            //var data = new byte[100];
            //cache.Add("d", data);
            //byte[] fromCache;
            //Console.WriteLine("Retrieval: " + cache.TryGetValue("d", out fromCache));
            //Console.WriteLine("Same ref? " + object.ReferenceEquals(data, fromCache));
            //fromCache = null;
            //GC.Collect();
            //Console.WriteLine("Retrieval: " + cache.TryGetValue("d", out fromCache));
            //Console.WriteLine("Same ref? " + object.ReferenceEquals(data, fromCache));
            //fromCache = null;
            //data = null;
            //GC.Collect();
            //Console.WriteLine("Retrieval: " + cache.TryGetValue("d", out fromCache));
            //Console.WriteLine("Null? " + (fromCache == null));
            #endregion

            #region 3
            //LetMeKnowMineEnd  knowMineEnd   = new LetMeKnowMineEnd();
            //knowMineEnd.Dispose();
            //Complex complex = new Complex();
            //complex.SetValue(1, 1);
            //complex.DisplayValue();
            ////GC.Collect();
            #endregion

            #region 4 -IDisposable
            #region 4-1
            //using (StreamReader reader = File.OpenText(@"H:\temp\1.txt"))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            #endregion

            #region 4-2
            //StreamReader reader = File.OpenText(@"H:\temp\1.txt");
            //try
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            //finally
            //{
            //    if (reader != null)
            //    {
            //        ((IDisposable)reader).Dispose();
            //    }
            //}
            #endregion

            #region 4-3

            //using (Stream source = File.OpenRead(@"H:\temp\1.txt"))
            //using (Stream copy = File.Create(@"H:\temp\2.txt"))
            //{
            //    source.CopyTo(copy);
            //}
            #endregion

            #region 4-4
            //foreach (string file in Directory.EnumerateFiles(@"H:\temp"))
            //{
            //    Console.WriteLine(file);
            //}
            #endregion

            #region 4-5
            // var logger = new Logger(@"H:\temp");
            #endregion
            #endregion

            #region 5 -Boxing
            //int num = 42;
            //Show(num);

            #region 5-2
            //object boxed = 42;
            //int? nv = boxed as int?;
            //int? nv2 = (int?)boxed;
            //int v = (int)boxed;
            #endregion
            #endregion
        }

        static void Show(object o)
        {
            Console.WriteLine(o.ToString());
        }
        public static int AddNumbers(int n)
        {
            return n *(n + 1) / 2;
        }

        #region 1
        public static string GetBlogEntry(string relativeUri)
        {
            var baseUri = new Uri("http://www.interact-sw.co.uk/iangblog/");
            var fullUri = new Uri(baseUri, relativeUri);
            using (var w = new WebClient())
            {
                return w.DownloadString(fullUri);
            }
        }
        #endregion


      

    }

    public class Complex
    {

        // Class members, private  
        // by default 
        int real, img;

        // Defining the constructor 
        public Complex()
        {
            real = 0;
            img = 0;
        }

        // SetValue method sets  
        // value of real and img 
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        // DisplayValue displays  
        // values of real and img 
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
            LetMeKnowMineEnd knowMineEnd = new LetMeKnowMineEnd();
        }

        // Defining the destructor 
        // for class Complex 
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }

    } // End class Complex 

    public sealed class Logger : IDisposable
    {
        private StreamWriter _file;
        public Logger(string filePath)
        {
            _file = File.CreateText(filePath);
        }
        public void Dispose()
        {
            if (_file != null)
            {
                _file.Dispose();
                _file = null;
            }
        }
        // A real class would go on to do something with the StreamWriter, of course
    }
}
