using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Citizen
    {
        public Citizen()
        {
            _serialNo = "AZE" + _no;
            _no++;
        }
        public string Name;
        public string Surname;
        private string _serialNo;
        public string SerialNo { get => _serialNo; }
        private static int _no = 1000;
    }
}
