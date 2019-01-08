using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTest
{
    partial class Emp
    {
        public void GoToOffice()
        {
            Console.WriteLine("사원출근...");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.GoToOffice();
            e.GetOff();
        }
    }
}
