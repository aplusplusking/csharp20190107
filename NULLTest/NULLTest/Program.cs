using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;
            Console.WriteLine($"Value of b is {b}");


            int c = a ?? 0;
            Console.WriteLine($"Velue of c is {c}");
            Console.ReadLine();
        }
    }
}
