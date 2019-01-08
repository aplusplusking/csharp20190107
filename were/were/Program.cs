using System;


namespace were
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;
        private string name;

        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}객체 생성됨...");
        }
        ~Garbage()
        {
            if (!isDispose)
            {
                Dispose();
            }
        }
        public void Dispose()
        {
            isDispose = true;
            Console.WriteLine($"{name}객체의 리소스 해제 OK...");
            GC.SuppressFinalize(this);
            
        }
    }
    class GarbageTest1
    {
      
        static void Main(string[] args)
        {
            Garbage g1 = new Garbage("1번"); Garbage g2 = new Garbage("2번");
            Garbage g3 = new Garbage("3번"); Garbage g4 = new Garbage("4번");

            g1.Dispose(); GC.SuppressFinalize(g2);
        }
    }
}
