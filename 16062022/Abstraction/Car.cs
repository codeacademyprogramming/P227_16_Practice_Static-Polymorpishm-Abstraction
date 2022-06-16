using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Car : Vehicle,IDrivable
    {
        public Car()
        {
            TotalCount++;
        }
        public static int TotalCount;
        public double CurrentFuel;
        public double FuelFor1km;

        public void Drive(double km)
        {
            CurrentFuel -= km * FuelFor1km;
            Millage += km;
        }

        //public override void Drive(double km)
        //{
        //    CurrentFuel -= km * FuelFor1km;
        //    Millage += km;
        //}

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand/Model: {Brand} - {Model}; CurrentFuel: {CurrentFuel}; Millage: {Millage}");
        }
    }
}
