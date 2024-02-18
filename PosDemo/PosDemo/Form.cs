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
using LedSerialControl;
using System.Threading;

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

            }
            catch (Exception e)
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

        private void doBlink(int period)
        {
            light.SwitchOn(1, period, period, CurrentlightColor, LightAlarms.None);
        }

        private void blinkButton1_Click(object sender, EventArgs e)
        {
            if (power)
            {
                doBlink(1000);
            }
        }

        private void staticButton_Click(object sender, EventArgs e)
        {
            if (power)
            {
                doBlink(0);
            }
        }

        private void blinkButton2_Click(object sender, EventArgs e)
        {
            if (power)
            {
                doBlink(200);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Text changed:" + printerText.Text);

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printButton.Enabled = false;
            if(printerText.Text.Length == 0)
            {
                Console.WriteLine("Text to print is empty. Please type in a text and try again!");
                return;
            }
            if (printer.JrnCartridgeState != PrinterCartridgeStates.OK)
            {
                throw new Exception("Printer Cartridge is not ready... State:" + printer.JrnCartridgeState.ToString());
            }
            Console.WriteLine("Starting to print...");
            string text = printerText.Text;
            string currentDateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string receiptString = "======================\n" +
                                   currentDateTime + "\n" +
                                   "Text:\n" +
                                   text + "\n" +
                                   "======================\n";
            printer.PrintNormal(PrinterStation.Journal, receiptString);
            if(printer.CapRecPaperCut) printer.CutPaper(70); // perforate paper for final separation
            Console.WriteLine("Printing complete.");
            printButton.Enabled = true;
        }
        ~PosDemo()
        {
            light.DeviceEnabled = false;
            light.Release();
            light.Close();

            printer.DeviceEnabled = false;
            printer.Release();
            printer.Close();
        }

        private void PosDemo_Load(object sender, EventArgs e)
        {

        }
    }
}