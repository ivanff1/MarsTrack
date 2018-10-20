namespace MarsTrack_Test_Data_Gatherer
{
    partial class Gatherer
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
            this.communicationPortsComboBox = new System.Windows.Forms.ComboBox();
            this.comBoxLabel = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.humidLabel = new System.Windows.Forms.Label();
            this.dataGatherBtn = new System.Windows.Forms.Button();
            this.soilMoistBox = new System.Windows.Forms.TextBox();
            this.soilMoistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // communicationPortsComboBox
            // 
            this.communicationPortsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communicationPortsComboBox.FormattingEnabled = true;
            this.communicationPortsComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.communicationPortsComboBox.Location = new System.Drawing.Point(165, 12);
            this.communicationPortsComboBox.Name = "communicationPortsComboBox";
            this.communicationPortsComboBox.Size = new System.Drawing.Size(379, 32);
            this.communicationPortsComboBox.TabIndex = 0;
            this.communicationPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.CommunicationPortsComboBox_SelectedIndexChanged);
            // 
            // comBoxLabel
            // 
            this.comBoxLabel.AutoSize = true;
            this.comBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLabel.Location = new System.Drawing.Point(12, 15);
            this.comBoxLabel.Name = "comBoxLabel";
            this.comBoxLabel.Size = new System.Drawing.Size(147, 24);
            this.comBoxLabel.TabIndex = 1;
            this.comBoxLabel.Text = "Enter COM Port:";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(16, 127);
            this.tempBox.Multiline = true;
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(162, 207);
            this.tempBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature: ";
            // 
            // humidBox
            // 
            this.humidBox.Location = new System.Drawing.Point(202, 127);
            this.humidBox.Multiline = true;
            this.humidBox.Name = "humidBox";
            this.humidBox.Size = new System.Drawing.Size(162, 207);
            this.humidBox.TabIndex = 4;
            // 
            // humidLabel
            // 
            this.humidLabel.AutoSize = true;
            this.humidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidLabel.Location = new System.Drawing.Point(198, 100);
            this.humidLabel.Name = "humidLabel";
            this.humidLabel.Size = new System.Drawing.Size(88, 24);
            this.humidLabel.TabIndex = 5;
            this.humidLabel.Text = "Humidity:";
            // 
            // dataGatherBtn
            // 
            this.dataGatherBtn.Location = new System.Drawing.Point(568, 127);
            this.dataGatherBtn.Name = "dataGatherBtn";
            this.dataGatherBtn.Size = new System.Drawing.Size(131, 209);
            this.dataGatherBtn.TabIndex = 6;
            this.dataGatherBtn.Text = "GatherData";
            this.dataGatherBtn.UseVisualStyleBackColor = true;
            this.dataGatherBtn.Click += new System.EventHandler(this.DataGatherBtn_Click);
            // 
            // soilMoistBox
            // 
            this.soilMoistBox.Location = new System.Drawing.Point(382, 129);
            this.soilMoistBox.Multiline = true;
            this.soilMoistBox.Name = "soilMoistBox";
            this.soilMoistBox.Size = new System.Drawing.Size(162, 207);
            this.soilMoistBox.TabIndex = 7;
            // 
            // soilMoistLabel
            // 
            this.soilMoistLabel.AutoSize = true;
            this.soilMoistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soilMoistLabel.Location = new System.Drawing.Point(378, 100);
            this.soilMoistLabel.Name = "soilMoistLabel";
            this.soilMoistLabel.Size = new System.Drawing.Size(123, 24);
            this.soilMoistLabel.TabIndex = 8;
            this.soilMoistLabel.Text = "Soil Moisture:";
            // 
            // Gatherer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 364);
            this.Controls.Add(this.soilMoistLabel);
            this.Controls.Add(this.soilMoistBox);
            this.Controls.Add(this.dataGatherBtn);
            this.Controls.Add(this.humidLabel);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.comBoxLabel);
            this.Controls.Add(this.communicationPortsComboBox);
            this.Name = "Gatherer";
            this.Text = "Data Gatherer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox communicationPortsComboBox;
        private System.Windows.Forms.Label comBoxLabel;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.Label humidLabel;
        private System.Windows.Forms.Button dataGatherBtn;
        private System.Windows.Forms.TextBox soilMoistBox;
        private System.Windows.Forms.Label soilMoistLabel;
    }
}

