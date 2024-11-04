namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Car> cars = new List<Car>();  

            List<Truck> trucks = new List<Truck>();
            decimal carsHP = 0;
            decimal trucksHP = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] array = input.Split();

                switch (array[0])
                {
                    case "truck":
                        Truck truck = new Truck()
                        {
                            Type = array[0],
                            Model = array[1],
                            Color = array[2],
                            HP = int.Parse(array[3])
                        };
                        trucksHP += truck.HP;
                        trucks.Add(truck);
                        break;
                    case "car":
                        Car car = new Car()
                        {
                            Type= array[0],
                            Model = array[1],
                            Color = array[2],
                            HP = int.Parse(array[3])
                        };
                        carsHP += car.HP;
                        cars.Add(car);
                        break;
                }
            }
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (car.Model == input)
                    {
                        Console.WriteLine($"Type: Car\nModel: {car.Model}\nColor: {car.Color}\nHorsepower: {car.HP}");
                    }
                }
                foreach (var truck in trucks)
                {
                    if (truck.Model == input)
                    {
                        Console.WriteLine($"Type: Truck\nModel: {truck.Model}\nColor: {truck.Color}\nHorsepower: {truck.HP}");
                    }
                }
            }
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carsHP / cars.Count):F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(trucksHP / trucks.Count):F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }
    }
    public class Car
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }

    public class Truck
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }
}
