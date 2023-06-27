using System;

class ComparingFloats
{
    static void Main()
    {
        decimal eps = 0.000001m;
        int counter = 0;
        while (counter < 6)
        {
            counter++;
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal diffrenceBetween = Math.Abs(firstNumber - secondNumber);
            bool isDiffrence = diffrenceBetween < eps;
            if (diffrenceBetween > eps)
            {
                Console.WriteLine(isDiffrence);
                Console.WriteLine("The diffrence of {0} is too big (> eps)", diffrenceBetween);
            }
            else if (diffrenceBetween < eps)
            {
                Console.WriteLine(isDiffrence);
                Console.WriteLine("The difference {0} < eps", diffrenceBetween);
            }
            else if(diffrenceBetween == eps)
            {
                Console.WriteLine(isDiffrence);
                Console.WriteLine("Border case. The difference {0} == eps. " +
                    "\nWe consider the numbers are different.", diffrenceBetween);
            }
        }
    }
}