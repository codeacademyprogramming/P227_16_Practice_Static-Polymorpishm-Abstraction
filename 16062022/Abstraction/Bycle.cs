using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Bycle : Vehicle, IDrivable
    {
        //public override void Drive(double km)
        //{
        //    Millage += km;
        //}
        public void Drive(double km)
        {
            Millage += km;   
        }
    }
}
