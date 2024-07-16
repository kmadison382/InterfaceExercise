using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class VehicleMethods
    {
        private static List<IVehicle> Vehicles = new List<IVehicle> {};
        public static void AddVehicle(IVehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public static void ListAll()
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    Console.WriteLine($"| {i + 1} - {Vehicles[i].Name} |");
                }
                else
                {
                    Console.Write($"| {i + 1} - {Vehicles[i].Name} |");
                }
            }
            Console.WriteLine();
        }
        public static void ListAll<T>() where T : IVehicle
        {
            int i = 1;
            foreach (IVehicle vehicle in Vehicles.OfType<T>())
            {
                if (i % 4 == 0 && i != 0)
                {
                    Console.WriteLine($"| {i} - {vehicle.Name} |");
                }
                else
                {
                    Console.Write($"| {i} - {vehicle.Name} |");
                }
                i++;
            }
            Console.WriteLine();
        }
        public static void SearchVehicles()
        {
            bool validInput = false;
            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("What would you like to look up?");
                Console.Write("1 - Cars || ");
                Console.Write("2 - SUVs || ");
                Console.Write("3 - Trucks || ");
                Console.Write("4 - All || ");
                Console.WriteLine("5 - Back to main menu");
                _ = int.TryParse(Console.ReadLine(), out int userInput);
                int vehicleNumber;
                IVehicle userChoice;
                switch (userInput)
                {
                    case 1:
                        ListAll<Car>();
                        Console.WriteLine("Which would you like to look at?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        userChoice = Vehicles.OfType<Car>().ElementAtOrDefault(vehicleNumber - 1);
                        if (userChoice != null)
                        {
                            userChoice.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I don't have a record of that vehicle.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 2:
                        ListAll<SUV>();
                        Console.WriteLine("Which would you like to look at?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        userChoice = Vehicles.OfType<SUV>().ElementAtOrDefault(vehicleNumber - 1);
                        if (userChoice != null)
                        {
                            userChoice.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I don't have a record of that vehicle.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 3:
                        ListAll<Truck>();
                        Console.WriteLine("Which would you like to look at?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        userChoice = Vehicles.OfType<Truck>().ElementAtOrDefault(vehicleNumber - 1);
                        if (userChoice != null)
                        {
                            userChoice.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I don't have a record of that vehicle.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 4:
                        ListAll();
                        Console.WriteLine("Which would you like to look at?");
                        if (int.TryParse(Console.ReadLine(), out vehicleNumber) && vehicleNumber <= Vehicles.Count)
                        {
                            userChoice = Vehicles[vehicleNumber - 1];
                            userChoice.PrintDetails();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I don't have a record of that vehicle.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 5:
                        Console.Write("Returning to the main menu...");
                        Console.Read();
                        validInput = true;
                        break;
                    default:
                        Console.Write($"Sorry, I don't recognize that. Press enter to try again.");
                        Console.Read();
                        Console.Clear();
                        break;
                }
            }
            Console.Clear();
        }
        public static void NewVehicle()
        {
            IVehicle newVehicle = null;
            bool validInput = false;
            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of vehicle would you like to add?");
                Console.Write("1 - Car || ");
                Console.Write("2 - SUV || ");
                Console.Write("3 - Truck || ");
                Console.WriteLine("4 - Back to main menu");
                _ = int.TryParse(Console.ReadLine(), out int userInput);

                switch (userInput)
                {
                    case 1:
                        newVehicle = new Car();
                        validInput = true;
                        break;
                    case 2:
                        newVehicle = new SUV();
                        validInput = true;
                        break;
                    case 3:
                        newVehicle = new Truck();
                        validInput = true;
                        break;
                    case 4:
                        Console.Write("Returning to the main menu...");
                        Console.Read();
                        validInput = true;
                        break;
                    default:
                        Console.Write($"Sorry, I don't recognize that. Press enter to try again.");
                        Console.Read();
                        Console.Clear();
                        validInput = false;
                        break;
                }
                if (newVehicle != null)
                {
                    Console.Write("Please provide a nickname for this vehicle: ");
                    string vehicleName = Console.ReadLine();
                    newVehicle.Name = vehicleName;
                    Console.WriteLine($"{vehicleName} has been added.");
                    Console.Write("Press enter to return to the main menu.");
                    Console.Read();
                    Console.Clear();
                }
                Console.Clear();
            }
        }
        public static void CompareVehicles()
        {
            bool validInput = false;
            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("What would you like to compare?");
                Console.Write("1 - Cars || ");
                Console.Write("2 - SUVs || ");
                Console.Write("3 - Trucks || ");
                Console.WriteLine("4 - Back to main menu");
                _ = int.TryParse(Console.ReadLine(), out int userInput);
                int vehicleNumber;
                switch (userInput)
                {
                    case 1:
                        ListAll<Car>();
                        Console.WriteLine("Which would you like to look at first?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        Car car1 = Vehicles.OfType<Car>().ElementAtOrDefault(vehicleNumber - 1);
                        Console.WriteLine("Which other would you like to see?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        Car car2 = Vehicles.OfType<Car>().ElementAtOrDefault(vehicleNumber - 1);
                        if (car1 != null && car2 != null)
                        {
                            Car.PrintDetails(car1, car2);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I can't compare that.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 2:
                        ListAll<SUV>();
                        Console.WriteLine("Which would you like to look at first?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        SUV suv1 = Vehicles.OfType<SUV>().ElementAtOrDefault(vehicleNumber - 1);
                        Console.WriteLine("Which other would you like to see?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        SUV suv2 = Vehicles.OfType<SUV>().ElementAtOrDefault(vehicleNumber - 1);
                        if (suv1 != null && suv2 != null)
                        {
                            SUV.PrintDetails(suv1, suv2);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I can't compare that.");
                        }
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 3:
                        ListAll<Truck>();
                        Console.WriteLine("Which would you like to look at first?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        Truck truck1 = Vehicles.OfType<Truck>().ElementAtOrDefault(vehicleNumber - 1);
                        Console.WriteLine("Which other would you like to see?");
                        _ = int.TryParse(Console.ReadLine(), out vehicleNumber);
                        Truck truck2 = Vehicles.OfType<Truck>().ElementAtOrDefault(vehicleNumber - 1);
                        if (truck1 != null && truck2 != null)
                        {
                            Truck.PrintDetails(truck1, truck2);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, I can't compare that.");
                        }
                        Truck.PrintDetails(truck1, truck2);
                        Console.Write("Press enter to return to main menu.");
                        Console.Read();
                        validInput = true;
                        break;
                    case 4:
                        Console.Write("Returning to the main menu...");
                        Console.Read();
                        validInput = true;
                        break;
                    default:
                        Console.Write($"Sorry, I don't recognize that. Press enter to try again.");
                        Console.Read();
                        break;
                }
            }
        }
    }
}