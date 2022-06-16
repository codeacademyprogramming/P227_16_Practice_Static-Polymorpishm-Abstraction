using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public double Millage;


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage}");
        }
    }
}
