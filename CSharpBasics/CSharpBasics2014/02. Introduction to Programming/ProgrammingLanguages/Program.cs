using System;
using System.Net.Http.Headers;

class ProgrammingLanguages
{
    static void Main()
    {
        Console.WriteLine("Most popular programming languages to learn in 2023");
        Thread.Sleep(1000);
        Console.WriteLine("1. JavaScript");
        Thread.Sleep(1000);
        Console.WriteLine("2. Python");
        Thread.Sleep(1000);
        Console.WriteLine("3. Java");
        Thread.Sleep(1000);
        Console.WriteLine("4. C#");
        Thread.Sleep(1000);
        Console.WriteLine("5. C++");
        Thread.Sleep(2000);
        Console.WriteLine("Please selact number for more information, or end the program with 'ESC': ");
        Thread.Sleep(3000);
        string input;
        while ((input = Console.ReadLine()) != "n")
        {
            int number = int.Parse(input);
            switch (number)
            {
                case 0:
                    Console.WriteLine("C# is the best for the first programming language!");
                    break;
                case 1:
                    Console.WriteLine("According to a study by Statista, \n" +
                        "JavaScript is the most popular language to learn. \n\r" +
                        "JavaScript (JS) is a scripting language used to make websites \n" +
                        "and mobile applications more interactive. It is also commonly used for game development. \n\r" +
                        "JavaScript is well-known for its ability to make websites come alive by adding elements\n" +
                        "such as animations, dropdown menus, and color-changing buttons.\n\r");
                    break;
                case 2:
                    Console.WriteLine("Python can be regarded as the future of programming languages. \n" +
                        "As per the latest statistics, Python is the main coding language for around 80% of developers. \n" +
                        "The presence of extensive libraries in Python facilitates artificial intelligence, data science, \n" +
                        "and machine learning processes.\n");
                    break;
                case 3:
                    Console.WriteLine("Java is one of the most powerful programming languages that is currently used\n" +
                        "in more than 3 billion devices.\n" +
                        "Java is currently one of the most trending technologies being used in desktop applications, \n" +
                        "mobile applications, web development, Artificial intelligence, cloud applications, and many more.\n");
                    break;
                case 4:
                    Console.WriteLine("C# is a programming language that runs on the .NET framework \n" +
                        "and is developed by Microsoft in 2000. \n" +
                        "It is effective in making desktop applications and games. \n" +
                        "As per the survey, 34% of the top mobile games are made using C#. \n" +
                        "It is a well-designed language and is highly in demand globally. \n" +
                        "So mastering C# is an amazing career option that you can make in 2023.\n");
                    break;
                case 5:
                    Console.WriteLine("C++ is a general purpose, compiled, and statically typed programming language.\n" +
                        "Known as “C with Classes,” C++ is an extension of C with the functionality of user-defined data classes.\n" +
                        "The high performance of C++ has made it the top language for use cases requiring fast rendering,\n" +
                        "including browsers, banking applications, and motion design software.\n");
                    break;
            }
        }

    }
}
