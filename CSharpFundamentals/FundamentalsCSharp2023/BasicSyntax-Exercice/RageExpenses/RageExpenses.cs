using System;

namespace RageExpenses
{
    internal class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());         // trashes every 2nd game
            double mousePrice = double.Parse(Console.ReadLine());           // trashes every 3rd game
            double keyboardPrice = double.Parse(Console.ReadLine());        // trashes every 6th game
            double displayPrice = double.Parse(Console.ReadLine());         // trashes every 12th game

            int headsetTrashes = lostGames / 2;
            int mouseTrashes = lostGames / 3;
            int keyboardTrashes = lostGames / 6;
            int displayTrashes = lostGames / 12;

            double headsetBill = headsetPrice * headsetTrashes;
            double mouseBill = mousePrice * mouseTrashes;
            double keyboardBill = keyboardPrice * keyboardTrashes;
            double displayBill = displayPrice * displayTrashes;
            double bill = headsetBill + mouseBill + keyboardBill + displayBill;
            Console.WriteLine("Rage expenses: {0:0.00} lv.", bill);
        }
    }
}