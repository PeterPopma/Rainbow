﻿using System.Drawing;

namespace Rainbow.UI
{
    partial class FormMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.labelDataFolder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPostProcessing = new System.Windows.Forms.ComboBox();
            this.pictureBoxRepeat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRepeatBegin = new System.Windows.Forms.Label();
            this.labelRepeatEnd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWaveFile = new System.Windows.Forms.Label();
            this.labelPreset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientButtonAddPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetSave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetDelete = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonChangeDataFolder = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousWave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextWave = new Rainbow.CustomControls.GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Folder";
            // 
            // labelDataFolder
            // 
            this.labelDataFolder.AutoSize = true;
            this.labelDataFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataFolder.ForeColor = System.Drawing.Color.White;
            this.labelDataFolder.Location = new System.Drawing.Point(7, 33);
            this.labelDataFolder.Name = "labelDataFolder";
            this.labelDataFolder.Size = new System.Drawing.Size(81, 15);
            this.labelDataFolder.TabIndex = 6;
            this.labelDataFolder.Text = "-data folder -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(273, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base Sound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(80, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Post processing:";
            // 
            // comboBoxPostProcessing
            // 
            this.comboBoxPostProcessing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostProcessing.FormattingEnabled = true;
            this.comboBoxPostProcessing.Items.AddRange(new object[] {
            "Off",
            "Method 1"});
            this.comboBoxPostProcessing.Location = new System.Drawing.Point(183, 230);
            this.comboBoxPostProcessing.Name = "comboBoxPostProcessing";
            this.comboBoxPostProcessing.Size = new System.Drawing.Size(88, 23);
            this.comboBoxPostProcessing.TabIndex = 10;
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Location = new System.Drawing.Point(500, 105);
            this.pictureBoxRepeat.Name = "pictureBoxRepeat";
            this.pictureBoxRepeat.Size = new System.Drawing.Size(208, 31);
            this.pictureBoxRepeat.TabIndex = 11;
            this.pictureBoxRepeat.TabStop = false;
            this.pictureBoxRepeat.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRepeat_Paint);
            this.pictureBoxRepeat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRepeat_MouseDown);
            this.pictureBoxRepeat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRepeat_MouseMove);
            this.pictureBoxRepeat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRepeat_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(500, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Repeating part";
            // 
            // labelRepeatBegin
            // 
            this.labelRepeatBegin.AutoSize = true;
            this.labelRepeatBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepeatBegin.ForeColor = System.Drawing.Color.White;
            this.labelRepeatBegin.Location = new System.Drawing.Point(747, 102);
            this.labelRepeatBegin.Name = "labelRepeatBegin";
            this.labelRepeatBegin.Size = new System.Drawing.Size(32, 15);
            this.labelRepeatBegin.TabIndex = 13;
            this.labelRepeatBegin.Text = "33 %";
            // 
            // labelRepeatEnd
            // 
            this.labelRepeatEnd.AutoSize = true;
            this.labelRepeatEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepeatEnd.ForeColor = System.Drawing.Color.White;
            this.labelRepeatEnd.Location = new System.Drawing.Point(747, 121);
            this.labelRepeatEnd.Name = "labelRepeatEnd";
            this.labelRepeatEnd.Size = new System.Drawing.Size(41, 15);
            this.labelRepeatEnd.TabIndex = 15;
            this.labelRepeatEnd.Text = "33.2 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(714, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(714, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "end:";
            // 
            // labelWaveFile
            // 
            this.labelWaveFile.AutoSize = true;
            this.labelWaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWaveFile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWaveFile.ForeColor = System.Drawing.Color.White;
            this.labelWaveFile.Location = new System.Drawing.Point(269, 105);
            this.labelWaveFile.Name = "labelWaveFile";
            this.labelWaveFile.Size = new System.Drawing.Size(121, 30);
            this.labelWaveFile.TabIndex = 23;
            this.labelWaveFile.Text = "Base Sound";
            this.labelWaveFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWaveFile_MouseDown);
            this.labelWaveFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelWaveFile_MouseMove);
            this.labelWaveFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelWaveFile_MouseUp);
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPreset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreset.ForeColor = System.Drawing.Color.White;
            this.labelPreset.Location = new System.Drawing.Point(269, 27);
            this.labelPreset.Name = "labelPreset";
            this.labelPreset.Size = new System.Drawing.Size(70, 30);
            this.labelPreset.TabIndex = 27;
            this.labelPreset.Text = "Preset";
            this.labelPreset.Click += new System.EventHandler(this.labelPreset_Click);
            this.labelPreset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPreset_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(272, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Preset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(13, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "© 2021 Peter Popma - p_popma@hotmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 126);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // gradientButtonAddPreset
            // 
            this.gradientButtonAddPreset.Active = false;
            this.gradientButtonAddPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonAddPreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonAddPreset.HorizontalGradient = false;
            this.gradientButtonAddPreset.Location = new System.Drawing.Point(12, 34);
            this.gradientButtonAddPreset.Name = "gradientButtonAddPreset";
            this.gradientButtonAddPreset.Size = new System.Drawing.Size(56, 24);
            this.gradientButtonAddPreset.TabIndex = 32;
            this.gradientButtonAddPreset.Text = "Add";
            this.gradientButtonAddPreset.UseVisualStyleBackColor = true;
            this.gradientButtonAddPreset.Click += new System.EventHandler(this.gradientButtonAddPreset_Click);
            // 
            // gradientButtonPresetSave
            // 
            this.gradientButtonPresetSave.Active = false;
            this.gradientButtonPresetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPresetSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPresetSave.HorizontalGradient = false;
            this.gradientButtonPresetSave.Location = new System.Drawing.Point(74, 34);
            this.gradientButtonPresetSave.Name = "gradientButtonPresetSave";
            this.gradientButtonPresetSave.Size = new System.Drawing.Size(56, 24);
            this.gradientButtonPresetSave.TabIndex = 33;
            this.gradientButtonPresetSave.Text = "Save";
            this.gradientButtonPresetSave.UseVisualStyleBackColor = true;
            this.gradientButtonPresetSave.Click += new System.EventHandler(this.gradientButtonPresetSave_Click);
            // 
            // gradientButtonPresetDelete
            // 
            this.gradientButtonPresetDelete.Active = false;
            this.gradientButtonPresetDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPresetDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPresetDelete.HorizontalGradient = false;
            this.gradientButtonPresetDelete.Location = new System.Drawing.Point(136, 34);
            this.gradientButtonPresetDelete.Name = "gradientButtonPresetDelete";
            this.gradientButtonPresetDelete.Size = new System.Drawing.Size(56, 24);
            this.gradientButtonPresetDelete.TabIndex = 34;
            this.gradientButtonPresetDelete.Text = "Delete";
            this.gradientButtonPresetDelete.UseVisualStyleBackColor = true;
            this.gradientButtonPresetDelete.Click += new System.EventHandler(this.gradientButtonPresetDelete_Click);
            // 
            // gradientButtonPreviousPreset
            // 
            this.gradientButtonPreviousPreset.Active = false;
            this.gradientButtonPreviousPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousPreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousPreset.HorizontalGradient = false;
            this.gradientButtonPreviousPreset.Location = new System.Drawing.Point(215, 24);
            this.gradientButtonPreviousPreset.Name = "gradientButtonPreviousPreset";
            this.gradientButtonPreviousPreset.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousPreset.TabIndex = 35;
            this.gradientButtonPreviousPreset.Text = "<";
            this.gradientButtonPreviousPreset.UseVisualStyleBackColor = true;
            // 
            // gradientButtonChangeDataFolder
            // 
            this.gradientButtonChangeDataFolder.Active = false;
            this.gradientButtonChangeDataFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonChangeDataFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonChangeDataFolder.HorizontalGradient = false;
            this.gradientButtonChangeDataFolder.Location = new System.Drawing.Point(10, 8);
            this.gradientButtonChangeDataFolder.Name = "gradientButtonChangeDataFolder";
            this.gradientButtonChangeDataFolder.Size = new System.Drawing.Size(56, 18);
            this.gradientButtonChangeDataFolder.TabIndex = 36;
            this.gradientButtonChangeDataFolder.Text = "Change";
            this.gradientButtonChangeDataFolder.UseVisualStyleBackColor = true;
            this.gradientButtonChangeDataFolder.Click += new System.EventHandler(this.gradientButtonChangeDataFolder_Click);
            // 
            // gradientButtonNextPreset
            // 
            this.gradientButtonNextPreset.Active = false;
            this.gradientButtonNextPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextPreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextPreset.HorizontalGradient = false;
            this.gradientButtonNextPreset.Location = new System.Drawing.Point(243, 24);
            this.gradientButtonNextPreset.Name = "gradientButtonNextPreset";
            this.gradientButtonNextPreset.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextPreset.TabIndex = 37;
            this.gradientButtonNextPreset.Text = ">";
            this.gradientButtonNextPreset.UseVisualStyleBackColor = true;
            // 
            // gradientButtonPreviousWave
            // 
            this.gradientButtonPreviousWave.Active = false;
            this.gradientButtonPreviousWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousWave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousWave.HorizontalGradient = false;
            this.gradientButtonPreviousWave.Location = new System.Drawing.Point(215, 102);
            this.gradientButtonPreviousWave.Name = "gradientButtonPreviousWave";
            this.gradientButtonPreviousWave.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousWave.TabIndex = 38;
            this.gradientButtonPreviousWave.Text = "<";
            this.gradientButtonPreviousWave.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousWave.Click += new System.EventHandler(this.gradientButtonPreviousWave_Click);
            // 
            // gradientButtonNextWave
            // 
            this.gradientButtonNextWave.Active = false;
            this.gradientButtonNextWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextWave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextWave.HorizontalGradient = false;
            this.gradientButtonNextWave.Location = new System.Drawing.Point(244, 101);
            this.gradientButtonNextWave.Name = "gradientButtonNextWave";
            this.gradientButtonNextWave.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextWave.TabIndex = 39;
            this.gradientButtonNextWave.Text = ">";
            this.gradientButtonNextWave.UseVisualStyleBackColor = true;
            this.gradientButtonNextWave.Click += new System.EventHandler(this.gradientButtonNextWave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gradientButtonNextWave);
            this.panel1.Controls.Add(this.gradientButtonPreviousWave);
            this.panel1.Controls.Add(this.gradientButtonNextPreset);
            this.panel1.Controls.Add(this.gradientButtonPreviousPreset);
            this.panel1.Controls.Add(this.gradientButtonPresetDelete);
            this.panel1.Controls.Add(this.gradientButtonPresetSave);
            this.panel1.Controls.Add(this.gradientButtonAddPreset);
            this.panel1.Controls.Add(this.labelPreset);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelWaveFile);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelRepeatEnd);
            this.panel1.Controls.Add(this.labelRepeatBegin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBoxRepeat);
            this.panel1.Controls.Add(this.comboBoxPostProcessing);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 358);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gradientButtonChangeDataFolder);
            this.panel2.Controls.Add(this.labelDataFolder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(607, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 57);
            this.panel2.TabIndex = 40;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Size = new System.Drawing.Size(931, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDataFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBoxPostProcessing;
        private System.Windows.Forms.PictureBox pictureBoxRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRepeatBegin;
        private System.Windows.Forms.Label labelRepeatEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomControls.GradientButton gradientButtonChangeDataFolder;
        private System.Windows.Forms.Label labelWaveFile;
        private CustomControls.GradientButton gradientButtonNextWave;
        private CustomControls.GradientButton gradientButtonPreviousWave;
        private CustomControls.GradientButton gradientButtonPreviousPreset;
        private CustomControls.GradientButton gradientButtonNextPreset;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Rainbow.CustomControls.GradientButton gradientButtonAddPreset;
        private Rainbow.CustomControls.GradientButton gradientButtonPresetSave;
        private Rainbow.CustomControls.GradientButton gradientButtonPresetDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
