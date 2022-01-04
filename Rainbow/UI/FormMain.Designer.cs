using System.Drawing;

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
            this.pictureBoxRepeat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRepeatBegin = new System.Windows.Forms.Label();
            this.labelRepeatEnd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWaveFile1 = new System.Windows.Forms.Label();
            this.labelPreset = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelMixMode = new System.Windows.Forms.Panel();
            this.gradientButtonNextMixMode = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousMixMode = new Rainbow.CustomControls.GradientButton();
            this.pictureBoxMixMode = new System.Windows.Forms.PictureBox();
            this.labelMixMode = new System.Windows.Forms.Label();
            this.panelSound2 = new System.Windows.Forms.Panel();
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.gradientButtonNextSound2 = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousSound2 = new Rainbow.CustomControls.GradientButton();
            this.checkBoxInvert2 = new System.Windows.Forms.CheckBox();
            this.pictureBoxVolume2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelWaveFile2 = new System.Windows.Forms.Label();
            this.panelRepeatPart = new System.Windows.Forms.Panel();
            this.panelStretchMode = new System.Windows.Forms.Panel();
            this.gradientButtonNextStretchMode = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousStretchMode = new Rainbow.CustomControls.GradientButton();
            this.pictureBoxStretchMode = new System.Windows.Forms.PictureBox();
            this.labelStretchMode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSound1 = new System.Windows.Forms.Panel();
            this.gradientButtonNextSound1 = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousSound1 = new Rainbow.CustomControls.GradientButton();
            this.checkBoxInvert1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxVolume1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.panelPreset = new System.Windows.Forms.Panel();
            this.gradientButtonAddPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetSave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetDelete = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextPreset = new Rainbow.CustomControls.GradientButton();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelDuration = new System.Windows.Forms.Panel();
            this.pictureBoxDuration = new System.Windows.Forms.PictureBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gradientButtonPreviousWave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextWave = new Rainbow.CustomControls.GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMixMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMixMode)).BeginInit();
            this.panelSound2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume2)).BeginInit();
            this.panelRepeatPart.SuspendLayout();
            this.panelStretchMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretchMode)).BeginInit();
            this.panelSound1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume1)).BeginInit();
            this.panelPreset.SuspendLayout();
            this.panelDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Location = new System.Drawing.Point(8, 28);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(7, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Repeating part";
            // 
            // labelRepeatBegin
            // 
            this.labelRepeatBegin.AutoSize = true;
            this.labelRepeatBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepeatBegin.ForeColor = System.Drawing.Color.White;
            this.labelRepeatBegin.Location = new System.Drawing.Point(255, 25);
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
            this.labelRepeatEnd.Location = new System.Drawing.Point(255, 44);
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
            this.label5.Location = new System.Drawing.Point(222, 24);
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
            this.label6.Location = new System.Drawing.Point(222, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "end:";
            // 
            // labelWaveFile1
            // 
            this.labelWaveFile1.AutoSize = true;
            this.labelWaveFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWaveFile1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWaveFile1.ForeColor = System.Drawing.Color.White;
            this.labelWaveFile1.Location = new System.Drawing.Point(82, 44);
            this.labelWaveFile1.Name = "labelWaveFile1";
            this.labelWaveFile1.Size = new System.Drawing.Size(89, 30);
            this.labelWaveFile1.TabIndex = 23;
            this.labelWaveFile1.Text = "Sound 1";
            this.labelWaveFile1.Click += new System.EventHandler(this.labelWaveFile_Click);
            this.labelWaveFile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelWaveFile_MouseMove);
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPreset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreset.ForeColor = System.Drawing.Color.White;
            this.labelPreset.Location = new System.Drawing.Point(296, 13);
            this.labelPreset.Name = "labelPreset";
            this.labelPreset.Size = new System.Drawing.Size(70, 30);
            this.labelPreset.TabIndex = 27;
            this.labelPreset.Text = "Preset";
            this.labelPreset.Click += new System.EventHandler(this.labelPreset_Click);
            this.labelPreset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPreset_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(672, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "© 2021 Peter Popma - p_popma@hotmail.com";
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.Location = new System.Drawing.Point(59, 5);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(558, 126);
            this.pictureBoxTitle.TabIndex = 31;
            this.pictureBoxTitle.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.panelMixMode);
            this.panel1.Controls.Add(this.panelSound2);
            this.panel1.Controls.Add(this.panelRepeatPart);
            this.panel1.Controls.Add(this.panelStretchMode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panelSound1);
            this.panel1.Controls.Add(this.panelPreset);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.panelDuration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(11, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 386);
            this.panel1.TabIndex = 40;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonSave.Image = global::Rainbow.Properties.Resources.buttonsave;
            this.buttonSave.Location = new System.Drawing.Point(772, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(51, 49);
            this.buttonSave.TabIndex = 55;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonPlay.Image = global::Rainbow.Properties.Resources.playbutton;
            this.buttonPlay.Location = new System.Drawing.Point(820, 269);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(54, 54);
            this.buttonPlay.TabIndex = 54;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelMixMode
            // 
            this.panelMixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMixMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMixMode.Controls.Add(this.gradientButtonNextMixMode);
            this.panelMixMode.Controls.Add(this.gradientButtonPreviousMixMode);
            this.panelMixMode.Controls.Add(this.pictureBoxMixMode);
            this.panelMixMode.Controls.Add(this.labelMixMode);
            this.panelMixMode.Location = new System.Drawing.Point(242, 221);
            this.panelMixMode.Name = "panelMixMode";
            this.panelMixMode.Size = new System.Drawing.Size(226, 154);
            this.panelMixMode.TabIndex = 52;
            // 
            // gradientButtonNextMixMode
            // 
            this.gradientButtonNextMixMode.Active = false;
            this.gradientButtonNextMixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextMixMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextMixMode.HorizontalGradient = false;
            this.gradientButtonNextMixMode.Location = new System.Drawing.Point(41, 46);
            this.gradientButtonNextMixMode.Name = "gradientButtonNextMixMode";
            this.gradientButtonNextMixMode.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextMixMode.TabIndex = 56;
            this.gradientButtonNextMixMode.Text = ">";
            this.gradientButtonNextMixMode.UseVisualStyleBackColor = true;
            this.gradientButtonNextMixMode.Click += new System.EventHandler(this.gradientButtonNextMixMode_Click);
            // 
            // gradientButtonPreviousMixMode
            // 
            this.gradientButtonPreviousMixMode.Active = false;
            this.gradientButtonPreviousMixMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousMixMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousMixMode.HorizontalGradient = false;
            this.gradientButtonPreviousMixMode.Location = new System.Drawing.Point(12, 46);
            this.gradientButtonPreviousMixMode.Name = "gradientButtonPreviousMixMode";
            this.gradientButtonPreviousMixMode.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousMixMode.TabIndex = 55;
            this.gradientButtonPreviousMixMode.Text = "<";
            this.gradientButtonPreviousMixMode.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousMixMode.Click += new System.EventHandler(this.gradientButtonPreviousMixMode_Click);
            // 
            // pictureBoxMixMode
            // 
            this.pictureBoxMixMode.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMixMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMixMode.Location = new System.Drawing.Point(81, 13);
            this.pictureBoxMixMode.Name = "pictureBoxMixMode";
            this.pictureBoxMixMode.Size = new System.Drawing.Size(128, 100);
            this.pictureBoxMixMode.TabIndex = 50;
            this.pictureBoxMixMode.TabStop = false;
            this.pictureBoxMixMode.Click += new System.EventHandler(this.pictureBoxMixMode_Click);
            // 
            // labelMixMode
            // 
            this.labelMixMode.AutoSize = true;
            this.labelMixMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMixMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMixMode.ForeColor = System.Drawing.Color.White;
            this.labelMixMode.Location = new System.Drawing.Point(7, 113);
            this.labelMixMode.Name = "labelMixMode";
            this.labelMixMode.Size = new System.Drawing.Size(178, 30);
            this.labelMixMode.TabIndex = 54;
            this.labelMixMode.Text = "Alt. Squared (20X)";
            // 
            // panelSound2
            // 
            this.panelSound2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSound2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSound2.Controls.Add(this.buttonPlay2);
            this.panelSound2.Controls.Add(this.gradientButtonNextSound2);
            this.panelSound2.Controls.Add(this.gradientButtonPreviousSound2);
            this.panelSound2.Controls.Add(this.checkBoxInvert2);
            this.panelSound2.Controls.Add(this.pictureBoxVolume2);
            this.panelSound2.Controls.Add(this.label11);
            this.panelSound2.Controls.Add(this.labelWaveFile2);
            this.panelSound2.Location = new System.Drawing.Point(458, 99);
            this.panelSound2.Name = "panelSound2";
            this.panelSound2.Size = new System.Drawing.Size(441, 94);
            this.panelSound2.TabIndex = 46;
            this.panelSound2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelSecondarySound_MouseClick);
            // 
            // buttonPlay2
            // 
            this.buttonPlay2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay2.FlatAppearance.BorderSize = 0;
            this.buttonPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay2.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonPlay2.Image = global::Rainbow.Properties.Resources.play;
            this.buttonPlay2.Location = new System.Drawing.Point(4, 4);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(22, 23);
            this.buttonPlay2.TabIndex = 55;
            this.buttonPlay2.UseVisualStyleBackColor = true;
            this.buttonPlay2.Click += new System.EventHandler(this.buttonPlay2_Click);
            // 
            // gradientButtonNextSound2
            // 
            this.gradientButtonNextSound2.Active = false;
            this.gradientButtonNextSound2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextSound2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextSound2.HorizontalGradient = false;
            this.gradientButtonNextSound2.Location = new System.Drawing.Point(38, 40);
            this.gradientButtonNextSound2.Name = "gradientButtonNextSound2";
            this.gradientButtonNextSound2.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextSound2.TabIndex = 54;
            this.gradientButtonNextSound2.Text = ">";
            this.gradientButtonNextSound2.UseVisualStyleBackColor = true;
            this.gradientButtonNextSound2.Click += new System.EventHandler(this.gradientButtonNextSecondary_Click);
            // 
            // gradientButtonPreviousSound2
            // 
            this.gradientButtonPreviousSound2.Active = false;
            this.gradientButtonPreviousSound2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousSound2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousSound2.HorizontalGradient = false;
            this.gradientButtonPreviousSound2.Location = new System.Drawing.Point(9, 40);
            this.gradientButtonPreviousSound2.Name = "gradientButtonPreviousSound2";
            this.gradientButtonPreviousSound2.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousSound2.TabIndex = 53;
            this.gradientButtonPreviousSound2.Text = "<";
            this.gradientButtonPreviousSound2.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousSound2.Click += new System.EventHandler(this.gradientButtonPreviousSecondary_Click);
            // 
            // checkBoxInvert2
            // 
            this.checkBoxInvert2.AutoSize = true;
            this.checkBoxInvert2.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxInvert2.Location = new System.Drawing.Point(32, 7);
            this.checkBoxInvert2.Name = "checkBoxInvert2";
            this.checkBoxInvert2.Size = new System.Drawing.Size(56, 19);
            this.checkBoxInvert2.TabIndex = 50;
            this.checkBoxInvert2.Text = "invert";
            this.checkBoxInvert2.UseVisualStyleBackColor = true;
            this.checkBoxInvert2.CheckedChanged += new System.EventHandler(this.checkBoxInvert2_CheckedChanged);
            this.checkBoxInvert2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxInvert2_MouseUp);
            // 
            // pictureBoxVolume2
            // 
            this.pictureBoxVolume2.BackColor = System.Drawing.Color.Black;
            this.pictureBoxVolume2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVolume2.Location = new System.Drawing.Point(293, 9);
            this.pictureBoxVolume2.Name = "pictureBoxVolume2";
            this.pictureBoxVolume2.Size = new System.Drawing.Size(136, 59);
            this.pictureBoxVolume2.TabIndex = 48;
            this.pictureBoxVolume2.TabStop = false;
            this.pictureBoxVolume2.Click += new System.EventHandler(this.pictureBoxVolume2_Click);
            this.pictureBoxVolume2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVolume2_Paint);
            this.pictureBoxVolume2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVolume2_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(218, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Volume";
            // 
            // labelWaveFile2
            // 
            this.labelWaveFile2.AutoSize = true;
            this.labelWaveFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWaveFile2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWaveFile2.ForeColor = System.Drawing.Color.White;
            this.labelWaveFile2.Location = new System.Drawing.Point(83, 45);
            this.labelWaveFile2.Name = "labelWaveFile2";
            this.labelWaveFile2.Size = new System.Drawing.Size(89, 30);
            this.labelWaveFile2.TabIndex = 23;
            this.labelWaveFile2.Text = "Sound 2";
            this.labelWaveFile2.Click += new System.EventHandler(this.labelSecondary_Click);
            this.labelWaveFile2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelSecondary_MouseMove);
            // 
            // panelRepeatPart
            // 
            this.panelRepeatPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelRepeatPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRepeatPart.Controls.Add(this.pictureBoxRepeat);
            this.panelRepeatPart.Controls.Add(this.label4);
            this.panelRepeatPart.Controls.Add(this.labelRepeatBegin);
            this.panelRepeatPart.Controls.Add(this.label6);
            this.panelRepeatPart.Controls.Add(this.labelRepeatEnd);
            this.panelRepeatPart.Controls.Add(this.label5);
            this.panelRepeatPart.Location = new System.Drawing.Point(473, 298);
            this.panelRepeatPart.Name = "panelRepeatPart";
            this.panelRepeatPart.Size = new System.Drawing.Size(305, 77);
            this.panelRepeatPart.TabIndex = 45;
            // 
            // panelStretchMode
            // 
            this.panelStretchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelStretchMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStretchMode.Controls.Add(this.gradientButtonNextStretchMode);
            this.panelStretchMode.Controls.Add(this.gradientButtonPreviousStretchMode);
            this.panelStretchMode.Controls.Add(this.pictureBoxStretchMode);
            this.panelStretchMode.Controls.Add(this.labelStretchMode);
            this.panelStretchMode.Location = new System.Drawing.Point(11, 221);
            this.panelStretchMode.Name = "panelStretchMode";
            this.panelStretchMode.Size = new System.Drawing.Size(226, 154);
            this.panelStretchMode.TabIndex = 44;
            // 
            // gradientButtonNextStretchMode
            // 
            this.gradientButtonNextStretchMode.Active = false;
            this.gradientButtonNextStretchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextStretchMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextStretchMode.HorizontalGradient = false;
            this.gradientButtonNextStretchMode.Location = new System.Drawing.Point(39, 47);
            this.gradientButtonNextStretchMode.Name = "gradientButtonNextStretchMode";
            this.gradientButtonNextStretchMode.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextStretchMode.TabIndex = 56;
            this.gradientButtonNextStretchMode.Text = ">";
            this.gradientButtonNextStretchMode.UseVisualStyleBackColor = true;
            this.gradientButtonNextStretchMode.Click += new System.EventHandler(this.gradientButtonNextStretchMode_Click);
            // 
            // gradientButtonPreviousStretchMode
            // 
            this.gradientButtonPreviousStretchMode.Active = false;
            this.gradientButtonPreviousStretchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousStretchMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousStretchMode.HorizontalGradient = false;
            this.gradientButtonPreviousStretchMode.Location = new System.Drawing.Point(10, 47);
            this.gradientButtonPreviousStretchMode.Name = "gradientButtonPreviousStretchMode";
            this.gradientButtonPreviousStretchMode.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousStretchMode.TabIndex = 55;
            this.gradientButtonPreviousStretchMode.Text = "<";
            this.gradientButtonPreviousStretchMode.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousStretchMode.Click += new System.EventHandler(this.gradientButtonPreviousStretchMode_Click);
            // 
            // pictureBoxStretchMode
            // 
            this.pictureBoxStretchMode.BackColor = System.Drawing.Color.Black;
            this.pictureBoxStretchMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStretchMode.Location = new System.Drawing.Point(80, 17);
            this.pictureBoxStretchMode.Name = "pictureBoxStretchMode";
            this.pictureBoxStretchMode.Size = new System.Drawing.Size(128, 100);
            this.pictureBoxStretchMode.TabIndex = 50;
            this.pictureBoxStretchMode.TabStop = false;
            this.pictureBoxStretchMode.Click += new System.EventHandler(this.pictureBoxStretchMode_Click);
            // 
            // labelStretchMode
            // 
            this.labelStretchMode.AutoSize = true;
            this.labelStretchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStretchMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStretchMode.ForeColor = System.Drawing.Color.White;
            this.labelStretchMode.Location = new System.Drawing.Point(10, 117);
            this.labelStretchMode.Name = "labelStretchMode";
            this.labelStretchMode.Size = new System.Drawing.Size(131, 30);
            this.labelStretchMode.TabIndex = 54;
            this.labelStretchMode.Text = "StretchMode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(9, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Preset";
            // 
            // panelSound1
            // 
            this.panelSound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSound1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSound1.Controls.Add(this.gradientButtonNextSound1);
            this.panelSound1.Controls.Add(this.gradientButtonPreviousSound1);
            this.panelSound1.Controls.Add(this.checkBoxInvert1);
            this.panelSound1.Controls.Add(this.pictureBoxVolume1);
            this.panelSound1.Controls.Add(this.label7);
            this.panelSound1.Controls.Add(this.labelWaveFile1);
            this.panelSound1.Controls.Add(this.buttonPlay1);
            this.panelSound1.Location = new System.Drawing.Point(12, 99);
            this.panelSound1.Name = "panelSound1";
            this.panelSound1.Size = new System.Drawing.Size(441, 94);
            this.panelSound1.TabIndex = 43;
            this.panelSound1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBaseSound_MouseClick);
            // 
            // gradientButtonNextSound1
            // 
            this.gradientButtonNextSound1.Active = false;
            this.gradientButtonNextSound1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextSound1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextSound1.HorizontalGradient = false;
            this.gradientButtonNextSound1.Location = new System.Drawing.Point(38, 39);
            this.gradientButtonNextSound1.Name = "gradientButtonNextSound1";
            this.gradientButtonNextSound1.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextSound1.TabIndex = 53;
            this.gradientButtonNextSound1.Text = ">";
            this.gradientButtonNextSound1.UseVisualStyleBackColor = true;
            this.gradientButtonNextSound1.Click += new System.EventHandler(this.gradientButtonNextWave_Click);
            // 
            // gradientButtonPreviousSound1
            // 
            this.gradientButtonPreviousSound1.Active = false;
            this.gradientButtonPreviousSound1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousSound1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousSound1.HorizontalGradient = false;
            this.gradientButtonPreviousSound1.Location = new System.Drawing.Point(9, 39);
            this.gradientButtonPreviousSound1.Name = "gradientButtonPreviousSound1";
            this.gradientButtonPreviousSound1.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousSound1.TabIndex = 52;
            this.gradientButtonPreviousSound1.Text = "<";
            this.gradientButtonPreviousSound1.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousSound1.Click += new System.EventHandler(this.gradientButtonPreviousWave_Click);
            // 
            // checkBoxInvert1
            // 
            this.checkBoxInvert1.AutoSize = true;
            this.checkBoxInvert1.ForeColor = System.Drawing.Color.Silver;
            this.checkBoxInvert1.Location = new System.Drawing.Point(33, 9);
            this.checkBoxInvert1.Name = "checkBoxInvert1";
            this.checkBoxInvert1.Size = new System.Drawing.Size(56, 19);
            this.checkBoxInvert1.TabIndex = 51;
            this.checkBoxInvert1.Text = "invert";
            this.checkBoxInvert1.UseVisualStyleBackColor = true;
            this.checkBoxInvert1.CheckedChanged += new System.EventHandler(this.checkBoxInvert1_CheckedChanged);
            this.checkBoxInvert1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkBoxInvert1_MouseUp);
            // 
            // pictureBoxVolume1
            // 
            this.pictureBoxVolume1.BackColor = System.Drawing.Color.Black;
            this.pictureBoxVolume1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVolume1.Location = new System.Drawing.Point(294, 9);
            this.pictureBoxVolume1.Name = "pictureBoxVolume1";
            this.pictureBoxVolume1.Size = new System.Drawing.Size(136, 59);
            this.pictureBoxVolume1.TabIndex = 48;
            this.pictureBoxVolume1.TabStop = false;
            this.pictureBoxVolume1.Click += new System.EventHandler(this.pictureBoxVolume1_Click);
            this.pictureBoxVolume1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVolume1_Paint);
            this.pictureBoxVolume1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVolume1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(221, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Volume";
            // 
            // buttonPlay1
            // 
            this.buttonPlay1.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay1.FlatAppearance.BorderSize = 0;
            this.buttonPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay1.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonPlay1.Image = global::Rainbow.Properties.Resources.play;
            this.buttonPlay1.Location = new System.Drawing.Point(4, 7);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(24, 21);
            this.buttonPlay1.TabIndex = 54;
            this.buttonPlay1.UseVisualStyleBackColor = true;
            this.buttonPlay1.Click += new System.EventHandler(this.buttonPlay1_Click);
            // 
            // panelPreset
            // 
            this.panelPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelPreset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreset.Controls.Add(this.labelPreset);
            this.panelPreset.Controls.Add(this.gradientButtonAddPreset);
            this.panelPreset.Controls.Add(this.gradientButtonPresetSave);
            this.panelPreset.Controls.Add(this.gradientButtonPresetDelete);
            this.panelPreset.Controls.Add(this.gradientButtonPreviousPreset);
            this.panelPreset.Controls.Add(this.gradientButtonNextPreset);
            this.panelPreset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPreset.Location = new System.Drawing.Point(70, 9);
            this.panelPreset.Name = "panelPreset";
            this.panelPreset.Size = new System.Drawing.Size(670, 60);
            this.panelPreset.TabIndex = 42;
            // 
            // gradientButtonAddPreset
            // 
            this.gradientButtonAddPreset.Active = false;
            this.gradientButtonAddPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonAddPreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonAddPreset.HorizontalGradient = false;
            this.gradientButtonAddPreset.Location = new System.Drawing.Point(13, 19);
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
            this.gradientButtonPresetSave.Location = new System.Drawing.Point(77, 19);
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
            this.gradientButtonPresetDelete.Location = new System.Drawing.Point(140, 19);
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
            this.gradientButtonPreviousPreset.Location = new System.Drawing.Point(216, 9);
            this.gradientButtonPreviousPreset.Name = "gradientButtonPreviousPreset";
            this.gradientButtonPreviousPreset.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousPreset.TabIndex = 35;
            this.gradientButtonPreviousPreset.Text = "<";
            this.gradientButtonPreviousPreset.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousPreset.Click += new System.EventHandler(this.gradientButtonPreviousPreset_Click);
            // 
            // gradientButtonNextPreset
            // 
            this.gradientButtonNextPreset.Active = false;
            this.gradientButtonNextPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextPreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextPreset.HorizontalGradient = false;
            this.gradientButtonNextPreset.Location = new System.Drawing.Point(244, 9);
            this.gradientButtonNextPreset.Name = "gradientButtonNextPreset";
            this.gradientButtonNextPreset.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextPreset.TabIndex = 37;
            this.gradientButtonNextPreset.Text = ">";
            this.gradientButtonNextPreset.UseVisualStyleBackColor = true;
            this.gradientButtonNextPreset.Click += new System.EventHandler(this.gradientButtonNextPreset_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonSettings.Image = global::Rainbow.Properties.Resources.cogwheel;
            this.buttonSettings.Location = new System.Drawing.Point(843, 9);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(51, 49);
            this.buttonSettings.TabIndex = 41;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDuration.Controls.Add(this.pictureBoxDuration);
            this.panelDuration.Controls.Add(this.labelDuration);
            this.panelDuration.Controls.Add(this.label1);
            this.panelDuration.Controls.Add(this.label12);
            this.panelDuration.Location = new System.Drawing.Point(473, 221);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(305, 71);
            this.panelDuration.TabIndex = 49;
            // 
            // pictureBoxDuration
            // 
            this.pictureBoxDuration.Location = new System.Drawing.Point(7, 28);
            this.pictureBoxDuration.Name = "pictureBoxDuration";
            this.pictureBoxDuration.Size = new System.Drawing.Size(208, 31);
            this.pictureBoxDuration.TabIndex = 52;
            this.pictureBoxDuration.TabStop = false;
            this.pictureBoxDuration.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDuration_Paint);
            this.pictureBoxDuration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDuration_MouseDown);
            this.pictureBoxDuration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDuration_MouseMove);
            this.pictureBoxDuration.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDuration_MouseUp);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDuration.ForeColor = System.Drawing.Color.White;
            this.labelDuration.Location = new System.Drawing.Point(222, 26);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(41, 15);
            this.labelDuration.TabIndex = 51;
            this.labelDuration.Text = "33.2 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(222, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(8, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Stretch mode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(242, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 21);
            this.label14.TabIndex = 53;
            this.label14.Text = "Mix mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sound 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(455, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Sound 2";
            // 
            // gradientButtonPreviousWave
            // 
            this.gradientButtonPreviousWave.Active = false;
            this.gradientButtonPreviousWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousWave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousWave.HorizontalGradient = false;
            this.gradientButtonPreviousWave.Location = new System.Drawing.Point(13, 9);
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
            this.gradientButtonNextWave.Location = new System.Drawing.Point(42, 9);
            this.gradientButtonNextWave.Name = "gradientButtonNextWave";
            this.gradientButtonNextWave.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextWave.TabIndex = 39;
            this.gradientButtonNextWave.Text = ">";
            this.gradientButtonNextWave.UseVisualStyleBackColor = true;
            this.gradientButtonNextWave.Click += new System.EventHandler(this.gradientButtonNextWave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Size = new System.Drawing.Size(931, 521);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMixMode.ResumeLayout(false);
            this.panelMixMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMixMode)).EndInit();
            this.panelSound2.ResumeLayout(false);
            this.panelSound2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume2)).EndInit();
            this.panelRepeatPart.ResumeLayout(false);
            this.panelRepeatPart.PerformLayout();
            this.panelStretchMode.ResumeLayout(false);
            this.panelStretchMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretchMode)).EndInit();
            this.panelSound1.ResumeLayout(false);
            this.panelSound1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolume1)).EndInit();
            this.panelPreset.ResumeLayout(false);
            this.panelPreset.PerformLayout();
            this.panelDuration.ResumeLayout(false);
            this.panelDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRepeatBegin;
        private System.Windows.Forms.Label labelRepeatEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomControls.GradientButton gradientButtonNextWave;
        private CustomControls.GradientButton gradientButtonPreviousWave;
        private CustomControls.GradientButton gradientButtonPreviousPreset;
        private CustomControls.GradientButton gradientButtonNextPreset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private CustomControls.GradientButton gradientButtonAddPreset;
        private CustomControls.GradientButton gradientButtonPresetSave;
        private CustomControls.GradientButton gradientButtonPresetDelete;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labelWaveFile1;
        internal System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelSound1;
        private System.Windows.Forms.Panel panelPreset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStretchMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSound2;
        private CustomControls.GradientButton gradientButtonNextSecondary;
        private CustomControls.GradientButton gradientButtonPreviousSecondary;
        internal System.Windows.Forms.Label labelWaveFile2;
        private System.Windows.Forms.Panel panelRepeatPart;
        internal System.Windows.Forms.PictureBox pictureBoxVolume1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.PictureBox pictureBoxVolume2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox pictureBoxStretchMode;
        private CustomControls.GradientButton gradientButtonNextMixMode;
        private CustomControls.GradientButton gradientButtonPreviousMixMode;
        private System.Windows.Forms.Panel panelDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label labelStretchMode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelMixMode;
        internal System.Windows.Forms.Label labelMixMode;
        private CustomControls.GradientButton gradientButtonNextStretchMode;
        private CustomControls.GradientButton gradientButtonPreviousStretchMode;
        internal System.Windows.Forms.PictureBox pictureBoxMixMode;
        private System.Windows.Forms.PictureBox pictureBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.CheckBox checkBoxInvert2;
        private System.Windows.Forms.CheckBox checkBoxInvert1;
        private CustomControls.GradientButton gradientButtonNextSound1;
        private CustomControls.GradientButton gradientButtonPreviousSound1;
        private CustomControls.GradientButton gradientButtonNextSound2;
        private CustomControls.GradientButton gradientButtonPreviousSound2;
        private System.Windows.Forms.Button buttonPlay1;
        private System.Windows.Forms.Button buttonPlay2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPlay;
    }
}
