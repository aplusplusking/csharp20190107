using System;
using System.Runtime.InteropServices;

namespace TypeCastExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(int));
            int iSize = sizeof(int);
            Console.WriteLine($"int형 바이트길이 : {iSize}");

            Type myType1 = typeof(int);
            Console.WriteLine($"type(int) : {myType1}");

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine($"i.GetType() : {myType2}");

            int j = 99;
            Console.WriteLine("Size of j : {0}", Marshal.SizeOf(j));
        }
    }
}
