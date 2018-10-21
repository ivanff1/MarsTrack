namespace Test_Data_Gatherer
{
    partial class Form1
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
            this.gatherBtn = new System.Windows.Forms.Button();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.commPortBox = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.isConnectedLabel = new System.Windows.Forms.Label();
            this.stopGathering = new System.Windows.Forms.Button();
            this.dataTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gatherBtn
            // 
            this.gatherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gatherBtn.Location = new System.Drawing.Point(584, 294);
            this.gatherBtn.Name = "gatherBtn";
            this.gatherBtn.Size = new System.Drawing.Size(204, 68);
            this.gatherBtn.TabIndex = 0;
            this.gatherBtn.Text = "Gather";
            this.gatherBtn.UseVisualStyleBackColor = true;
            this.gatherBtn.Click += new System.EventHandler(this.GatherBtn_Click);
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comPortLabel.Location = new System.Drawing.Point(12, 22);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(242, 29);
            this.comPortLabel.TabIndex = 1;
            this.comPortLabel.Text = "Communication Port: ";
            // 
            // commPortBox
            // 
            this.commPortBox.DisplayMember = "(none)";
            this.commPortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commPortBox.FormattingEnabled = true;
            this.commPortBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.commPortBox.Location = new System.Drawing.Point(260, 19);
            this.commPortBox.Name = "commPortBox";
            this.commPortBox.Size = new System.Drawing.Size(171, 37);
            this.commPortBox.TabIndex = 2;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTextBox.Location = new System.Drawing.Point(13, 87);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(565, 351);
            this.dataTextBox.TabIndex = 3;
            this.dataTextBox.Text = "";
            // 
            // isConnectedLabel
            // 
            this.isConnectedLabel.AutoSize = true;
            this.isConnectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isConnectedLabel.ForeColor = System.Drawing.Color.Lime;
            this.isConnectedLabel.Location = new System.Drawing.Point(604, 22);
            this.isConnectedLabel.Name = "isConnectedLabel";
            this.isConnectedLabel.Size = new System.Drawing.Size(0, 24);
            this.isConnectedLabel.TabIndex = 4;
            // 
            // stopGathering
            // 
            this.stopGathering.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopGathering.Location = new System.Drawing.Point(584, 370);
            this.stopGathering.Name = "stopGathering";
            this.stopGathering.Size = new System.Drawing.Size(204, 68);
            this.stopGathering.TabIndex = 5;
            this.stopGathering.Text = "Stop";
            this.stopGathering.UseVisualStyleBackColor = true;
            this.stopGathering.Click += new System.EventHandler(this.StopGathering_Click);
            // 
            // dataTypeBox
            // 
            this.dataTypeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Temperature",
            "Humidity",
            "Soil Moisture"});
            this.dataTypeBox.DisplayMember = "(none)";
            this.dataTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTypeBox.FormattingEnabled = true;
            this.dataTypeBox.Items.AddRange(new object[] {
            "Temperature",
            "Humidity",
            "Soil Moisture"});
            this.dataTypeBox.Location = new System.Drawing.Point(584, 114);
            this.dataTypeBox.Name = "dataTypeBox";
            this.dataTypeBox.Size = new System.Drawing.Size(204, 37);
            this.dataTypeBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(580, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Type: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTypeBox);
            this.Controls.Add(this.stopGathering);
            this.Controls.Add(this.isConnectedLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.commPortBox);
            this.Controls.Add(this.comPortLabel);
            this.Controls.Add(this.gatherBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Data Gatherer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gatherBtn;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.ComboBox commPortBox;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.Label isConnectedLabel;
        private System.Windows.Forms.Button stopGathering;
        private System.Windows.Forms.ComboBox dataTypeBox;
        private System.Windows.Forms.Label label1;
    }
}

