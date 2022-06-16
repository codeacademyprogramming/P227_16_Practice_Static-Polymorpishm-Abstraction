using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen ctz1 = new Citizen();
            Citizen ctz2 = new Citizen();
            Citizen ctz3 = new Citizen();
            Citizen ctz4 = new Citizen();

            Console.WriteLine(ctz1.SerialNo);
            Console.WriteLine(ctz2.SerialNo);
            Console.WriteLine(ctz3.SerialNo);
        }
    }
}
