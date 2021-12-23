namespace Rainbow.UI
{
    partial class FormSettings
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
            this.gradientButtonOk = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonCancel = new Rainbow.CustomControls.GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientButtonChangeDataFolder = new Rainbow.CustomControls.GradientButton();
            this.labelDataFolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSamplesPerSecond = new System.Windows.Forms.ComboBox();
            this.comboBoxBitsPerSample = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientButtonOk
            // 
            this.gradientButtonOk.Active = false;
            this.gradientButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonOk.HorizontalGradient = false;
            this.gradientButtonOk.Location = new System.Drawing.Point(172, 225);
            this.gradientButtonOk.Name = "gradientButtonOk";
            this.gradientButtonOk.Size = new System.Drawing.Size(85, 22);
            this.gradientButtonOk.TabIndex = 0;
            this.gradientButtonOk.Text = "Ok";
            this.gradientButtonOk.UseVisualStyleBackColor = true;
            this.gradientButtonOk.Click += new System.EventHandler(this.gradientButtonApply_Click);
            // 
            // gradientButtonCancel
            // 
            this.gradientButtonCancel.Active = false;
            this.gradientButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonCancel.HorizontalGradient = false;
            this.gradientButtonCancel.Location = new System.Drawing.Point(324, 225);
            this.gradientButtonCancel.Name = "gradientButtonCancel";
            this.gradientButtonCancel.Size = new System.Drawing.Size(85, 22);
            this.gradientButtonCancel.TabIndex = 1;
            this.gradientButtonCancel.Text = "Cancel";
            this.gradientButtonCancel.UseVisualStyleBackColor = true;
            this.gradientButtonCancel.Click += new System.EventHandler(this.gradientButtonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gradientButtonChangeDataFolder);
            this.panel2.Controls.Add(this.labelDataFolder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(33, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 77);
            this.panel2.TabIndex = 41;
            // 
            // gradientButtonChangeDataFolder
            // 
            this.gradientButtonChangeDataFolder.Active = false;
            this.gradientButtonChangeDataFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonChangeDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonChangeDataFolder.HorizontalGradient = false;
            this.gradientButtonChangeDataFolder.Location = new System.Drawing.Point(86, 43);
            this.gradientButtonChangeDataFolder.Name = "gradientButtonChangeDataFolder";
            this.gradientButtonChangeDataFolder.Size = new System.Drawing.Size(56, 18);
            this.gradientButtonChangeDataFolder.TabIndex = 36;
            this.gradientButtonChangeDataFolder.Text = "Change";
            this.gradientButtonChangeDataFolder.UseVisualStyleBackColor = true;
            this.gradientButtonChangeDataFolder.Click += new System.EventHandler(this.gradientButtonChangeDataFolder_Click);
            // 
            // labelDataFolder
            // 
            this.labelDataFolder.AutoSize = true;
            this.labelDataFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataFolder.ForeColor = System.Drawing.Color.White;
            this.labelDataFolder.Location = new System.Drawing.Point(92, 13);
            this.labelDataFolder.Name = "labelDataFolder";
            this.labelDataFolder.Size = new System.Drawing.Size(81, 15);
            this.labelDataFolder.TabIndex = 6;
            this.labelDataFolder.Text = "-data folder -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(33, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Samples per second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Bits per sample";
            // 
            // comboBoxSamplesPerSecond
            // 
            this.comboBoxSamplesPerSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSamplesPerSecond.FormattingEnabled = true;
            this.comboBoxSamplesPerSecond.Items.AddRange(new object[] {
            "44100",
            "48000",
            "88200",
            "96000",
            "132300",
            "144000",
            "176400",
            "192000"});
            this.comboBoxSamplesPerSecond.Location = new System.Drawing.Point(166, 114);
            this.comboBoxSamplesPerSecond.Name = "comboBoxSamplesPerSecond";
            this.comboBoxSamplesPerSecond.Size = new System.Drawing.Size(135, 23);
            this.comboBoxSamplesPerSecond.TabIndex = 46;
            // 
            // comboBoxBitsPerSample
            // 
            this.comboBoxBitsPerSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitsPerSample.FormattingEnabled = true;
            this.comboBoxBitsPerSample.Items.AddRange(new object[] {
            "16",
            "32"});
            this.comboBoxBitsPerSample.Location = new System.Drawing.Point(166, 152);
            this.comboBoxBitsPerSample.Name = "comboBoxBitsPerSample";
            this.comboBoxBitsPerSample.Size = new System.Drawing.Size(135, 23);
            this.comboBoxBitsPerSample.TabIndex = 47;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 273);
            this.Controls.Add(this.comboBoxBitsPerSample);
            this.Controls.Add(this.comboBoxSamplesPerSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientButtonCancel);
            this.Controls.Add(this.gradientButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormAddPreset_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.GradientButton gradientButtonOk;
        private CustomControls.GradientButton gradientButtonCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDataFolder;
        private System.Windows.Forms.Label label2;
        private CustomControls.GradientButton gradientButtonChangeDataFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSamplesPerSecond;
        private System.Windows.Forms.ComboBox comboBoxBitsPerSample;
    }
}