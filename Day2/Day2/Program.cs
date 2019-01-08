using System;


namespace Day2
{
    class Emp:Object
    {
        
        public string Name
        {
            get; set;         
        }
        public override string ToString()
        {
            return $"[사원]{Name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name="홍";
            Console.WriteLine(e.Name);
            
        }
    }
}
