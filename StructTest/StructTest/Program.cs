using System;



namespace StructTest
{
    struct Emp
    {
        public int id; public string name;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Emp e; e.id = 1; e.name = "1길동";
            Console.WriteLine($"사번:{e.id}");
            Console.WriteLine($"이름:{e.name}");

            Emp e1 = new Emp();
            e1.id = 2; e1.name = "2길동";
            Console.WriteLine($"사번:{e1.id}");
            Console.WriteLine($"이름:{e1.name}");

        }
    }
}
