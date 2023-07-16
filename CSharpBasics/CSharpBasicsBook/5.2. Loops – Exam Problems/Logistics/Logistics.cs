using System;

namespace Logistics
{
    internal class Logistics
    {
        static void Main(string[] args)
        {
            int loadsCarrige = int.Parse(Console.ReadLine());
            double vanTons = 0;
            double truckTons = 0;
            double trainTons = 0;
            double totalTons = 0;

            for (int i = 0; i < loadsCarrige; i++)
            {
                int currentCarrige = int.Parse(Console.ReadLine());
                if (currentCarrige > 11)
                {
                    trainTons += currentCarrige;
                }
                else if (currentCarrige <= 11 && currentCarrige > 3)
                {
                    truckTons += currentCarrige;
                }
                else
                {
                    vanTons += currentCarrige;
                }
                totalTons += currentCarrige;
            }
            double averagePriceTon = ((vanTons * 200) + (truckTons * 175) + (trainTons * 120)) / totalTons;
            vanTons /= totalTons;
            truckTons /= totalTons;
            trainTons /= totalTons;
            Console.WriteLine("{0:0.00} \n{1:p} \n{2:p} \n{3:p}", averagePriceTon, vanTons, truckTons, trainTons);
        }
    }
}