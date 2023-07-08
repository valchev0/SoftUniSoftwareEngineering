using System;
using System.ComponentModel.Design;

namespace LeftAndRightSum
{
    internal class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0; 
            int rightSum = 0;
            int currentNum = 0;
            for (int j = 0; j < n; j++)
            {
                currentNum = int.Parse(Console.ReadLine());
                leftSum += currentNum;
            }
            for (int k = 0; k < n; k++)
            {
                currentNum = int.Parse(Console.ReadLine());
                rightSum += currentNum;
            }
            int diffrence = Math.Abs(leftSum - rightSum);
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", diffrence);
            }
        }
    }
}