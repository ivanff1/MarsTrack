using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars_Track_Display_Simulation
{
    public partial class MainPanelUC : UserControl
    {
        public static string firstName = "Ivan";
        public static string secondName = "Zlatanov";
        public static string temperature = "Temperature: "+"-22" + "°C";
        public static string humidity = "Humidity: " + "44" + "%";

        public MainPanelUC()
        {
            InitializeComponent();
            humidLabel.Text = humidity;
            tempLabel.Text = temperature;
            firstNameLabel.Text = "FIRST NAME: " + firstName;
            secondNameLabel.Text = "SECOND NAME: " + secondName;
        }
    }
}
