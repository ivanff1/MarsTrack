namespace MarsTrack_Display_Sim
{
    partial class Display_Sim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainUC = new MarsTrack_Display_Sim.MainUC();
            this.SuspendLayout();
            // 
            // mainUC
            // 
            this.mainUC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUC.Location = new System.Drawing.Point(0, 0);
            this.mainUC.Name = "mainUC";
            this.mainUC.Size = new System.Drawing.Size(800, 450);
            this.mainUC.TabIndex = 0;
            // 
            // Display_Sim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainUC);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display_Sim";
            this.Text = "Display Sim";
            this.ResumeLayout(false);

        }

        #endregion

        private MainUC mainUC;
    }
}

