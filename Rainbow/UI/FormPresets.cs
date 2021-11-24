using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rainbow.UI
{
    /// <summary>
    /// A form that allows the user to edit the details of a note map item.
    /// </summary>
    internal sealed partial class FormPresets : Form
    {
        private FormMain myParent = null;

        public FormMain MyParent { get => myParent; set => myParent = value; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormPresets()
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


        private void MapNoteDetails_Load(object sender, EventArgs e)
        {
        }

        private void MapNoteDetails_FormClosed(object sender, FormClosedEventArgs e)
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
