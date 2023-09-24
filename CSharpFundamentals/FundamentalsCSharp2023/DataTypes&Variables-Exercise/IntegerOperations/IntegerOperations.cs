namespace IntegerOperations
{
    internal class IntegerOperations
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;
            sum = sum / thirdNum;
            sum = sum * forthNum;
            Console.WriteLine(sum);
        }
    }
}