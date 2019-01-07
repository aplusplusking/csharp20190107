namespace AsTest
{
    class Emp
    {
        public override string
       ToString()
        {
            return "Emp";
        }
    }
    class Programmer : Emp { } //자식클래<<상속<<부모클래스
    class Program
    {
        static void Main()
        {
            Programmer p = new Programmer();
            if (p is Emp)//참
            {
                System.Console.WriteLine("p is Emp");
            }
            Emp e =(Emp)p;
            if (e != null)
                System.Console.WriteLine(e.ToString());
        }
    }
}