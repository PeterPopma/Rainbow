using Rainbow.CustomControls;
using Rainbow.Synth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rainbow.UI
{
    /// <summary>
    /// A form that allows the user to edit the details of a note map item.
    /// </summary>
    internal sealed partial class FormWaves : Form
    {
        private FormMain myParent = null;
        private bool isSecondary = false;

        public FormMain MyParent { get => myParent; set => myParent = value; }
        public bool IsSecondary { get => isSecondary; set => isSecondary = value; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormWaves()
        {
            InitializeComponent();
        }
        
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width == 0 || this.ClientRectangle.Height == 0)
            {
                return;
            }
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(70, 77, 95),
                                                                       Color.Black,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        /// <summary>
        /// Gets or sets the note map item that is edited in the form.
        /// </summary>

        private void wavefilebutton_Click(object sender, EventArgs e)
        {
            GradientButton2 myButton = (GradientButton2)sender;
            Cursor = Cursors.WaitCursor;
            if (isSecondary)
            {
                myParent.setSecondaryWaveFile(myButton.Category);
            }
            else
            {
                myParent.setWaveFile(myButton.Category);
            }
            Cursor = Cursors.Default;
            Close();
        }


        private void FormWaves_Load(object sender, EventArgs e)
        {
            int x = 2;
            int[] y = new int[] { 2, 2 };

            List<string> categories = myParent.GetAllWaveFileCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                string category = categories[i];
                int x_offset = i % 2 * (Width / 2);
                if (!category.Equals("[none]")) {
                    Label label = new Label();
                    label.BackColor = Color.FromArgb(0, 0, 0, 0);
                    label.ForeColor = Color.FromArgb(172, 172, 225);
                    label.Font = new Font("Serif", 10, FontStyle.Bold);
                    label.Text = category;
                    label.Left = x + x_offset + 5;
                    label.Top = y[i % 2];
                    label.Height = 20;
                    label.Width = Width / 2 - 40;
                    Controls.Add(label);
                    y[i % 2] += label.Height;
                }
                foreach (CategoryItem waveFile in myParent.WaveFiles)
                {
                    if (waveFile.Category.Equals(category))
                    {
                        if (x > Width / 2 - 140)       // next row of presets
                        {
                            y[i % 2] += 22;
                            x = 2;
                        }
                        GradientButton2 button = new GradientButton2();
                        button.Left = x + x_offset;
                        button.Top = y[i % 2];
                        button.Text = waveFile.Name;
                        button.Width = 85;
                        button.Height = 20;
                        button.ForeColor = Color.White;
                        button.Font = new Font("Serif", 8.0f, FontStyle.Regular);
                        button.FlatStyle = FlatStyle.Standard;
                        button.Click += new EventHandler(wavefilebutton_Click);
                        button.Category = waveFile;
                        Controls.Add(button);
                        x += button.Width + 2;
                    }
                }
                x = 2;
                y[i % 2] += 24;
            }
        }

        private void FormWaves_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {

        }

        private void gradientButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
