namespace Rainbow.UI
{
    partial class FormStretchMode
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
            this.gradientButtonCancel = new Rainbow.CustomControls.GradientButton();
            this.pictureBoxOverlap = new System.Windows.Forms.PictureBox();
            this.pictureBoxStretchToLargest = new System.Windows.Forms.PictureBox();
            this.pictureBoxShrinkToSmallest = new System.Windows.Forms.PictureBox();
            this.labelStretchMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxRepeatSmallest = new System.Windows.Forms.PictureBox();
            this.labelRepeatSmallest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretchToLargest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShrinkToSmallest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatSmallest)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientButtonCancel
            // 
            this.gradientButtonCancel.Active = false;
            this.gradientButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonCancel.HorizontalGradient = false;
            this.gradientButtonCancel.Location = new System.Drawing.Point(190, 368);
            this.gradientButtonCancel.Name = "gradientButtonCancel";
            this.gradientButtonCancel.Size = new System.Drawing.Size(85, 22);
            this.gradientButtonCancel.TabIndex = 1;
            this.gradientButtonCancel.Text = "Cancel";
            this.gradientButtonCancel.UseVisualStyleBackColor = true;
            this.gradientButtonCancel.Click += new System.EventHandler(this.gradientButtonCancel_Click);
            // 
            // pictureBoxOverlap
            // 
            this.pictureBoxOverlap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOverlap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOverlap.Image = global::Rainbow.Properties.Resources.overlap;
            this.pictureBoxOverlap.InitialImage = null;
            this.pictureBoxOverlap.Location = new System.Drawing.Point(59, 27);
            this.pictureBoxOverlap.Name = "pictureBoxOverlap";
            this.pictureBoxOverlap.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxOverlap.TabIndex = 230;
            this.pictureBoxOverlap.TabStop = false;
            this.pictureBoxOverlap.Click += new System.EventHandler(this.pictureBoxOverlap_Click);
            // 
            // pictureBoxStretchToLargest
            // 
            this.pictureBoxStretchToLargest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStretchToLargest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStretchToLargest.Image = global::Rainbow.Properties.Resources.stretchtolargest;
            this.pictureBoxStretchToLargest.InitialImage = null;
            this.pictureBoxStretchToLargest.Location = new System.Drawing.Point(59, 194);
            this.pictureBoxStretchToLargest.Name = "pictureBoxStretchToLargest";
            this.pictureBoxStretchToLargest.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxStretchToLargest.TabIndex = 231;
            this.pictureBoxStretchToLargest.TabStop = false;
            this.pictureBoxStretchToLargest.Click += new System.EventHandler(this.pictureBoxStretchToLargest_Click);
            // 
            // pictureBoxShrinkToSmallest
            // 
            this.pictureBoxShrinkToSmallest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShrinkToSmallest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShrinkToSmallest.Image = global::Rainbow.Properties.Resources.shrinktosmallest;
            this.pictureBoxShrinkToSmallest.InitialImage = null;
            this.pictureBoxShrinkToSmallest.Location = new System.Drawing.Point(276, 194);
            this.pictureBoxShrinkToSmallest.Name = "pictureBoxShrinkToSmallest";
            this.pictureBoxShrinkToSmallest.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxShrinkToSmallest.TabIndex = 232;
            this.pictureBoxShrinkToSmallest.TabStop = false;
            this.pictureBoxShrinkToSmallest.Click += new System.EventHandler(this.pictureBoxShrinkToSmallest_Click);
            // 
            // labelStretchMode
            // 
            this.labelStretchMode.AutoSize = true;
            this.labelStretchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStretchMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStretchMode.ForeColor = System.Drawing.Color.White;
            this.labelStretchMode.Location = new System.Drawing.Point(59, 132);
            this.labelStretchMode.Name = "labelStretchMode";
            this.labelStretchMode.Size = new System.Drawing.Size(126, 30);
            this.labelStretchMode.TabIndex = 233;
            this.labelStretchMode.Text = "Overlapping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 234;
            this.label1.Text = "Strech to largest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 235;
            this.label2.Text = "Shrink to smallest";
            // 
            // pictureBoxRepeatSmallest
            // 
            this.pictureBoxRepeatSmallest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRepeatSmallest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRepeatSmallest.Image = global::Rainbow.Properties.Resources.repeatsmallest;
            this.pictureBoxRepeatSmallest.InitialImage = null;
            this.pictureBoxRepeatSmallest.Location = new System.Drawing.Point(276, 27);
            this.pictureBoxRepeatSmallest.Name = "pictureBoxRepeatSmallest";
            this.pictureBoxRepeatSmallest.Size = new System.Drawing.Size(130, 102);
            this.pictureBoxRepeatSmallest.TabIndex = 236;
            this.pictureBoxRepeatSmallest.TabStop = false;
            this.pictureBoxRepeatSmallest.Click += new System.EventHandler(this.pictureBoxRepeatSmallest_Click);
            // 
            // labelRepeatSmallest
            // 
            this.labelRepeatSmallest.AutoSize = true;
            this.labelRepeatSmallest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepeatSmallest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRepeatSmallest.ForeColor = System.Drawing.Color.White;
            this.labelRepeatSmallest.Location = new System.Drawing.Point(261, 132);
            this.labelRepeatSmallest.Name = "labelRepeatSmallest";
            this.labelRepeatSmallest.Size = new System.Drawing.Size(158, 30);
            this.labelRepeatSmallest.TabIndex = 237;
            this.labelRepeatSmallest.Text = "Repeat smallest";
            // 
            // FormStretchMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 415);
            this.Controls.Add(this.labelRepeatSmallest);
            this.Controls.Add(this.pictureBoxRepeatSmallest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStretchMode);
            this.Controls.Add(this.pictureBoxShrinkToSmallest);
            this.Controls.Add(this.pictureBoxStretchToLargest);
            this.Controls.Add(this.pictureBoxOverlap);
            this.Controls.Add(this.gradientButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStretchMode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stretch Mode";
            this.Load += new System.EventHandler(this.FormAddPreset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStretchToLargest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShrinkToSmallest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatSmallest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.GradientButton gradientButtonCancel;
        private System.Windows.Forms.PictureBox pictureBoxOverlap;
        private System.Windows.Forms.PictureBox pictureBoxStretchToLargest;
        private System.Windows.Forms.PictureBox pictureBoxShrinkToSmallest;
        internal System.Windows.Forms.Label labelStretchMode;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxRepeatSmallest;
        internal System.Windows.Forms.Label labelRepeatSmallest;
    }
}