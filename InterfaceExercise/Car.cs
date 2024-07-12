using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int MilesPerGallon {get; set;}
        public string SeatMaterial {get; set;}
        public int NumberOfSeats {get; set;}
        public int NumberOfDoors {get; set;}
        public string Color {get; set;}
        public bool IsElectric {get; set;}
        public string OriginCountry {get; set;}
        public string PriceRange {get; set;}

        public List<Car> Vehicles = new List<Car>();
        public Car()
        {
            Vehicles.Add(this);
        }

        public void PrintDetails(Car car)
        {
            Console.WriteLine($"{"", -10} {nameof(car), 10}");
            Console.WriteLine($"{"Made in", -10} {OriginCountry, 10}");
            Console.WriteLine($"{"Color", -10} {Color, 10}");
            Console.WriteLine($"{"Miles Per Gallon", -10} {MilesPerGallon, 10}");
            Console.WriteLine($"{"NumberOfSeats", -10} {NumberOfSeats, 10}");
            Console.WriteLine($"{"Seat Material", -10} {SeatMaterial, 10}");
            Console.WriteLine($"{"Number of Doors", -10} {NumberOfDoors, 10}");
            Console.WriteLine($"{"Gas/Electric", -10} {IsElectric, 10}");
            Console.WriteLine($"{"Price Range", -10} {PriceRange, 10}");
        }
        public void PrintDetails(Car car1, Car car2)
        {
            Console.WriteLine($"{"", -10} {nameof(car1), 10}");
            Console.WriteLine($"{"Made in", -10} {car1.OriginCountry, 10} {car2.OriginCountry, 10}");
            Console.WriteLine($"{"Color", -10} {car1.Color, 10} {car2.Color, 10}");
            Console.WriteLine($"{"Miles Per Gallon", -10} {car1.MilesPerGallon, 10} {car2.MilesPerGallon, 10}");
            Console.WriteLine($"{"NumberOfSeats", -10} {car1.NumberOfSeats, 10} {car2.NumberOfSeats, 10}");
            Console.WriteLine($"{"Seat Material", -10} {car1.SeatMaterial, 10} {car2.SeatMaterial, 10}");
            Console.WriteLine($"{"Number of Doors", -10} {car1.NumberOfDoors, 10} {car2.NumberOfDoors, 10}");
            Console.WriteLine($"{"Gas/Electric", -10} {car1.IsElectric, 10} {car2.IsElectric, 10}");
            Console.WriteLine($"{"Price Range", -10} {car1.PriceRange, 10} {car2.PriceRange, 10}");
        }
    }
}