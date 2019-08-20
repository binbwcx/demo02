using System;
using System.Collections.Generic;
using static System.Console;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Program classa = new Program();
            classa.mymethod(ref a);
            Console.WriteLine(a);
            

        }
        void mymethod(ref int val)
        {
            val += 1;

        }
    }
}
