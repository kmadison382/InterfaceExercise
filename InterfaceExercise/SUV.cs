using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string Name {get; set;}
        public string CargoSpace {get; set;}
        public int NumberOfDoors {get; set;}
        public int NumberOfSeats {get; set;}
        public string Color {get; set;}
        public bool IsElectric {get; set;}
        public bool CanOffroad {get; set;}
        public string OriginCountry {get; set;}
        public string PriceRange {get; set;}
        public SUV()
        {
            VehicleMethods.AddVehicle(this);
        }
        
        public void PrintDetails()
        {
            Console.WriteLine($"{"", -17} {Name, 15}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{"Made in", -17} {OriginCountry, 15}");
            Console.WriteLine($"{"Color", -17} {Color, 15}");
            Console.WriteLine($"{"Cargo Space", -17} {CargoSpace, 15}");
            Console.WriteLine($"{"NumberOfSeats", -17} {NumberOfSeats, 15}");
            Console.WriteLine($"{"Number of Doors", -17} {NumberOfDoors, 15}");
            Console.WriteLine($"{"Offroading?", -17} {CanOffroad, 15}");
            Console.WriteLine($"{"Electric?", -17} {IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -17} {PriceRange, 15}");
        }
        public static void PrintDetails(SUV suv1, SUV suv2)
        {
            Console.WriteLine($"{"", -20} {suv1.Name, 15} {suv2.Name, 15}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"{"Made in", -20} {suv1.OriginCountry, 15} {suv2.OriginCountry, 15}");
            Console.WriteLine($"{"Color", -20} {suv1.Color, 15} {suv2.Color, 15}");
            Console.WriteLine($"{"Cargo Space", -20} {suv1.CargoSpace, 15} {suv2.CargoSpace, 15}");
            Console.WriteLine($"{"Number Of Seats", -20} {suv1.NumberOfSeats, 15} {suv2.NumberOfSeats, 15}");
            Console.WriteLine($"{"Number of Doors", -20} {suv1.NumberOfDoors, 15} {suv2.NumberOfDoors, 15}");
            Console.WriteLine($"{"Offroading?", -20} {suv1.CanOffroad, 15} {suv2.CanOffroad, 15}");
            Console.WriteLine($"{"Electric?", -20} {suv1.IsElectric, 15} {suv2.IsElectric, 15}");
            Console.WriteLine($"{"Price Range", -20} {suv1.PriceRange, 15} {suv2.PriceRange, 15}");
        }
    }
}