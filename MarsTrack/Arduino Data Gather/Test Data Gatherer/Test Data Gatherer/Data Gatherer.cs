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

                }                
            }
            else
            {
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
                    File.AppendAllText(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\TempData(" + legalDate + ").txt", tempData + Environment.NewLine);
                    dataTextBox.Text += tempData + "°C" + Environment.NewLine;  
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
                    File.AppendAllText(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\HumidData(" + legalDate + ").txt",  humidData + Environment.NewLine);
                    dataTextBox.Text += humidData + "%" + Environment.NewLine;
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
                    File.AppendAllText(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\SoilMoistData(" + legalDate + ").txt",   soilMoist + Environment.NewLine);
                    dataTextBox.Text += soilMoist +  "%" + Environment.NewLine; 
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

        private void averageBtn_Click(object sender, EventArgs e)
        {
            double cTemp = 0;
                double aTemp = 0;
            string path = "";
            OpenFileDialog openFDialog = new OpenFileDialog();
            if (openFDialog.ShowDialog() == DialogResult.OK)
            {
                 path = openFDialog.FileName;
                MessageBox.Show(path);
            }
            string[] fileLines = File.ReadAllLines(path);
            foreach(string line in fileLines)
            {
                cTemp += Double.Parse(line);
            }
            aTemp = cTemp / fileLines.Count();
            MessageBox.Show(aTemp.ToString());
        }
    }
}
