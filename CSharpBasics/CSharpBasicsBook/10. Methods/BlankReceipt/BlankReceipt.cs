using System;

namespace BlankReceipt
{
    internal class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            Console.WriteLine("CASH RECEIPT\r\n------------------------------\r" +
                            "\nCharged to____________________\r\nReceived by___________________\r" +
                            "\n------------------------------\r" +
                            "\n(c) SoftUni");
        }
    }
}