﻿//DO NOT MODIFY THIS FILE!
using System;
using System.Drawing;

namespace BuilderLab
{
    public class Vehicle : IEquatable<Vehicle>
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
        public Color BodyColor { get; set; } = Color.Empty;
        public bool? HasRadio { get; set; } = null;
        public bool? HasBluetooth { get; set; } = null;
        public bool? HasMudFlaps { get; set; } = null;
        public bool? HasTrailer { get; set; } = null;

        public bool Equals(Vehicle? other)
        {
            return other != null && this.Engine == other.Engine && this.Transmission == other.Transmission && this.NumberOfDoors == other.NumberOfDoors &&
                this.NumberOfWheels == other.NumberOfWheels && this.VehicleFuelType == other.VehicleFuelType && this.SeatMat == other.SeatMat &&
                this.NumberOfSeats == other.NumberOfSeats && this.BodyColor.Equals(other.BodyColor) && this.HasRadio == other.HasRadio &&
                this.HasBluetooth == other.HasBluetooth && this.HasMudFlaps == other.HasMudFlaps && this.HasTrailer == other.HasTrailer;
        }
    }
}
