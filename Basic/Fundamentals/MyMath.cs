using System;
using System.Collections.Generic;

class MyMath
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int intMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }


    public IEnumerable<int> GetOddNumbers(int limit)
    {
        for (int i = 0; i <= limit; i++)
        {
            if (i %2 != 0)
            {
                yield return i;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MyMath math = new MyMath();


        int sum = math.Add(0, 5);
        Console.WriteLine(sum);

        int max = math.intMax(5, 10);
        Console.WriteLine(max);

        foreach (int odd in math.GetOddNumbers(10))
        {
            Console.WriteLine(odd); 
        }
    }
}