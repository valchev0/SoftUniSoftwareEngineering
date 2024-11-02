namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split("/");
                if (data[0] == "Car")
                {
                    Car car = new()
                    {
                        CarBrand = data[1],
                        CarModel = data[2],
                        HorsePower = int.Parse(data[3])
                    };
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new()
                    {
                        TruckBrand = data[1],
                        TruckModel = data[2],
                        TruckWeight = int.Parse(data[3])
                    };
                    trucks.Add(truck);
                }
            }

            PrintCars(cars);
            PrintTrucks(trucks);
        }

        private static void PrintTrucks(List<Truck> trucks)
        {
            if (trucks.Count > 0)
            {
                List<Truck> orderedTrucks = trucks.OrderBy(truck => truck.TruckBrand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.TruckBrand}: {truck.TruckModel} - {truck.TruckWeight}kg");
                }
            }
        }

        private static void PrintCars(List<Car> cars)
        {
            if (cars.Count > 0)
            {
                List<Car> orderedCars = cars.OrderBy(car => car.CarBrand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.HorsePower}hp");
                }
            }
        }
    }
    class Car
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string TruckBrand { get; set; }
        public string TruckModel { get; set; }
        public int TruckWeight { get; set ; }
    }
}
