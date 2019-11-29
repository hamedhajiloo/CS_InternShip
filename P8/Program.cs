using System;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.PowerPoint;

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
            //catch (DirectoryNotFoundException x)
            //{
            //    Console.WriteLine($"Directory not Find : {0}", x.Data);
            //}
            //catch (FileNotFoundException x)
            //{
            //    Console.WriteLine($"Couldn't find the file : {0}", x.FileName);
            //}
            //catch (IOException x)
            //{
            //    Console.WriteLine("IO error: '{0}'", x.Message);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            #endregion

            #region 3 - Nested Try Block
            //try
            //{
            //    PrintFirstLineLength(@"C:\Temp\File.txt");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("NullReferenceException");
            //}

            #endregion

            #region 4- finally
            //try
            //{
            //    PrintFirstLineLength(@"C:\Temp\File.txt");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("NullReferenceException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("#####################");
            //}
            //finally
            //{
            //    //dispose object
            //    Console.WriteLine("Finally ...!");
            //}


            #endregion

            #region 5- Throw an Exception
            //CountCommas(null);
            #endregion

            #region 6 - ReThrowing Exception

            #region Bad
            //try
            //{
            //    // DoSomething();
            //}
            //catch (IOException x)
            //{
            //    LogIOError(x);
            //    // This next line is BAD!
            //    throw x; // Do not do this
            //}
            #endregion

            #region best
            //try
            //{
            //    // DoSomething();
            //}
            //catch (IOException x)
            //{
            //    LogIOError(x);
            //    throw;
            //}
            #endregion

            #endregion

            #region 7 - Async
            //Test t = new Test();
            //try
            //{
            //    t.Call();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            #endregion
        }

        private static void LogIOError(IOException x)
        {
            Console.WriteLine("masalan log shode!");
        }

        static void PrintFirstLineLength(string fileName)
        {
            try
            {
                using (var r = new StreamReader(fileName))
                {
                    try
                    {
                        Console.WriteLine(r.ReadLine().Length);
                    }
                    catch (IOException x)
                    {
                        Console.WriteLine("Error while reading file: {0}",
                        x.Message);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (FileNotFoundException x)
            {
                Console.WriteLine("Couldn't find the file '{0}'", x.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+" koli :))) ");
            }
        }

        public static int CountCommas(string text)
        {
            if (text == null)
            {
               // throw new ArgumentNullException("text");
                Console.WriteLine("Text");
                return 0;
            }
            return text.Count(ch => ch == ',');
        }

    }
}
