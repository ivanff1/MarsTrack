using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Test_Data_Gatherer
{
    public partial class Form1 : Form
    {
        static SerialPort commPort;
        static bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
            commPortBox.DropDownStyle = ComboBoxStyle.DropDownList;
            commPortBox.SelectedIndex = 0; 
            dataTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataTypeBox.SelectedIndex = 0;
        }

        private void GatherBtn_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                isConnectedLabel.Text = "Connected";
                isConnectedLabel.ForeColor = Color.Lime;

                commPort = new SerialPort(commPortBox.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                commPort.Open();

                isConnected = true;

                dataTextBox.Clear();
                currentBox.Clear();

                if (dataTypeBox.SelectedItem.ToString().ToLower().Equals("temperature"))
                {
                    Thread startDataGathering = new Thread(new ThreadStart(GetTempData));
                    startDataGathering.Start();
                }
                else if (dataTypeBox.SelectedItem.ToString().ToLower().Equals("humidity"))
                {
                    Thread startDataGathering = new Thread(new ThreadStart(GetHumidData));
                    startDataGathering.Start();
                }
                else if (dataTypeBox.SelectedItem.ToString().ToLower().Equals("soil moisture"))
                {
                    Thread startDataGathering = new Thread(new ThreadStart(GetSoilMoistData));
                    startDataGathering.Start();
                }
                else
                {
                    Thread startDataGathering = new Thread(new ThreadStart(GetRangeData));
                    startDataGathering.Start();
                }                
            }
            else
            {
            }           
        }
        private void GetRangeData()
        {
            while (isConnected == true)
            {
                commPort.Write("RANGEF");
                string rangeData = commPort.ReadLine();
                dataTextBox.Text += rangeData;
                currentBox.Text = rangeData;
            }
        }
        private void GetTempData()
        {
            try
            {
                string regDate = DateTime.Now.ToString("t");
                string legalDate = regDate.Replace(':', '-');
                while (isConnected == true)
                {                    
                    commPort.Write("TEMPD");
                    string tempData = commPort.ReadLine();
                    File.AppendAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Gathered Data\TempData(" + legalDate + ").txt", "<[" + DateTime.Now.ToString() + "]>" + tempData + Environment.NewLine);
                    dataTextBox.Text += tempData;
                    currentBox.Text = tempData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetHumidData()
        {
            try
            {
                string regDate = DateTime.Now.ToString("t");
                string legalDate = regDate.Replace(':', '-');
                while (isConnected == true)
                {
                    commPort.Write("HUMID");
                    string humidData = commPort.ReadLine();
                    File.AppendAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Gathered Data\HumidData(" + legalDate + ").txt", "<[" + DateTime.Now.ToString() + "]>" + humidData + Environment.NewLine);
                    dataTextBox.Text += humidData;
                    currentBox.Text = humidData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetSoilMoistData()
        {
            try
            {
                string regDate = DateTime.Now.ToString("t");
                string legalDate = regDate.Replace(':', '-');
                while (isConnected == true)
                {
                    commPort.Write("SOILM");
                    string soilMoist = commPort.ReadLine();
                    File.AppendAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Gathered Data\SoilMoistData(" + legalDate + ").txt", "<[" + DateTime.Now.ToString() + "]>" + soilMoist + Environment.NewLine);
                    dataTextBox.Text += soilMoist;
                    currentBox.Text = soilMoist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopGathering_Click(object sender, EventArgs e)
        {
            commPort.Close();
            isConnectedLabel.Text = "Not Connected";
            isConnectedLabel.ForeColor = Color.Red;
            isConnected = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
