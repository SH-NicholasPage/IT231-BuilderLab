//DO NOT MODIFY THIS FILE!
using System;
using System.Drawing;

namespace BuilderLab
{
    public class Vehicle
    {
        public enum EngineType
        {
            V2, V4, V8, V10, V16, V18, V24
        }

        public enum TransmissionType
        {
            Manual, Automatic
        }

        public enum SeatMaterial
        {
            Leather,
            Vinyl,
            Polyester,
            Nylon
        }

        public enum FuelType
        {
            Gasoline,
            Diesel,
            Electric
        }

        public EngineType? Engine { get; set; } = null;
        public TransmissionType? Transmission { get; set; } = null;
        public int? NumberOfDoors { get; set; } = null;
        public int? NumberOfWheels { get; set; } = null;
        public FuelType? VehicleFuelType { get; set; } = null;
        public SeatMaterial? SeatMat { get; set; } = null;
        public int? NumberOfSeats { get; set; } = null;
        public Color? BodyColor { get; set; } = null;
        public bool? HasRadio { get; set; } = null;
        public bool? HasBluetooth { get; set; } = null;
        public bool? HasMudFlaps { get; set; } = null;
        public bool? HasTrailer { get; set; } = null;
    }
}
