using System;
using Car.Enums;
using FluentAssertions;
using Xunit;

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
    }
}