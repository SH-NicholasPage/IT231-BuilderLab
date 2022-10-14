using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace BuilderLab
{
    public class Program
    {
        private const int MAX_SCORE = 20;
        private static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public static void Main()
        {
            ConstructVehicles();
        }
        private static void ConstructVehicles()
        {
            // Returns a car with a V4 engine, manual transmission, 4 wheels, 4 doors, 5 leather seats, white body, and uses gasoline.
            Vehicles.Add(new Vehicle() 
            { 
                Engine = Vehicle.EngineType.V4,
                Transmission = Vehicle.TransmissionType.Manual,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                SeatMat = Vehicle.SeatMaterial.Leather,
                BodyColor = Color.White,
                VehicleFuelType = Vehicle.FuelType.Gasoline
            });
            // Returns a car with a V8 engine, automatic transmission, 7 vinyl seats, 4 wheels, 6 doors, blue body, uses gasoline, has a radio, and has Bluetooth.
            Vehicles.Add(new Vehicle()
            {
                Engine = Vehicle.EngineType.V8,
                Transmission = Vehicle.TransmissionType.Automatic,
                NumberOfWheels = 4,
                NumberOfDoors = 6,
                NumberOfSeats = 7,
                SeatMat = Vehicle.SeatMaterial.Vinyl,
                BodyColor = Color.Blue,
                VehicleFuelType = Vehicle.FuelType.Gasoline,
                HasRadio = true,
                HasBluetooth = true
            });
            // Returns a car with a specified transmission type, two doors, four wheels, two nylon seats, white body, has a radio, and uses electric fuel.
            Vehicles.Add(new Vehicle()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                NumberOfSeats = 2,
                SeatMat = Vehicle.SeatMaterial.Nylon,
                BodyColor = Color.White,
                VehicleFuelType = Vehicle.FuelType.Electric,
                HasRadio = true,
                HasBluetooth = true
            });
            // Returns a car with an automatic transmission, X doors, Y wheels, Z nylon seats, white body, has a radio, and uses electric fuel.
            Vehicles.Add(new Vehicle()
            {
                Transmission = Vehicle.TransmissionType.Automatic,
                SeatMat = Vehicle.SeatMaterial.Nylon,
                BodyColor = Color.White,
                VehicleFuelType = Vehicle.FuelType.Electric,
                HasRadio = true
            });
            // Returns a motorcycle with a V2 engine, manual transmission, 2 wheels, a leather seat, black body, has a radio, and uses gasoline.
            Vehicles.Add(new Vehicle()
            {
                Engine = Vehicle.EngineType.V2,
                Transmission = Vehicle.TransmissionType.Manual,
                NumberOfWheels = 2,
                NumberOfSeats = 1,
                SeatMat = Vehicle.SeatMaterial.Leather,
                BodyColor = Color.Black,
                VehicleFuelType = Vehicle.FuelType.Gasoline,
                HasRadio = true
            });
            // Returns a scooter with 2 wheels, a vinyl seat, a yellow body, uses electric fuel, has a radio, and has bluetooth
            Vehicles.Add(new Vehicle()
            {
                NumberOfWheels = 2,
                NumberOfSeats = 1,
                SeatMat = Vehicle.SeatMaterial.Vinyl,
                BodyColor = Color.Yellow,
                VehicleFuelType = Vehicle.FuelType.Electric,
                HasRadio = true,
                HasBluetooth = true
            });
            // Returns a truck with a V16 engine, manual transmission, 2 doors, 16 wheels, diesel fuel, 2 nylon seats, red body color, and has a radio, trailer, and bluetooth.
            Vehicles.Add(new Vehicle()
            {
                Engine = Vehicle.EngineType.V16,
                Transmission = Vehicle.TransmissionType.Manual,
                NumberOfDoors = 2,
                NumberOfWheels = 16,
                NumberOfSeats = 2,
                SeatMat = Vehicle.SeatMaterial.Nylon,
                BodyColor = Color.Red,
                VehicleFuelType = Vehicle.FuelType.Diesel,
                HasRadio = true,
                HasBluetooth = true,
                HasTrailer = true
            });
            // Returns a truck with a V18 engine, manual transmission, 4 doors, 18 wheels, diesel fuel, 3 polyester seats, green body color, and has a radio, a trailer, and mudflaps.
            Vehicles.Add(new Vehicle()
            {
                Engine = Vehicle.EngineType.V18,
                Transmission = Vehicle.TransmissionType.Manual,
                NumberOfDoors = 4,
                NumberOfWheels = 18,
                NumberOfSeats = 3,
                SeatMat = Vehicle.SeatMaterial.Polyester,
                BodyColor = Color.Green,
                VehicleFuelType = Vehicle.FuelType.Diesel,
                HasRadio = true,
                HasMudFlaps = true,
                HasTrailer = true
            });
            // Returns a truck with an automatic transmission, 2 doors, 12 wheels, electric fuel, 3 leather seats, white body color, and has a radio and bluetooth
            Vehicles.Add(new Vehicle()
            {
                Transmission = Vehicle.TransmissionType.Automatic,
                NumberOfDoors = 2,
                NumberOfWheels = 12,
                NumberOfSeats = 3,
                SeatMat = Vehicle.SeatMaterial.Leather,
                BodyColor = Color.White,
                VehicleFuelType = Vehicle.FuelType.Electric,
                HasRadio = true,
                HasBluetooth = true
            });
            // Returns a golf cart with given arguments
            Vehicles.Add(new Vehicle());

            JsonSerializerOptions options = new JsonSerializerOptions
            { 
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };

            String text = JsonSerializer.Serialize(Vehicles, options);
            File.WriteAllText("inputs.json", text);
        }

        private static int RunTests()
        {
            int score = MAX_SCORE;



            return score;
        }
    }
}