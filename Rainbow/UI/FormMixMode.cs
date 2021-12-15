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
    internal sealed partial class FormMixMode : Form
    {
        private FormMain myParent = null;

        public FormMain MyParent { get => myParent; set => myParent = value; }
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormMixMode()
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

        private void pictureBoxAlternateSquare_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 3;
            myParent.SynthGenerator.NumMixWaves = (int)numericUpDownSquared.Value;
            myParent.UpdateMixMode();
            Close();
        }

        private void pictureBoxAlternateTriangle_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 4;
            myParent.SynthGenerator.NumMixWaves = (int)numericUpDownTriangle.Value;
            myParent.UpdateMixMode();
            Close();
        }

        private void pictureBoxAlternateSine_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 5;
            myParent.SynthGenerator.NumMixWaves = (int)numericUpDownSine.Value;
            myParent.UpdateMixMode();
            Close();
        }

        private void pictureBoxMultiply_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 2;
            myParent.UpdateMixMode();
            Close();
        }

        private void pictureBoxSameWeight_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 1;
            myParent.UpdateMixMode();
            Close();
        }

        private void pictureBoxFadeInOut_Click(object sender, EventArgs e)
        {
            myParent.SynthGenerator.MixMode = 0;
            myParent.UpdateMixMode();
            Close();
        }
    }
}
