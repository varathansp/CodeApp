using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary
{
    static class StaticEx
    {
        public static string name;

        public static void print()
        {
            Console.WriteLine("Varathan");
        }
    }
    public class MyNonStaticClass
    {
        private static int myStaticVariable = 0;

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }
}
