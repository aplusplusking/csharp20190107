using System;
using System.Collections;


namespace sampleArrayTest
{
   public class SamplesArrayList
    {
        static void Main(string[] args)
        {
            ArrayList onj = new ArrayList();
            onj.Add("Onj");
            onj.Add("OracleJava");
            onj.Add("Community");

            Console.WriteLine("onj List");
            Console.WriteLine($"   count   {onj.Count} ");
            Console.WriteLine($"   capacity   {onj.Capacity} ");

            Console.WriteLine("onj Values:");
            PrintValues(onj);
            ArrayList onj2 = (ArrayList)onj.Clone();
            Console.WriteLine(" onj2 Values:");
            PrintValues(onj2);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)          Console.WriteLine($"{obj}");
                Console.WriteLine();
        }
    }
}
