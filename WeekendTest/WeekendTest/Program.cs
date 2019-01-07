using System;

namespace WeekendTest
{
    enum Day1
    {
        Monday, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Day2 : byte
    {
        Monday = 11, Thesday, Wednesday, Thursday, Friday, Saturday, Sunday = Monday + 100
    }
    public class EnumTest
    {
        static void Main(string[] args)
        {
            Day1 whatDay = Day1.Sunday;
            Console.WriteLine($"{whatDay}");
            Console.WriteLine($"{(int)whatDay}");

            whatDay = (Day1)6;
            Console.WriteLine($"{whatDay}");

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine($"{whatDay2}");
            Console.WriteLine($"{(byte)whatDay2}");

            whatDay2 = (Day2)111;
            Console.WriteLine($"{whatDay2}");
        
        }
    }
}
