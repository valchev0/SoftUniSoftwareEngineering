﻿using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string newPassword;
            while ((newPassword = Console.ReadLine()) != password);
            Console.WriteLine($"Welcome {username}!");
        }
    }
}