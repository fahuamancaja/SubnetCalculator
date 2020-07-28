using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubnetCalculator
{
    public class IPAddressFormat
    {
        public byte FirstOctet { get; set; }
        public byte SecondOctet { get; set; }
        public byte ThirdOctet { get; set; }
        public byte FourthOctet { get; set; }

        public IPAddressFormat()
        {
        }
    }
}
