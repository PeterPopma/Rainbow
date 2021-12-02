
using Rainbow.Properties;

namespace Rainbow.UI
{
    partial class FormVolume
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
            this.labelVolumeMin = new System.Windows.Forms.Label();
            this.labelVolumeMax = new System.Windows.Forms.Label();
            this.pictureBoxCustomWave = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxNumSines = new System.Windows.Forms.TextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.textBoxNumIncSines = new System.Windows.Forms.TextBox();
            this.textBoxNumDecSines = new System.Windows.Forms.TextBox();
            this.buttonCancel = new Rainbow.CustomControls.GradientButton();
            this.buttonApply = new Rainbow.CustomControls.GradientButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFadeInSines = new System.Windows.Forms.PictureBox();
            this.pictureBoxFadeOutSines = new System.Windows.Forms.PictureBox();
            this.textBoxFadeInSines = new System.Windows.Forms.TextBox();
            this.textBoxFadeOutSines = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFadeInSines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFadeOutSines)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVolumeMin
            // 
            this.labelVolumeMin.AutoSize = true;
            this.labelVolumeMin.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolumeMin.Location = new System.Drawing.Point(1180, 490);
            this.labelVolumeMin.Name = "labelVolumeMin";
            this.labelVolumeMin.Size = new System.Drawing.Size(26, 29);
            this.labelVolumeMin.TabIndex = 140;
            this.labelVolumeMin.Text = "0";
            // 
            // labelVolumeMax
            // 
            this.labelVolumeMax.AutoSize = true;
            this.labelVolumeMax.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolumeMax.Location = new System.Drawing.Point(1180, 5);
            this.labelVolumeMax.Name = "labelVolumeMax";
            this.labelVolumeMax.Size = new System.Drawing.Size(52, 29);
            this.labelVolumeMax.TabIndex = 139;
            this.labelVolumeMax.Text = "100";
            // 
            // pictureBoxCustomWave
            // 
            this.pictureBoxCustomWave.Location = new System.Drawing.Point(173, 12);
            this.pictureBoxCustomWave.Name = "pictureBoxCustomWave";
            this.pictureBoxCustomWave.Size = new System.Drawing.Size(1000, 500);
            this.pictureBoxCustomWave.TabIndex = 154;
            this.pictureBoxCustomWave.TabStop = false;
            this.pictureBoxCustomWave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCustomWave_MouseDown);
            this.pictureBoxCustomWave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCustomWave_MouseMove);
            this.pictureBoxCustomWave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCustomWave_MouseUp);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::Rainbow.Properties.Resources.waves;
            this.pictureBox11.InitialImage = null;
            this.pictureBox11.Location = new System.Drawing.Point(88, 8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(70, 70);
            this.pictureBox11.TabIndex = 229;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::Rainbow.Properties.Resources.decsine;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(88, 312);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(70, 70);
            this.pictureBox10.TabIndex = 228;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::Rainbow.Properties.Resources.incsine;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(88, 236);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(70, 70);
            this.pictureBox9.TabIndex = 227;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Rainbow.Properties.Resources.decinc;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(88, 158);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.TabIndex = 225;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Rainbow.Properties.Resources.incdec;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(88, 84);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.TabIndex = 224;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Rainbow.Properties.Resources.logdec;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(12, 312);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.TabIndex = 223;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Rainbow.Properties.Resources.loginc;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(12, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.TabIndex = 222;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Rainbow.Properties.Resources.dec;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 221;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Rainbow.Properties.Resources.inc;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 220;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Rainbow.Properties.Resources.flat;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(12, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.TabIndex = 219;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textBoxNumSines
            // 
            this.textBoxNumSines.BackColor = System.Drawing.Color.Black;
            this.textBoxNumSines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumSines.ForeColor = System.Drawing.Color.White;
            this.textBoxNumSines.Location = new System.Drawing.Point(58, 435);
            this.textBoxNumSines.Name = "textBoxNumSines";
            this.textBoxNumSines.Size = new System.Drawing.Size(24, 23);
            this.textBoxNumSines.TabIndex = 218;
            this.textBoxNumSines.Text = "1";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::Rainbow.Properties.Resources.sine;
            this.pictureBox12.InitialImage = null;
            this.pictureBox12.Location = new System.Drawing.Point(12, 388);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(70, 70);
            this.pictureBox12.TabIndex = 230;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // textBoxNumIncSines
            // 
            this.textBoxNumIncSines.BackColor = System.Drawing.Color.Black;
            this.textBoxNumIncSines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumIncSines.ForeColor = System.Drawing.Color.White;
            this.textBoxNumIncSines.Location = new System.Drawing.Point(134, 283);
            this.textBoxNumIncSines.Name = "textBoxNumIncSines";
            this.textBoxNumIncSines.Size = new System.Drawing.Size(24, 23);
            this.textBoxNumIncSines.TabIndex = 231;
            this.textBoxNumIncSines.Text = "1";
            // 
            // textBoxNumDecSines
            // 
            this.textBoxNumDecSines.BackColor = System.Drawing.Color.Black;
            this.textBoxNumDecSines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumDecSines.ForeColor = System.Drawing.Color.White;
            this.textBoxNumDecSines.Location = new System.Drawing.Point(134, 359);
            this.textBoxNumDecSines.Name = "textBoxNumDecSines";
            this.textBoxNumDecSines.Size = new System.Drawing.Size(24, 23);
            this.textBoxNumDecSines.TabIndex = 232;
            this.textBoxNumDecSines.Text = "1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Active = false;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.HorizontalGradient = false;
            this.buttonCancel.Location = new System.Drawing.Point(709, 557);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 22);
            this.buttonCancel.TabIndex = 160;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Active = false;
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonApply.FlatAppearance.BorderSize = 2;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApply.ForeColor = System.Drawing.Color.Black;
            this.buttonApply.HorizontalGradient = false;
            this.buttonApply.Location = new System.Drawing.Point(484, 557);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(87, 22);
            this.buttonApply.TabIndex = 159;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Rainbow.Properties.Resources.ripples;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(88, 388);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 70);
            this.pictureBox8.TabIndex = 233;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBoxFadeInSines
            // 
            this.pictureBoxFadeInSines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFadeInSines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFadeInSines.Image = global::Rainbow.Properties.Resources.fadeinsine;
            this.pictureBoxFadeInSines.InitialImage = null;
            this.pictureBoxFadeInSines.Location = new System.Drawing.Point(12, 464);
            this.pictureBoxFadeInSines.Name = "pictureBoxFadeInSines";
            this.pictureBoxFadeInSines.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxFadeInSines.TabIndex = 234;
            this.pictureBoxFadeInSines.TabStop = false;
            this.pictureBoxFadeInSines.Click += new System.EventHandler(this.pictureBoxFadeInSines_Click);
            // 
            // pictureBoxFadeOutSines
            // 
            this.pictureBoxFadeOutSines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFadeOutSines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFadeOutSines.Image = global::Rainbow.Properties.Resources.fadeoutsine;
            this.pictureBoxFadeOutSines.InitialImage = null;
            this.pictureBoxFadeOutSines.Location = new System.Drawing.Point(88, 464);
            this.pictureBoxFadeOutSines.Name = "pictureBoxFadeOutSines";
            this.pictureBoxFadeOutSines.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxFadeOutSines.TabIndex = 235;
            this.pictureBoxFadeOutSines.TabStop = false;
            this.pictureBoxFadeOutSines.Click += new System.EventHandler(this.pictureBoxFadeOutSines_Click);
            // 
            // textBoxFadeInSines
            // 
            this.textBoxFadeInSines.BackColor = System.Drawing.Color.Black;
            this.textBoxFadeInSines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFadeInSines.ForeColor = System.Drawing.Color.White;
            this.textBoxFadeInSines.Location = new System.Drawing.Point(58, 511);
            this.textBoxFadeInSines.Name = "textBoxFadeInSines";
            this.textBoxFadeInSines.Size = new System.Drawing.Size(24, 23);
            this.textBoxFadeInSines.TabIndex = 236;
            this.textBoxFadeInSines.Text = "1";
            this.textBoxFadeInSines.TextChanged += new System.EventHandler(this.textBoxFadeInSines_TextChanged);
            // 
            // textBoxFadeOutSines
            // 
            this.textBoxFadeOutSines.BackColor = System.Drawing.Color.Black;
            this.textBoxFadeOutSines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFadeOutSines.ForeColor = System.Drawing.Color.White;
            this.textBoxFadeOutSines.Location = new System.Drawing.Point(134, 511);
            this.textBoxFadeOutSines.Name = "textBoxFadeOutSines";
            this.textBoxFadeOutSines.Size = new System.Drawing.Size(24, 23);
            this.textBoxFadeOutSines.TabIndex = 237;
            this.textBoxFadeOutSines.Text = "1";
            this.textBoxFadeOutSines.TextChanged += new System.EventHandler(this.textBoxFadeOutSines_TextChanged);
            // 
            // FormVolume
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1254, 611);
            this.Controls.Add(this.textBoxFadeOutSines);
            this.Controls.Add(this.textBoxFadeInSines);
            this.Controls.Add(this.pictureBoxFadeOutSines);
            this.Controls.Add(this.pictureBoxFadeInSines);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.textBoxNumDecSines);
            this.Controls.Add(this.textBoxNumIncSines);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxNumSines);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.pictureBoxCustomWave);
            this.Controls.Add(this.labelVolumeMin);
            this.Controls.Add(this.labelVolumeMax);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVolume";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFadeInSines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFadeOutSines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVolumeMin;
        private System.Windows.Forms.Label labelVolumeMax;
        private System.Windows.Forms.PictureBox pictureBoxCustomWave;
        private CustomControls.GradientButton buttonCancel;
        private CustomControls.GradientButton buttonApply;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxNumSines;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.TextBox textBoxNumIncSines;
        private System.Windows.Forms.TextBox textBoxNumDecSines;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBoxFadeInSines;
        private System.Windows.Forms.PictureBox pictureBoxFadeOutSines;
        private System.Windows.Forms.TextBox textBoxFadeOutSines;
        private System.Windows.Forms.TextBox textBoxFadeInSines;
    }
}
