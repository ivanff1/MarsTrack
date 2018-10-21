using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarsTrack_Sim
{
   
    public partial class MainUC : UserControl 
    {
        //string cachedTempValue = GlobalVariables.temperature;
        //string cachedHumValue = GlobalVariables.humidity;
        public static bool isConnected = false;
        public static string userName = "Ivan Zlatanov";
        public static string userId = "00001";
        public MainUC()
        {
            InitializeComponent();
           // SetData();
            userNaneLabel.Text = userName;
            userIdLabel.Text = userId;
            batteryLabel.Text = "Battery: 65%";
            humidLabel.Text = "Humidity: 44%";
            tempLabel.Text = "Temperature: 25°C";
        }
        static void SetData()
        {
            
            SerialPort commPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            if (isConnected == false)
            {
                isConnected = true;
                commPort.Open();
                while (true)
                {
                    commPort.Write("TEMPD");
                    GlobalVariables.temperature = commPort.ReadLine();
                    commPort.Write("HUMID");
                    GlobalVariables.humidity = commPort.ReadLine();
                }
            }
            else
            {
                commPort.Write("TEMPD");
                GlobalVariables.temperature = commPort.ReadLine();
                commPort.Write("HUMID");
                GlobalVariables.humidity = commPort.ReadLine();
            }
        }
        //don't acces this variable: it's just for storing the value in it

        
        public void MonitorVariable()
        {

        }

        private void batteryLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }


