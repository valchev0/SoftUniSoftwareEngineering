﻿using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Peter";
            string strAge = string.Empty;

            int age = 0;

            Console.WriteLine("Input {0}'s age: ", age);
            strAge = Console.ReadLine();

            try
            {
                age = Int32.Parse(strAge);
            }
            catch (FormatException)
            {

                Console.WriteLine("Wrong data format!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}