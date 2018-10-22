using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarsTrack_Sim
{
    public partial class MarsTrackSim : Form
    {
        public MarsTrackSim()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;            
            MainUC mainUC = new MainUC();
            mainUC.Dock = DockStyle.Fill;
            this.Controls.Add(mainUC);
            
        }
       
    }
}
