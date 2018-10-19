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
        public MainPanelUC()
        {
            InitializeComponent();
            firstNameLabel.Text = "FIRST NAME: " + firstName;
            secondNameLabel.Text = "SECOND NAME: " + secondName;
        }
    }
}
