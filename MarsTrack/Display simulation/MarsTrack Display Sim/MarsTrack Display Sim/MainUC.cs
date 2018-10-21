using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarsTrack_Display_Sim
{
    public partial class MainUC : UserControl
    {
        static SerialPort connectionPort = new SerialPort("COM4", 9600, Parity.None, 0, StopBits.One);
        static bool isConnected = false;
        public MainUC()
        {
            
            InitializeComponent();
        }

        public void GetSensorsData()
        {
            if (isConnected == false)
            {
                try
                {
                    connectionPort.Open();
                    connectionPort.Write("TEMPD");
                    string tempData = connectionPort.ReadLine();
                    //   connectionPort.Write("HUMID");                
                    // string humidData = connectionPort.ReadLine();
                    textBox1.Text = tempData;
                    //   return new string[]{tempData, humidData };
                    File.AppendAllText(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\TempData().txt", "<[]>" + tempData + Environment.NewLine);
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                connectionPort.Write("TEMPD");
                string tempData = connectionPort.ReadLine();
                // connectionPort.Write("HUMID");
                // string humidData = connectionPort.ReadLine();
                textBox1.Text = tempData;
                //return new string[] { tempData, humidData };
            }

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            GetSensorsData();

        }
    }
}