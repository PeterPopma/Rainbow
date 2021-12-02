using Rainbow.CustomControls;
using System;
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
                myParent.setSecondaryWaveFile(myButton.Text);
            }
            else
            {
                myParent.setWaveFile(myButton.Text);
            }
            Cursor = Cursors.Default;
            Close();
        }


        private void FormWaves_Load(object sender, EventArgs e)
        {
            int x = 20;
            int y = 20;
            if(isSecondary)
            {
                GradientButton2 button = new GradientButton2();
                button.Left = x;
                button.Top = y;
                button.Text = "[None]";
                button.Width = 120;
                button.ForeColor = Color.White;
                button.Active = true;
                button.Font = new Font("Serif", 8.25f, FontStyle.Bold);
                button.FlatStyle = FlatStyle.Standard;
                button.Click += new EventHandler(wavefilebutton_Click);
                Controls.Add(button);
                x += button.Width + 8;
            }
            foreach (string wavefileName in myParent.WavefileNames)
            {
                if (x > Width - 130)       // next row of presets
                {
                    y += 30;
                    x = 20;
                }
                GradientButton2 button = new GradientButton2();
                button.Left = x;
                button.Top = y;
                button.Text = wavefileName;
                button.Width = 120;
                button.ForeColor = Color.White;
                button.Font = new Font("Serif", 8.25f, FontStyle.Bold);
                button.FlatStyle = FlatStyle.Standard;
                button.Click += new EventHandler(wavefilebutton_Click);
                Controls.Add(button);
                x += button.Width + 8;
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
