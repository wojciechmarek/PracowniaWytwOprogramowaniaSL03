using System;
using System.Data;
using Car.Enums;

namespace Car
{
    public class Car
    {
        public Color Color { get; }
        public string Brand { get; }
        public float FuelConsumption { get; }
        public int TankCapacity { get; }
        

        public float FuelLevel { get; private set; }
        public int Odometer { get; private set; }
        public int DailyOdometer { get; private set; }

        public Car(Color color, string brand, float fuelConsumption, int tankCapacity)
        {
            Color = color;
            Brand = brand;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public void Refuel(float amount)
        {
            if (amount <= 0 || amount > TankCapacity)
            {
                throw new SyntaxErrorException("Wrong fuel amount");
            }

            FuelLevel += amount;

            if (FuelLevel > TankCapacity)
            {
                FuelLevel = TankCapacity;
            }
        }
    }
}