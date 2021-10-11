using System;

namespace SleevesUp_TechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Technical Test");

            /* call function at client level  */
            using (Data dt = new Data())
            {
                dt.Processing();
                dt.Display();
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("");
        }
    }
}
