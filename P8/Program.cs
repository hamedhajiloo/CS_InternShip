using System;
using System.IO;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 -Getting an exception from a library call
            //using (var r = new StreamReader(@"C:\Temp\File.txt"))
            //{
            //    while (!r.EndOfStream)
            //    {
            //        Console.WriteLine(r.ReadLine());
            //    }
            //}
            #endregion

            #region 2 - Handling an exception
            //try
            //{
            //    using (StreamReader r = new StreamReader(@"C:\Temp\File.txt"))
            //    {
            //        while (!r.EndOfStream)
            //        {
            //            Console.WriteLine(r.ReadLine());
            //        }
            //    }
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Directory not Find");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Couldn't find the file");
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            #endregion
        }
    }
}
