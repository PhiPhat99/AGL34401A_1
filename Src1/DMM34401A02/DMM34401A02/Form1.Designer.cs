namespace DMM34401A02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VACMeasBtn = new System.Windows.Forms.Button();
            this.VDCMeasBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnectBtn);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(43, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DMM Connection";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackColor = System.Drawing.Color.Red;
            this.DisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectBtn.Location = new System.Drawing.Point(161, 31);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(125, 35);
            this.DisconnectBtn.TabIndex = 1;
            this.DisconnectBtn.Text = "DISCONNECT";
            this.DisconnectBtn.UseVisualStyleBackColor = false;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.Lime;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Location = new System.Drawing.Point(17, 31);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(125, 35);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "CONNECT";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VACMeasBtn);
            this.groupBox2.Controls.Add(this.VDCMeasBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(447, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measurement";
            // 
            // VACMeasBtn
            // 
            this.VACMeasBtn.BackColor = System.Drawing.Color.Orange;
            this.VACMeasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VACMeasBtn.Location = new System.Drawing.Point(161, 31);
            this.VACMeasBtn.Name = "VACMeasBtn";
            this.VACMeasBtn.Size = new System.Drawing.Size(125, 35);
            this.VACMeasBtn.TabIndex = 1;
            this.VACMeasBtn.Text = "VAC MEASURE";
            this.VACMeasBtn.UseVisualStyleBackColor = false;
            // 
            // VDCMeasBtn
            // 
            this.VDCMeasBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.VDCMeasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VDCMeasBtn.Location = new System.Drawing.Point(17, 31);
            this.VDCMeasBtn.Name = "VDCMeasBtn";
            this.VDCMeasBtn.Size = new System.Drawing.Size(125, 35);
            this.VDCMeasBtn.TabIndex = 0;
            this.VDCMeasBtn.Text = "VDC MEASURE";
            this.VDCMeasBtn.UseVisualStyleBackColor = false;
            this.VDCMeasBtn.Click += new System.EventHandler(this.VDCMeasBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(339, 383);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(120, 55);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(45, 145);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(708, 217);
            this.ResultTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMM 34401A Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button VACMeasBtn;
        private System.Windows.Forms.Button VDCMeasBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox ResultTextbox;
    }
}

