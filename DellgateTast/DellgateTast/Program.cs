using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellgateTast
{
    class Program
    {
        //delegate int SumDelegate(int i, int j);
        static void Main(string[] args)
        {
            Program p = new Program();
            Func< int,int,int > s =  p.Sum;
            Console.WriteLine(s(1, 2));
        }
         int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
