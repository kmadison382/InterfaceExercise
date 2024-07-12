using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class ListMethods
    {
        public static IVehicle GetVehicle(List<IVehicle> Vehicles, int i)
        {
            return Vehicles[i];
        }
        public void ListAll(List<IVehicle> Vehicles)
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"{i + 1} - {Vehicles[i]}");
                }
                else
                {
                    Console.Write($"{i + 1} - {Vehicles[i]} || ");
                }
            }
        }
        
    }
}