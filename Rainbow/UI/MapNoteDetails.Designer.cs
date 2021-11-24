namespace Rainbow.UI
{
    partial class MapNoteDetails
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
            System.Windows.Forms.Label label1;
            this.KeyNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputNoteNoTxt = new System.Windows.Forms.NumericUpDown();
            this.TriggerNoteNoTxt = new System.Windows.Forms.NumericUpDown();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutputNoteNoTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerNoteNoTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Key Name";
            // 
            // KeyNameTxt
            // 
            this.KeyNameTxt.Location = new System.Drawing.Point(88, 12);
            this.KeyNameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KeyNameTxt.Name = "KeyNameTxt";
            this.KeyNameTxt.Size = new System.Drawing.Size(117, 23);
            this.KeyNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trigger Note #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Note #";
            // 
            // OutputNoteNoTxt
            // 
            this.OutputNoteNoTxt.Location = new System.Drawing.Point(110, 83);
            this.OutputNoteNoTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputNoteNoTxt.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.OutputNoteNoTxt.Name = "OutputNoteNoTxt";
            this.OutputNoteNoTxt.Size = new System.Drawing.Size(62, 23);
            this.OutputNoteNoTxt.TabIndex = 4;
            // 
            // TriggerNoteNoTxt
            // 
            this.TriggerNoteNoTxt.Location = new System.Drawing.Point(110, 46);
            this.TriggerNoteNoTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TriggerNoteNoTxt.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.TriggerNoteNoTxt.Name = "TriggerNoteNoTxt";
            this.TriggerNoteNoTxt.Size = new System.Drawing.Size(62, 23);
            this.TriggerNoteNoTxt.TabIndex = 4;
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Location = new System.Drawing.Point(239, 12);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(88, 27);
            this.OKBtn.TabIndex = 5;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.CausesValidation = false;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(239, 46);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 27);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(279, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peter";
            // 
            // MapNoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(341, 120);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.TriggerNoteNoTxt);
            this.Controls.Add(this.OutputNoteNoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyNameTxt);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapNoteDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Note Mapping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapNoteDetails_FormClosed);
            this.Load += new System.EventHandler(this.MapNoteDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputNoteNoTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerNoteNoTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown OutputNoteNoTxt;
        private System.Windows.Forms.NumericUpDown TriggerNoteNoTxt;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label4;
    }
}