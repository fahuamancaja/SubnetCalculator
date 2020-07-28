using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubnetCalculator
{
    public interface ICalcuator
    {
        IPAddressFormat GetSubnet(IPAddressFormat ip, int cidr);
    }
    public class SubnetMaskCalculator : ICalcuator
    {


        public IPAddressFormat GetSubnet(IPAddressFormat ip, int cidr)
        {
            var ipAddress = new IPAddressFormat();
            var bitDecimal = new byte[] { 0, 128, 192, 224, 240, 248, 252, 254, 255 };
            if (cidr <= 8)
            {
                var first = bitDecimal[cidr];
                ipAddress = new IPAddressFormat() { FirstOctet = first, SecondOctet = 0, ThirdOctet = 0, FourthOctet = 0 };
            }
            else if (cidr > 8 && cidr <= 16)
            {
                cidr = cidr - 8;
                var second = bitDecimal[cidr];
                ipAddress = new IPAddressFormat() { FirstOctet = 255, SecondOctet = second, ThirdOctet = 0, FourthOctet = 0 };
            }
            else if (cidr > 16 && cidr <= 24)
            {
                cidr = cidr - 16;
                var third = bitDecimal[cidr];
                ipAddress = new IPAddressFormat() { FirstOctet = 255, SecondOctet = 255, ThirdOctet = third, FourthOctet = 0 };
            }
            else if (cidr > 24 && cidr <= 32)
            {
                cidr = cidr - 24;
                var fourth = bitDecimal[cidr];
                ipAddress = new IPAddressFormat() { FirstOctet = 255, SecondOctet = 255, ThirdOctet = 255, FourthOctet = fourth };
            }
            else
            {
                ipAddress = new IPAddressFormat() { FirstOctet = 0, SecondOctet = 0, ThirdOctet = 0, FourthOctet = 0 };
            }

            var sub = new IPAddressFormat() { FirstOctet = (byte)(ipAddress.FirstOctet & ip.FirstOctet), 
                SecondOctet = (byte)(ipAddress.SecondOctet & ip.SecondOctet), 
                ThirdOctet = (byte)(ipAddress.ThirdOctet & ip.ThirdOctet), 
                FourthOctet = (byte)(ipAddress.FourthOctet & ip.FourthOctet) };
            return sub;
        }

    }
}
