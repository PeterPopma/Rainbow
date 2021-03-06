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
    internal sealed partial class FormStretchMode : Form
    {
        private FormMain myParent = null;

        public FormMain MyParent { get => myParent; set => myParent = value; }
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormStretchMode()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                       Color.FromArgb(0, 0, 0),
                                                                       Color.FromArgb(70, 70, 94),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void gradientButtonApply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gradientButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddPreset_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxOverlap_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.SetStretchMode(0);
            myParent.UpdateStretchMode();
            Close();
        }

        private void pictureBoxStretchToLargest_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.SetStretchMode(2);
            myParent.UpdateStretchMode();
            Close();
        }

        private void pictureBoxShrinkToSmallest_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.SetStretchMode(3);
            myParent.UpdateStretchMode();
            Close();
        }

        private void pictureBoxRepeatSmallest_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.SetStretchMode(1);
            myParent.UpdateStretchMode();
            Close();
        }
    }
}
