using System;
using Car.Enums;
using FluentAssertions;
using Xunit;
using Xunit.Sdk;

namespace CarTests
{
    public class CarTests
    {
        [Fact]
        public void Car_ShouldCreate_NotNullObject()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);
            car.Should().NotBeNull();
        }

        [Fact]
        public void Property_ShouldReturnValueProvidedInTheCtor_CorrectValues()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);

            var carColor = car.Color;
            var carBrand = car.Brand;
            var carFuelConsumption = car.FuelConsumption;
            var carTankCapacity = car.TankCapacity;

            carColor.Should().Be(Color.Black);
            carBrand.Should().Be("Ford");
            carFuelConsumption.Should().Be(5.7f);
            carTankCapacity.Should().Be(40);
        }
        
        [Fact]
        public void Property_ShouldReturnCarInfoProperties_CurrentValues()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);

            var carFuelLevel = car.FuelLevel;
            var odometer = car.Odometer;
            var dailyOdometer = car.DailyOdometer;

            carFuelLevel.Should().Be(0);
            odometer.Should().Be(0);
            dailyOdometer.Should().Be(0);
        }
        
        
        public void Refuel_ShouldAddToCurrentFuelAmountProvidedFuelAmount_CurrentValue()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);

            car.Refuel(14.0f);

            car.FuelLevel.Should().Be(14);
        }
        
        [Fact]
        public void Drive_ShouldIncreaseOdometerAndCalculateFuelNeededToDrive_ExceptionIfFuelIsNotEnought()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);
            
            car.Refuel(14.0f);
            car.Drive(100);

            car.Odometer.Should().Be(100);
        }
        
        [Fact]
        public void Drive_ShouldResetDailyOdometer_Zero()
        {
            var car = new Car.Car(Color.Black, "Ford", 5.7f, 40);
            
            car.Refuel(10);
            car.Drive(10);
            car.Drive(20);
            car.ResetDailyOdometer();

            car.DailyOdometer.Should().Be(0);
        }
    }
    
    
}