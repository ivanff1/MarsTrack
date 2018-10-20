using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace MarsTrack_Test_Data_Gatherer
{
    public partial class Gatherer : Form
    {
        static string port = "";
        static SerialPort comPort;
        static bool openConn = false;
        static string dirNameNow = String.Empty;
        public Gatherer()
        {
            InitializeComponent();
            communicationPortsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            port = communicationPortsComboBox.GetItemText(communicationPortsComboBox.SelectedItem);
            //CreatDir();

        }
        public static void CreatDir()
        {
            Directory.CreateDirectory(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\" + DateTime.Now.ToString("MM / dd / yyyy"));
        }
        public static void SetupConnection()
        {
            comPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            comPort.Open();
        }

        private void CommunicationPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //In Prod.
        }

        private void DataGatherBtn_Click(object sender, EventArgs e)
        {
            Thread getDataThr = new Thread(new ThreadStart(GetTempData));
            Thread getHumidThr = new Thread(new ThreadStart(GetHumidData));
            if (openConn is false)
            {
                SetupConnection();
                getDataThr.Start();
                getHumidThr.Start();
                openConn = true;
            }
            else
            {
               getDataThr.Start();
               getHumidThr.Start();
            }
        }

        private void GetTempData()
        {

            try
            {
                string regDate = DateTime.Now.ToString("t");
                string legalDate = regDate.Replace(':', '-');
                TextWriter dateWrite = new StreamWriter(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\TempData" + legalDate + ".txt", true);

                while (true)
                {
                    comPort.Write("TEMPD");
                    string temp = comPort.ReadLine();
                    dateWrite.Write(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\TempData" + legalDate + ".txt", "[" + DateTime.Now.ToString() + "]" + temp + Environment.NewLine);
                    tempBox.Text += temp;//comPort.ReadLine();                    
                }
            }
            catch (Exception exp)
            {
                tempBox.Text = exp.ToString();
            }
        }
        private void GetHumidData()
        {
            string regDate = DateTime.Now.ToString("t");
            string legalDate = regDate.Replace(':', '-');
            
            TextWriter dateWrite = new StreamWriter(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\HumidData" + legalDate + ".txt", true);
            try
            {
                while (true)
                {
                    comPort.Write("HUMID");
                    string humid = comPort.ReadLine();
                    dateWrite.Write(@"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data\HumidData" + legalDate + ".txt", "[" + DateTime.Now.ToString() + "]" + humid + Environment.NewLine);
                    humidBox.Text += humid;//comPort.ReadLine();                    
                }
            }
            catch (Exception exp)
            {
                tempBox.Text = exp.ToString();
            }
        } 
        private void GetSoilMoistData()
        {

        }
        private void GetRange()
        {

        }
    }
}
