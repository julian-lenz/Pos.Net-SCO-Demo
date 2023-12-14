using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.PointOfService;

namespace PosDemo
{
    public partial class PosDemo : Form
    {
        private PosExplorer explorer = new PosExplorer();
        private Lights light;
        private LightColors CurrentlightColor = LightColors.Primary;
        private bool power = false;
        private PosPrinter printer;


        public PosDemo()
        {
            InitializeComponent();
            try
            {
                light = (Lights)explorer.CreateInstance(explorer.GetDevice("Lights", "Light"));
                printer = (PosPrinter)explorer.CreateInstance(explorer.GetDevice("PosPrinter", "PrinterPos"));
                
                light.Open();
                light.Claim(1000);
                light.DeviceEnabled = true;

                printer.Open();
                printer.Claim(1000);
                printer.DeviceEnabled = true;

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
           if (power == false)
            {
                power = true;
                powerButton.Text = "Turn light off";
                light.SwitchOn(1, 0, 0, CurrentlightColor, LightAlarms.None);
            }
            else
            {
                power = false;
                powerButton.Text = "Turn light on";
                light.SwitchOff(1);
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
            CurrentlightColor = LightColors.Custom1;
            if (power) light.SwitchOn(1, 0, 0, CurrentlightColor, LightAlarms.None);
        }

        private void color2_Click(object sender, EventArgs e)
        {
            CurrentlightColor = LightColors.Primary;
            if (power) light.SwitchOn(1, 0, 0, CurrentlightColor, LightAlarms.None);
        }

        private void color3_Click(object sender, EventArgs e)
        {
            CurrentlightColor = LightColors.Custom5;
            if (power) light.SwitchOn(1, 0, 0, CurrentlightColor, LightAlarms.None);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 
        ~PosDemo()
        {
            light.DeviceEnabled = false;
            light.Release();
            light.Close();
        }
    }
   
}