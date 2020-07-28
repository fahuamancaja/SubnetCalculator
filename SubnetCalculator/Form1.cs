using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
       
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bitDecimal = new List<byte> { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

            for(int i = 0; i <256; i++)
            {
                comboBox1.Items.Add(i.ToString());
                comboBox2.Items.Add(i.ToString());
                comboBox3.Items.Add(i.ToString());
                comboBox4.Items.Add(i.ToString());
            }

            for (int i = 0; i < 32; i++)
            {
                comboBoxCIDR.Items.Add(i.ToString());
            }

        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            var subnetMaskCalculator = new StartCalculation(new SubnetMaskCalculator());

            var firstOctet = Convert.ToInt32(comboBox1.Text);
            var secondOctet = Convert.ToInt32(comboBox2.Text);
            var thirdOctet = Convert.ToInt32(comboBox3.Text);
            var fourthOctet = Convert.ToInt32(comboBox4.Text);
            var cidr = Convert.ToInt32(comboBoxCIDR.Text);

            var finalIP = subnetMaskCalculator.Calculation(firstOctet, secondOctet, thirdOctet, fourthOctet, cidr);

            var strFirstIP = Convert.ToString(finalIP.FirstOctet);
            var strSecondIP = Convert.ToString(finalIP.SecondOctet);
            var strThirdIP = Convert.ToString(finalIP.ThirdOctet);
            var strFourthIP = Convert.ToString(finalIP.FourthOctet);

            lbFinalIP.Text = strFirstIP + "." + strSecondIP + "." + strThirdIP + "." + strFourthIP;
        }

        private void btCalculate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

        private void comboBoxCIDR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btCalculate_Click(sender, e);
            }
        }

    }

    public class StartCalculation
    {
        private readonly ICalcuator _subnetMaskCalculator;
        public StartCalculation(ICalcuator subnetMaskCalculator)
        {
            _subnetMaskCalculator = subnetMaskCalculator;
        }

        public IPAddressFormat Calculation(int a, int b, int c, int d, int cidr)
        {
            var initialIP = new IPAddressFormat() { FirstOctet = (byte)a, SecondOctet = (byte)b, ThirdOctet = (byte)c, FourthOctet = (byte)d };
            var value = _subnetMaskCalculator.GetSubnet(initialIP, cidr);
            return value;
        }
    }
}
