using System;


namespace dd
{
    class Emp
    {
       public string Name { get; set; }
        public int Empno { get; set; }
    }
 
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp() { Name = "홍길동", Empno = 1004 };

            Emp e1 = new Emp();
            e1.Name = "홍길동";
            e1.Empno = 1004;

            Console.WriteLine($"{e}");
        }
    }
}
