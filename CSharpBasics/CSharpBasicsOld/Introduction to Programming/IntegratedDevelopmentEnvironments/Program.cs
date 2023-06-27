using System;
using System.Net.Http.Headers;

class IntegratedDevelopmentEnvironments
{
    static void Main()
    {
        Thread.Sleep(1000);
        Console.WriteLine("An Integrated Development Environment (IDE) is a software application\n" +
            "that helps to develop software with great ease.\n" +
            "It is a collection of tools and extensions that provides an environment to design,\n" +
            "develop, test, and publish software.");
        Thread.Sleep(2000);
        Console.WriteLine("Top Integrated Development Environments (IDE)");
        Thread.Sleep(1000);
        Console.WriteLine("1. Visual Studio");
        Thread.Sleep(1000);
        Console.WriteLine("2. Eclipse");
        Thread.Sleep(1000);
        Console.WriteLine("3. NetBeans");
        Thread.Sleep(1000);
        Console.WriteLine("4. Komodo");
        Thread.Sleep(1000);
        Console.WriteLine("5. Visual Studio Code");
        Thread.Sleep(2000);
        Console.WriteLine("Please selact number for more information: ");
        Thread.Sleep(3000);
        string input;
        while ((input = Console.ReadLine()) != "n")
        {
            int number = int.Parse(input);
            switch (number)
            {
                case 0:
                    Console.WriteLine("Visual Studio is the best IDE!");
                    break;
                case 1:
                    Console.WriteLine("Visual Studio can be used to build varying application types like Windows applications,\n" +
                        "Web Applications, Cloud Services, Games, Mobile Apps, Web APIs, IoT Apps, etc.\n" +
                        "Visual Studio is highly customizable and new features can be added using extensions and there a ton of it.");
                    break;
                case 2:
                    Console.WriteLine("Eclipse can be used to develop a variety of application types ranging\n" +
                        "from Web applications to mobile apps, cloud services to IoT applications,\n" +
                        "and from Machine Learning and Artificial Intelligence applications to native desktop applications.\n" +
                        "Eclipse feature can be extended via plugins and there thousands of them in the marketplace.");
                    break;
                case 3:
                    Console.WriteLine("NetBeans can be used mostly for Web applications and services,\n" +
                        "mobile applications, desktop applications.\n" +
                        "The IDE provides a simple drag and drop interface making it convenient for the user\n" +
                        "to develop applications faster.\n" +
                        "The feature of the NetBeans can be easily extended via plugins.");
                    break;
                case 4:
                    Console.WriteLine("Komodo IDE is can be used for developing web development,\n" +
                        "desktop, and mobile applications.\n" +
                        "The feature of the IDE can be enhanced by adding packages and addons.");
                    break;
                case 5:
                    Console.WriteLine("The editor provides supports for many languages like\n" +
                        "C#, Java, C++, PHP, Python, Go, TypeScript, HTML, CSS, PowerShell, XML, JSON, Ruby, Rust, etc.\n" +
                        "New language support can be easily added via extensions and the user can work on a variety of application types.");
                    break;
            }
        }

    }
}
