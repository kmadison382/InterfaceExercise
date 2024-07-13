using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Name {get; set;}
        public int NumberOfDoors {get; set;}
        public int NumberOfSeats {get; set;}
        public string Color {get; set;}
        public bool IsElectric {get; set;}
        private static List<IVehicle> Vehicles {get; set;}
    }
}