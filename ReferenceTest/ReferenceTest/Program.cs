using System;

namespace ReferenceTest
{
    class Rtype
    {
        public object Value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rtype a = new Rtype();
            Rtype b = new Rtype();

            a.Value = 1;   b = a;
           Console.WriteLine(a.Value); Console.WriteLine(b.Value);

            b.Value = 2;
            Console.WriteLine(a.Value);          Console.WriteLine(b.Value);
        }
    }
}
