using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            var boomer = new Boomer();
            boomer.Boom += Boomer_boom;
            boomer.Start();
            #endregion

            #region 2
            Action a = () => Console.WriteLine(":))");
            a += () => Console.WriteLine(":((");

            a();
            #endregion
        }

        private static void Boomer_boom(object source,EventArgs args)
        {
            Console.WriteLine("Boom");
        }
    }

    
}
