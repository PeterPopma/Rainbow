namespace Rainbow.UI
{
    partial class FormWaves
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
            this.SuspendLayout();
            // 
            // gradientButtonCancel
            // 
            this.gradientButtonCancel.Active = false;
            this.gradientButtonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.gradientButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradientButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.gradientButtonCancel.HorizontalGradient = false;
            this.gradientButtonCancel.Location = new System.Drawing.Point(880, 611);
            this.gradientButtonCancel.Name = "gradientButtonCancel";
            this.gradientButtonCancel.Size = new System.Drawing.Size(121, 23);
            this.gradientButtonCancel.TabIndex = 0;
            this.gradientButtonCancel.Text = "cancel";
            this.gradientButtonCancel.UseVisualStyleBackColor = false;
            this.gradientButtonCancel.Click += new System.EventHandler(this.gradientButtonCancel_Click);
            // 
            // FormWaves
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 662);
            this.Controls.Add(this.gradientButtonCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWaves";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWaves_FormClosed);
            this.Load += new System.EventHandler(this.FormWaves_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.GradientButton gradientButtonCancel;
    }
}