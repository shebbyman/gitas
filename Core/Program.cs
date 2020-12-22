using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Program
    {
        static void Foo()
        {
            Console.WriteLine("Foo");
        }

        static void Bar()
        {
            Console.WriteLine("Bar");
        }

        static void Baz()
        {
            Console.WriteLine("Baz");
        }

        public static int Summator(int x, int y)
        {
            return x + y;
        }

        public static bool Checker(string username)
        {
            return username.Length == 10 ? true : false;
        }

        public static int SomeUselessMethod()
        {
            Console.WriteLine("I do nothing like the rest");
            return 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
