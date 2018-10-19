namespace Mars_Track_Display_Simulation
{
    partial class MarsTrack
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
            this.mainPanelUC = new Mars_Track_Display_Simulation.MainPanelUC();
            this.SuspendLayout();
            // 
            // mainPanelUC
            // 
            this.mainPanelUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanelUC.AutoSize = true;
            this.mainPanelUC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainPanelUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainPanelUC.Location = new System.Drawing.Point(0, 0);
            this.mainPanelUC.Name = "mainPanelUC";
            this.mainPanelUC.Size = new System.Drawing.Size(1265, 697);
            this.mainPanelUC.TabIndex = 0;
            // 
            // MarsTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 697);
            this.Controls.Add(this.mainPanelUC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarsTrack";
            this.Text = "MarsTrack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainPanelUC mainPanelUC;
    }
}

