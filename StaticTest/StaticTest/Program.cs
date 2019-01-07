using System;
namespace StaticTest{
    class Emp
    {
       public string name;//1
       public static string compName;//2
       public void GoToOffice()//1
        {
            Console.WriteLine($"{compName} 소속 {name}(이)가 출근합니다.");
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp.compName = "탑크리에듀";//2
            Emp e = new Emp();//1
            e.name = "홍길동"; e.GoToOffice();//1
        }
    }
}