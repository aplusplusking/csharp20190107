using System;

namespace SevenCountTest
{
    class SevenCount
    {

        static int n;
        


        static int count;

        static void Main(string[] args)
        {

            Console.WriteLine("일정한 범위 내에서 7이 얼마나 있나 알아보는 프로그램입니다.\n숫자를 입력하세요:");

            n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                searchSeven(i);
            }
            Console.WriteLine($"{count}");
        }
        public static void searchSeven(int num)
        {
            if (num % 10 == 7) count++;
            if (num > 10) searchSeven(num / 10);
        }
    }

}
