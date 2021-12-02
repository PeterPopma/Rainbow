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
            this.labelDataFolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientButtonChangeDataFolder = new Rainbow.CustomControls.GradientButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientButtonOk
            // 
            this.gradientButtonOk.Active = false;
            this.gradientButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonOk.HorizontalGradient = false;
            this.gradientButtonOk.Location = new System.Drawing.Point(162, 203);
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
            this.gradientButtonCancel.Location = new System.Drawing.Point(314, 203);
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
            this.panel2.Controls.Add(this.labelDataFolder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(99, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 77);
            this.panel2.TabIndex = 41;
            // 
            // labelDataFolder
            // 
            this.labelDataFolder.AutoSize = true;
            this.labelDataFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataFolder.ForeColor = System.Drawing.Color.White;
            this.labelDataFolder.Location = new System.Drawing.Point(96, 11);
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
            // gradientButtonChangeDataFolder
            // 
            this.gradientButtonChangeDataFolder.Active = false;
            this.gradientButtonChangeDataFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonChangeDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonChangeDataFolder.HorizontalGradient = false;
            this.gradientButtonChangeDataFolder.Location = new System.Drawing.Point(120, 87);
            this.gradientButtonChangeDataFolder.Name = "gradientButtonChangeDataFolder";
            this.gradientButtonChangeDataFolder.Size = new System.Drawing.Size(56, 18);
            this.gradientButtonChangeDataFolder.TabIndex = 36;
            this.gradientButtonChangeDataFolder.Text = "Change";
            this.gradientButtonChangeDataFolder.UseVisualStyleBackColor = true;
            this.gradientButtonChangeDataFolder.Click += new System.EventHandler(this.gradientButtonChangeDataFolder_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 273);
            this.Controls.Add(this.gradientButtonChangeDataFolder);
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

        }

        #endregion

        private CustomControls.GradientButton gradientButtonOk;
        private CustomControls.GradientButton gradientButtonCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDataFolder;
        private System.Windows.Forms.Label label2;
        private CustomControls.GradientButton gradientButtonChangeDataFolder;
    }
}