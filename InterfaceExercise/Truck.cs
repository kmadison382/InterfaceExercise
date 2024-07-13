using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Name {get; set;}
        public bool IsTall {get; set;}
        public string TowingCapacity {get; set;}
        public int NumberOfDoors {get; set;}
        public int NumberOfSeats {get; set;}
        public string Color {get; set;}
        public bool IsElectric {get; set;}
        public string OriginCountry {get; set;}
        public string PriceRange {get; set;}
        private static List<IVehicle> Vehicles = new List<IVehicle>();
        public Truck()
        {
            Vehicles.Add(this);
        }
        public static void PrintDetails(Truck truck)
        {
            Console.WriteLine($"{"", -15} {truck.Name, 15}");
            Console.WriteLine($"{"Made in", -15} {truck.OriginCountry, 15}");
            Console.WriteLine($"{"Color", -15} {truck.Color, 15}");
            Console.WriteLine($"{"Towing Capacity", -15} {truck.TowingCapacity, 15}");
            Console.WriteLine($"{"Tall?", -15} {truck.IsTall, 15}");
            Console.WriteLine($"{"NumberOfSeats", -15} {truck.NumberOfSeats, 15}");
            Console.WriteLine($"{"Number of Doors", -15} {truck.NumberOfDoors, 15}");
            Console.WriteLine($"{"Electric?", -15} {truck.IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -15} {truck.PriceRange, 15}");
        }
        public static void PrintDetails(Truck truck1, Truck truck2)
        {
            Console.WriteLine($"{"", -20} {truck1.Name, 15} {truck2.Name, 15}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"{"Made in", -20} {truck1.OriginCountry, 15} {truck2.OriginCountry, 15}");
            Console.WriteLine($"{"Color", -20} {truck1.Color, 15} {truck2.Color, 15}");
            Console.WriteLine($"{"Towing Capacity", -20} {truck1.TowingCapacity, 15} {truck2.TowingCapacity, 15}");
            Console.WriteLine($"{"Tall?", -20} {truck1.IsTall, 15} {truck2.IsTall, 15}");
            Console.WriteLine($"{"Number Of Seats", -20} {truck1.NumberOfSeats, 15} {truck2.NumberOfSeats, 15}");
            Console.WriteLine($"{"Number of Doors", -20} {truck1.NumberOfDoors, 15} {truck2.NumberOfDoors, 15}");
            Console.WriteLine($"{"Electric?", -20} {truck1.IsElectric, 15} {truck2.IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -20} {truck1.PriceRange, 15} {truck2.PriceRange, 15}");
        }
    }
}