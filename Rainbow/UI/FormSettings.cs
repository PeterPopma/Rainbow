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
    internal sealed partial class FormSettings : Form
    {
        private FormMain myParent = null;

        public FormMain MyParent { get => myParent; set => myParent = value; }
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormSettings()
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
            if (!labelDataFolder.Text.Equals(myParent.DataFolder))     // folder changed
            {
                myParent.DataFolder = labelDataFolder.Text;
                myParent.UpdateWavefilesList();
                myParent.ReloadPresets();
            }
            myParent.SynthGenerator.SamplesPerSecondOutput = Convert.ToInt32(comboBoxSamplesPerSecond.Text);
            myParent.SynthGenerator.BitsPerSample = Convert.ToInt32(comboBoxBitsPerSample.Text);
            myParent.SaveSettings();

            Close();
        }

        private void gradientButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddPreset_Load(object sender, EventArgs e)
        {
            labelDataFolder.Text = myParent.DataFolder;
            comboBoxSamplesPerSecond.SelectedIndex = comboBoxSamplesPerSecond.FindStringExact(myParent.SynthGenerator.SamplesPerSecondOutput.ToString());
            comboBoxBitsPerSample.SelectedIndex = comboBoxBitsPerSample.FindStringExact(myParent.SynthGenerator.BitsPerSample.ToString());
        }

        private void gradientButtonChangeDataFolder_Click(object sender, EventArgs e)
        {
            using (var opnDlg = new FolderBrowserDialog())
            {

                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    labelDataFolder.Text = opnDlg.SelectedPath;
                }
            }
        }
    }
}
