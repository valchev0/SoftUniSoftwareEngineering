using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCounter = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int newPoints = 0;
            int w = 0;
            int f = 0;
            int sf = 0;
            int t = 0;
            for (int i = 1; i <= tournamentsCounter; i++)
            {
                string result = Console.ReadLine();
                t++;
                switch (result)
                {
                    case "W":
                        newPoints += 2000;
                        w++;
                        break;
                    case "F":
                        newPoints += 1200;
                        f++; break;
                    case "SF":
                        newPoints += 720;
                        sf++; break;
                }
            }
            double percentWin = ((double)w / t) * 100;
            double averageResult = ((newPoints / t));
            Console.WriteLine($"Final points: {startingPoints + newPoints}");
            Console.WriteLine($"Average points: {averageResult}");
            Console.WriteLine($"{percentWin:f2}%");

            //OR
            //int countTournaments = int.Parse(Console.ReadLine());
            //int startingPoints = int.Parse(Console.ReadLine());

            //int w = 0;
            //int f = 0;
            //int sf = 0;

            //int totalPoints = 0;

            //for (int i = 0; i < countTournaments; i++)
            //{
            //    string status = Console.ReadLine();
            //    switch (status)
            //    {
            //        case "W":
            //            w++;
            //            break;
            //        case "F":
            //            f++;
            //            break;
            //        case "SF":
            //            sf++;
            //            break;
            //    }

            //}
            //totalPoints = (((startingPoints + (w * 2000) + (f * 1200) + (sf * 720))));
            //double percentageWins = ((double)w / countTournaments) * 100;
            //double percentageFinals = ((double)f / countTournaments) * 100;
            //double percentageSemiFinals = ((double)sf / countTournaments) * 100;

            //double averageScore = ((double)totalPoints - startingPoints) / countTournaments;
            //double wins = ((double)w / countTournaments) * 100;

            //Console.WriteLine($"Final points: {totalPoints}");
            //Console.WriteLine($"Average points: {Math.Floor(averageScore)}");
            //Console.WriteLine($"{wins:f2}%");
        }
    }
}