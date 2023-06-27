using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstSum = 0;
        int secondSum = 0;
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            num = int.Parse((Console.ReadLine()));
            firstSum += num;
        }
        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            secondSum += num;
        }
        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            int diffrence = Math.Abs(firstSum - secondSum);
            Console.WriteLine("No, diff={0}", diffrence);
        }
    }
}