using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Name {get; set;}
        public int MilesPerGallon {get; set;}
        public string SeatMaterial {get; set;}
        public int NumberOfSeats {get; set;}
        public int NumberOfDoors {get; set;}
        public string Color {get; set;}
        public bool IsElectric {get; set;}
        public string OriginCountry {get; set;}
        public string PriceRange {get; set;}

        private static List<IVehicle> Vehicles = new List<IVehicle>();
        public Car()
        {
            Vehicles.Add(this);
        }

        public static void PrintDetails(Car car)
        {
            Console.WriteLine($"{"", -15} {car.Name, 15}");
            Console.WriteLine($"{"Made in", -15} {car.OriginCountry, 15}");
            Console.WriteLine($"{"Color", -15} {car.Color, 15}");
            Console.WriteLine($"{"Miles Per Gallon", -15} {car.MilesPerGallon, 15}");
            Console.WriteLine($"{"NumberOfSeats", -15} {car.NumberOfSeats, 15}");
            Console.WriteLine($"{"Seat Material", -15} {car.SeatMaterial, 15}");
            Console.WriteLine($"{"Number of Doors", -15} {car.NumberOfDoors, 15}");
            Console.WriteLine($"{"Gas/Electric", -15} {car.IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -15} {car.PriceRange, 15}");
        }
        public static void PrintDetails(Car car1, Car car2)
        {
            Console.WriteLine($"{"", -20} {car1.Name, 15} {car2.Name, 15}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"{"Made in", -20} {car1.OriginCountry, 15} {car2.OriginCountry, 15}");
            Console.WriteLine($"{"Color", -20} {car1.Color, 15} {car2.Color, 15}");
            Console.WriteLine($"{"Miles Per Gallon", -20} {car1.MilesPerGallon, 15} {car2.MilesPerGallon, 15}");
            Console.WriteLine($"{"Number Of Seats", -20} {car1.NumberOfSeats, 15} {car2.NumberOfSeats, 15}");
            Console.WriteLine($"{"Seat Material", -20} {car1.SeatMaterial, 15} {car2.SeatMaterial, 15}");
            Console.WriteLine($"{"Number of Doors", -20} {car1.NumberOfDoors, 15} {car2.NumberOfDoors, 15}");
            Console.WriteLine($"{"Electric?", -20} {car1.IsElectric, 15} {car2.IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -20} {car1.PriceRange, 15} {car2.PriceRange, 15}");
        }
    }
}