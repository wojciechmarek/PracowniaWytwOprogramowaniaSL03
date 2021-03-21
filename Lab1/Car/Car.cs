using System;
using Car.Enums;

namespace Car
{
    public class Car
    {
        public Color Color { get; }
        public string Brand { get; }
        public float FuelConsumption { get; }
        public int TankCapacity { get; }

        public Car(Color color, string brand, float fuelConsumption, int tankCapacity)
        {
            Color = color;
            Brand = brand;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
    }
}