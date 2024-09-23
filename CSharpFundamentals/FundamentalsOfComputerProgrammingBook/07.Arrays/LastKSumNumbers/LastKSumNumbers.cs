﻿using System;
using System.Linq;
using System.Numerics;

namespace LastKSumNumbers

{
    internal class LastKSumNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            var nums = new BigInteger[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                BigInteger sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += nums[prev];
                    }
                    nums[i] = sum;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}