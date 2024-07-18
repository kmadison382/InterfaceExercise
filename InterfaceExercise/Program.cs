using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            Car car1 = new Car() {Name = "Ford Focus", MilesPerGallon = 32, SeatMaterial = "Leather", NumberOfSeats = 5, NumberOfDoors = 4, Color = "Red", IsElectric = false, OriginCountry  = "USA", PriceRange = "$"};
            Car car2 = new Car() {Name = "Corvette", MilesPerGallon = 20, SeatMaterial = "Leather", NumberOfSeats = 2, NumberOfDoors = 2, Color = "Black", IsElectric = false, OriginCountry  = "USA", PriceRange = "$$$"};

            SUV suv1 = new SUV() {Name = "Toyota 4Runner", CargoSpace = "High", NumberOfDoors = 4, NumberOfSeats = 5, Color = "Yellow", IsElectric = false, CanOffroad = true, OriginCountry = "Japan", PriceRange = "$$"};
            SUV suv2 = new SUV() {Name = "Chevy Equinox", CargoSpace = "Medium", NumberOfDoors = 4, NumberOfSeats = 5, Color = "Blue", IsElectric = false, CanOffroad = false, OriginCountry = "USA", PriceRange = "$"};

            Truck truck1 = new Truck() {Name = "GMC Sierra", IsTall = true, NumberOfDoors = 4, NumberOfSeats = 5, Color = "White", IsElectric = true, TowingCapacity = "10,000 lbs", OriginCountry = "USA", PriceRange = "$$$"};
            Truck truck2 = new Truck() {Name = "Nissan Frontier", IsTall = false, NumberOfDoors = 4, NumberOfSeats = 5, Color = "Green", IsElectric = false, TowingCapacity = "6,000 lbs", OriginCountry = "Japan", PriceRange = "$"};

            var programRunning = true;
            Console.Clear();
            Console.WriteLine("Welcome to the vehicle registry.");
            while (programRunning == true)
            {
                Console.WriteLine("How can I help you?");
                Console.WriteLine("1 - Register new vehicle | 2 - Look up vehicle | 3 - Compare vehicles | 4 - Exit registry");
                _ = int.TryParse(Console.ReadLine(), out int userInput);
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            VehicleMethods.NewVehicle();
                            break;
                        case 2:
                            Console.Clear();
                            VehicleMethods.SearchVehicles();
                            break;
                        case 3:
                            Console.Clear();
                            VehicleMethods.CompareVehicles();
                            break;
                        case 4:
                            Console.WriteLine("Okay, goodbye!");
                            programRunning = false;
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                        Console.WriteLine($"Sorry, I don't recognize that. Press enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        
        }
    }
}
