using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата n1, n2 и оператор
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine()); // '+'; '-'; '*'; '/'; '%'

            //2. Проверяваме дали оператора е 
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result;
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else //operation == '*'
                {
                    result = num1 * num2;
                }

                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else //operation == '/' || operation == '%' 
            {
                //  => дали n2=0 
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (operation == '/')
                {
                    Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2:f2}");
                }
                else //(operation == '%')
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }

            }

        }
    }
}