using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars_Track_Display_Simulation
{
    public partial class MainPanelUC : UserControl
    {
        public static string firstName = "Ivan";
        public static string secondName = "Zlatanov"; 
        static SerialPort mainCommPort = new SerialPort("COM4", 9600, Parity.None, 0, StopBits.One);
        public MainPanelUC()
        {
            InitializeComponent();
           
            firstNameLabel.Text = "FIRST NAME: " + firstName;
            secondNameLabel.Text = "SECOND NAME: " + secondName;
            
        }

         void SetUp()
        {
                GetSensorsData();                        
        }
         void   GetSensorsData()
        {

                tempLabel.Text = "Temperature: " + GetData.GetTemperatureData(mainCommPort) + "°C";
                humidLabel.Text = "Humidity: ";// + GetData.GetTemperatureData(mainCommPort) + "%"; ;               

        }
    }
}
