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
    }
}