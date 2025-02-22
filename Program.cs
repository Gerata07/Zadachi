using System.Reflection;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] parts = input.Split("/");
                string type=parts[0];
                string brand = parts[1];
                string model = parts[2];
                int info=int.Parse(parts[3]);
                if (type=="Car")
                {
                    int hp=int.Parse(parts[3]);
                    Car newcar = new Car(brand, model, hp);
                    catalog.Cars.Add(newcar);
                    
                }
                else
                {
                    int weight=int.Parse(parts[3]);
                    Truck newtruck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(newtruck);
                    
                }


            }

            List<Car> sortedCars = catalog.Cars.OrderBy(car=>car.Brand).ToList();
            List<Truck> sortedTrucks = catalog.Trucks.OrderBy(car => car.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var car in sortedTrucks)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.Weight}kg");
            }

        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight=weight;
            }



        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HP { get; set; }
            public Car(string brand, string model,int hp)
            {
                Brand = brand;
                Model = model;
                HP = hp;
            }



        }

        public class Catalog
        {
            public List<Car> Cars { get; set; } = new List<Car>();
            public List<Truck> Trucks { get; set; } = new List<Truck>();
            



        }
    }
}
