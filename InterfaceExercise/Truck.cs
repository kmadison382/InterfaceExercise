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
        public Truck()
        {
            VehicleMethods.AddVehicle(this);
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{"", -17} {Name, 15}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{"Made in", -17} {OriginCountry, 15}");
            Console.WriteLine($"{"Color", -17} {Color, 15}");
            Console.WriteLine($"{"Towing Capacity", -17} {TowingCapacity, 15}");
            Console.WriteLine($"{"Tall?", -17} {IsTall, 15}");
            Console.WriteLine($"{"NumberOfSeats", -17} {NumberOfSeats, 15}");
            Console.WriteLine($"{"Number of Doors", -17} {NumberOfDoors, 15}");
            Console.WriteLine($"{"Electric?", -17} {IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -17} {PriceRange, 15}");
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