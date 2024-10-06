namespace ListOfProducts
{
    internal class ListOfProducts
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            AbsorbingMetod(n, list);
            list.Sort();
            PrintingMethod(list);
        }
        static void AbsorbingMetod(int n, List<string> list)
        {
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
        }
        static void PrintingMethod(List<string> list)
        {
            int counter = 1;
            foreach (string element in list)
            {
                Console.WriteLine("{0}.{1}", counter, element);
                counter++;
            }
        }
    }
}
