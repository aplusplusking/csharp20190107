/*C#에서는 bool 타입만이 논리연산자를 사용할 수가 있다. C에서는 0이나 -1을 false라고 묵시
적으로 생각하였으나, C#에서는 반드시 true, false로 명시하고 있다.
 int형은 bit 연산자만을 사용할 수 있는데 bit연산이란 정수를 2진수로 나타낸 후 각 자리의
bit들을 각각 연산하는 것이다.
 bool 타입은 논리 연산(&&, II) 대신 &, | 등을 사용할 수도 있다.
 A&&B의 경우, 만약 A가 false이면 더 이상 B를 계산하지 않고 계산 결과값이 false로 결정된
다.A가 true일때만 B를 계산한다.
 A||B의 경우, 만약 A가 true이면 더 이상 B를 계산하지 않고 계산 결과값을 true로 결정한다.
A가 false인 경우에만 B를 계산한다.
 A|B나 A&B의 경우, A가 값에 관계없이 계속해서 B를 계산해서 A와 B로 연산을 수행한 후에
계산 결과값 true를 결정한다.*/
using System;
class LogicalAnd
{
    static void Main()
    {
        //Method1이 false라도 Method2 실행
        Console.WriteLine("정상적인 AND:");
        if (Method1() & Method2())
            Console.WriteLine("Both methods returned true.");
        else
            Console.WriteLine("둘중 하나의 메소드는 fasle");
        //Method1이 false면 Method2는 실행 되지 않는다.
        Console.WriteLine("\n Short-circuit AND:");
        if (Method1() && Method2())
            Console.WriteLine("Both methods returned true.");
        else
            Console.WriteLine("둘중 하나의 메소드는 fasle");
        Console.WriteLine("0x{0:x}", 0xf8 & 0x3f); // 0x38
    }
    static bool Method1()
    {
        Console.WriteLine("메소드1...");
        return false;
    }
    static bool Method2()
    {
        Console.WriteLine("메소드2...");
        return true;
    }
}