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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientButtonAddPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetSave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPresetDelete = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextPreset = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousWave = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonNextWave = new Rainbow.CustomControls.GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxVolumeShape = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSecondarySound = new System.Windows.Forms.Panel();
            this.gradientButtonNextSecondary = new Rainbow.CustomControls.GradientButton();
            this.gradientButtonPreviousSecondary = new Rainbow.CustomControls.GradientButton();
            this.labelSecondary = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownEffect1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBaseSound = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolumeShape)).BeginInit();
            this.panelSecondarySound.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffect1)).BeginInit();
            this.panelBaseSound.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(182, 20);
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
            this.comboBoxPostProcessing.Location = new System.Drawing.Point(285, 17);
            this.comboBoxPostProcessing.Name = "comboBoxPostProcessing";
            this.comboBoxPostProcessing.Size = new System.Drawing.Size(88, 23);
            this.comboBoxPostProcessing.TabIndex = 10;
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Location = new System.Drawing.Point(12, 20);
            this.pictureBoxRepeat.Name = "pictureBoxRepeat";
            this.pictureBoxRepeat.Size = new System.Drawing.Size(208, 31);
            this.pictureBoxRepeat.TabIndex = 11;
            this.pictureBoxRepeat.TabStop = false;
            this.pictureBoxRepeat.Click += new System.EventHandler(this.pictureBoxRepeat_Click);
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
            this.label4.Location = new System.Drawing.Point(12, 2);
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
            this.labelRepeatBegin.Location = new System.Drawing.Point(259, 17);
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
            this.labelRepeatEnd.Location = new System.Drawing.Point(259, 36);
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
            this.label5.Location = new System.Drawing.Point(226, 16);
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
            this.label6.Location = new System.Drawing.Point(226, 36);
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
            this.labelWaveFile.Location = new System.Drawing.Point(71, 13);
            this.labelWaveFile.Name = "labelWaveFile";
            this.labelWaveFile.Size = new System.Drawing.Size(121, 30);
            this.labelWaveFile.TabIndex = 23;
            this.labelWaveFile.Text = "Base Sound";
            this.labelWaveFile.Click += new System.EventHandler(this.labelWaveFile_Click);
            this.labelWaveFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelWaveFile_MouseMove);
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPreset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreset.ForeColor = System.Drawing.Color.White;
            this.labelPreset.Location = new System.Drawing.Point(272, 13);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBoxVolumeShape);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panelSecondarySound);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelBaseSound);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Location = new System.Drawing.Point(11, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 360);
            this.panel1.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(543, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Volume";
            // 
            // pictureBoxVolumeShape
            // 
            this.pictureBoxVolumeShape.BackColor = System.Drawing.Color.Black;
            this.pictureBoxVolumeShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVolumeShape.Location = new System.Drawing.Point(613, 199);
            this.pictureBoxVolumeShape.Name = "pictureBoxVolumeShape";
            this.pictureBoxVolumeShape.Size = new System.Drawing.Size(136, 59);
            this.pictureBoxVolumeShape.TabIndex = 48;
            this.pictureBoxVolumeShape.TabStop = false;
            this.pictureBoxVolumeShape.Click += new System.EventHandler(this.pictureBoxVolumeShape_Click);
            this.pictureBoxVolumeShape.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVolumeShape_Paint);
            this.pictureBoxVolumeShape.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVolumeShape_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(450, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Secondary Sound";
            // 
            // panelSecondarySound
            // 
            this.panelSecondarySound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSecondarySound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSecondarySound.Controls.Add(this.gradientButtonNextSecondary);
            this.panelSecondarySound.Controls.Add(this.gradientButtonPreviousSecondary);
            this.panelSecondarySound.Controls.Add(this.labelSecondary);
            this.panelSecondarySound.Location = new System.Drawing.Point(458, 123);
            this.panelSecondarySound.Name = "panelSecondarySound";
            this.panelSecondarySound.Size = new System.Drawing.Size(441, 60);
            this.panelSecondarySound.TabIndex = 46;
            this.panelSecondarySound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelSecondarySound_MouseClick);
            // 
            // gradientButtonNextSecondary
            // 
            this.gradientButtonNextSecondary.Active = false;
            this.gradientButtonNextSecondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonNextSecondary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonNextSecondary.HorizontalGradient = false;
            this.gradientButtonNextSecondary.Location = new System.Drawing.Point(42, 9);
            this.gradientButtonNextSecondary.Name = "gradientButtonNextSecondary";
            this.gradientButtonNextSecondary.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonNextSecondary.TabIndex = 39;
            this.gradientButtonNextSecondary.Text = ">";
            this.gradientButtonNextSecondary.UseVisualStyleBackColor = true;
            this.gradientButtonNextSecondary.Click += new System.EventHandler(this.gradientButtonNextSecondary_Click);
            // 
            // gradientButtonPreviousSecondary
            // 
            this.gradientButtonPreviousSecondary.Active = false;
            this.gradientButtonPreviousSecondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonPreviousSecondary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonPreviousSecondary.HorizontalGradient = false;
            this.gradientButtonPreviousSecondary.Location = new System.Drawing.Point(13, 9);
            this.gradientButtonPreviousSecondary.Name = "gradientButtonPreviousSecondary";
            this.gradientButtonPreviousSecondary.Size = new System.Drawing.Size(23, 41);
            this.gradientButtonPreviousSecondary.TabIndex = 38;
            this.gradientButtonPreviousSecondary.Text = "<";
            this.gradientButtonPreviousSecondary.UseVisualStyleBackColor = true;
            this.gradientButtonPreviousSecondary.Click += new System.EventHandler(this.gradientButtonPreviousSecondary_Click);
            // 
            // labelSecondary
            // 
            this.labelSecondary.AutoSize = true;
            this.labelSecondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSecondary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecondary.ForeColor = System.Drawing.Color.White;
            this.labelSecondary.Location = new System.Drawing.Point(71, 13);
            this.labelSecondary.Name = "labelSecondary";
            this.labelSecondary.Size = new System.Drawing.Size(76, 30);
            this.labelSecondary.TabIndex = 23;
            this.labelSecondary.Text = "[None]";
            this.labelSecondary.Click += new System.EventHandler(this.labelSecondary_Click);
            this.labelSecondary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelSecondary_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBoxRepeat);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.labelRepeatBegin);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.labelRepeatEnd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(564, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 61);
            this.panel5.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numericUpDownEffect1);
            this.panel4.Controls.Add(this.comboBoxPostProcessing);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 60);
            this.panel4.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "effect 1";
            // 
            // numericUpDownEffect1
            // 
            this.numericUpDownEffect1.Location = new System.Drawing.Point(80, 17);
            this.numericUpDownEffect1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEffect1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownEffect1.Name = "numericUpDownEffect1";
            this.numericUpDownEffect1.Size = new System.Drawing.Size(63, 23);
            this.numericUpDownEffect1.TabIndex = 1;
            this.numericUpDownEffect1.ValueChanged += new System.EventHandler(this.numericUpDownFlattenEffect_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Preset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Base Sound";
            // 
            // panelBaseSound
            // 
            this.panelBaseSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBaseSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaseSound.Controls.Add(this.gradientButtonNextWave);
            this.panelBaseSound.Controls.Add(this.gradientButtonPreviousWave);
            this.panelBaseSound.Controls.Add(this.labelWaveFile);
            this.panelBaseSound.Location = new System.Drawing.Point(11, 123);
            this.panelBaseSound.Name = "panelBaseSound";
            this.panelBaseSound.Size = new System.Drawing.Size(441, 60);
            this.panelBaseSound.TabIndex = 43;
            this.panelBaseSound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBaseSound_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gradientButtonNextPreset);
            this.panel2.Controls.Add(this.gradientButtonPreviousPreset);
            this.panel2.Controls.Add(this.gradientButtonPresetDelete);
            this.panel2.Controls.Add(this.gradientButtonPresetSave);
            this.panel2.Controls.Add(this.gradientButtonAddPreset);
            this.panel2.Controls.Add(this.labelPreset);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(11, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 60);
            this.panel2.TabIndex = 42;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonSettings.Image = global::Rainbow.Properties.Resources.cogwheel;
            this.buttonSettings.Location = new System.Drawing.Point(845, 9);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(51, 49);
            this.buttonSettings.TabIndex = 41;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.Size = new System.Drawing.Size(931, 503);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolumeShape)).EndInit();
            this.panelSecondarySound.ResumeLayout(false);
            this.panelSecondarySound.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffect1)).EndInit();
            this.panelBaseSound.ResumeLayout(false);
            this.panelBaseSound.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBoxPostProcessing;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Rainbow.CustomControls.GradientButton gradientButtonAddPreset;
        private Rainbow.CustomControls.GradientButton gradientButtonPresetSave;
        private Rainbow.CustomControls.GradientButton gradientButtonPresetDelete;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labelWaveFile;
        internal System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelBaseSound;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private CustomControls.GradientButton2 gradientButton21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownEffect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSecondarySound;
        private CustomControls.GradientButton gradientButtonNextSecondary;
        private CustomControls.GradientButton gradientButtonPreviousSecondary;
        internal System.Windows.Forms.Label labelSecondary;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.PictureBox pictureBoxVolumeShape;
        private System.Windows.Forms.Label label7;
    }
}
