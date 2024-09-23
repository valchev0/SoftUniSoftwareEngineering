using System;
namespace SubsetsWhoseSumIs0
{
    internal class SubsetsWhoseSumIs0
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int fifthNum = int.Parse(Console.ReadLine());

           
                int[] arr = new int[5];
                arr[0] = firstNum;
                arr[1] = secondNum;
                arr[2] = thirdNum;
                arr[3] = fourthNum;
                arr[4] = fifthNum;

            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j < arr.Length;j++)
                {
                    if (arr[i] != arr[j])
                    {
                        if (arr[i] + arr[j] == 0)
                        {
                            Console.WriteLine("{0} {1}", arr[i], arr[j]);
                            isFound = true;
                            break;
                        }
                    }
                    if(isFound)
                    {
                        break;
                    }
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[i] != arr[j] && arr[i] != arr[k])
                        {
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                Console.WriteLine("{0} {1} {2}", arr[i], arr[j], arr[k]);
                                isFound=true; 
                                break;
                            }
                        }
                        if (isFound)
                        {
                            break;
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
        }
    }
}