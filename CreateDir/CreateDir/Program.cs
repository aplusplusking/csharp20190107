using System;

public class Emp
{

   public  override string ToString()
    {
        return "This is Emp class";
    }

}

public class ToStringMethod

{

    static void Main()

    {

        Emp e = new Emp();

        Object o = new Object();



        Console.WriteLine(o.ToString());

        Console.WriteLine(e.ToString());

        Console.WriteLine(e);

    }

}