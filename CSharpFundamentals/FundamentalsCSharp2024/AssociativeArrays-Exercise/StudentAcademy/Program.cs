namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new Student()
                    {
                        Name = name,
                        Grade = new List<decimal> { grade }
                    };
                }
                else
                {
                    students[name].Grade.Add(grade);
                }
            }
            foreach ( var student in students)
            {
                if (student.Value.Grade.Average() >= 4.5m)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Grade.Average():F2}");
                }
            }
        }
    }
    public class  Student
    {
        public string Name { get; set; }
        public List<decimal> Grade { get; set; }
    }
}
