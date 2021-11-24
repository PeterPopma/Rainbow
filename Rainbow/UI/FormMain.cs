using Microsoft.Win32;
using Rainbow.Synth;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Rainbow.UI
{
    /// <summary>
    /// The plugin custom editor UI.
    /// </summary>
    internal sealed partial class FormMain : UserControl
    {
        SynthGenerator synthGenerator;
        bool changingRepeatBegin = false;
        bool changingRepeatEnd = false;
        List<string> wavefileNames = new List<string>();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            LoadSettings();
            UpdateWavefilesList();
            UpdateRepeatUI();
            comboBoxPostProcessing.SelectedIndex = 0;
            panel1.Paint += new PaintEventHandler(GroupBoxPaint);
            //            groupBox1.Refresh();

        }

        /// <summary>
        /// Contains a queue with note-on note numbers currently playing.
        /// </summary>
        internal SynthGenerator SynthGenerator { get => synthGenerator; set => synthGenerator = value; }
        public List<string> WavefileNames { get => wavefileNames; set => wavefileNames = value; }

        public void UpdateWavefilesList()
        {
            labelDataFolder.Text = synthGenerator.DataFolder;

            WavefileNames.Clear();
            // find all wavefiles
            try
            {
                string[] fileEntries = Directory.GetFiles(synthGenerator.DataFolder + "\\wavefiles\\");
                foreach (string fileName in fileEntries)
                {
                    if (fileName.EndsWith(".wav"))
                    {

                        string wavefile = fileName.Substring(synthGenerator.DataFolder.Length + 11);
                        wavefile = wavefile.Substring(0, wavefile.Length - 4) ;
                        WavefileNames.Add(wavefile);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory("wavefiles");
            }

            if (WavefileNames.Count>0)
            {
                setWaveFile(WavefileNames[0]);
            }
        }

         protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(0, 0, 0),
                                                                       Color.FromArgb(70, 70, 94),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void GroupBoxPaint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;

            using (LinearGradientBrush brush = new LinearGradientBrush(control.ClientRectangle,
                                                                       Color.FromArgb(71, 95, 94),
                                                                       Color.Black,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, control.ClientRectangle);
                ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }


        public void setWaveFile(string waveFile)
        {
            labelWaveFile.Text = waveFile;
            synthGenerator.LoadWaveFile(waveFile);
            this.Focus();
            labelDataFolder.Select();
        }

        public void UpdateRepeatUI()
        {
            labelRepeatBegin.Text = (synthGenerator.RepeatBegin * 100).ToString("0.0") + " %";
            labelRepeatEnd.Text = (synthGenerator.RepeatEnd * 100).ToString("0.0") + " %";
            pictureBoxRepeat.Invalidate();
        }

        private void pictureBoxRepeat_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                                  new Point(0, 10),
                                                  new Point(pictureBoxRepeat.Width, 10),
                                                  Color.FromArgb(255, 80, 80, 80),
                                                  Color.FromArgb(255, 200, 200, 200));

            Rectangle rect = new Rectangle(0, 0, pictureBoxRepeat.Width, pictureBoxRepeat.Height);
            e.Graphics.FillRectangle(linGrBrush, rect);

            linGrBrush = new LinearGradientBrush(
                                                  new Point(0, 10),
                                                  new Point(pictureBoxRepeat.Width, 10),
                                                  Color.FromArgb(255, 0, 0, 0),     // Opaque black
                                                  Color.FromArgb(255, 255, 0, 0));  // Opaque red

            rect = new Rectangle((int)(pictureBoxRepeat.Width * synthGenerator.RepeatBegin), 0, (int)(pictureBoxRepeat.Width * (synthGenerator.RepeatEnd- synthGenerator.RepeatBegin)), pictureBoxRepeat.Height);
            e.Graphics.FillRectangle(linGrBrush, rect);
/*
            rect = new Rectangle((int)(pictureBoxRepeat.Width * synthGenerator.RepeatEnd), 0, pictureBoxRepeat.Width - (int)(pictureBoxRepeat.Width * synthGenerator.RepeatEnd), pictureBoxRepeat.Height);
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
*/

        }

        private void pictureBoxRepeat_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxRepeat.Cursor = Cursors.VSplit;
            UpdateRepeatValues(e.X);
        }

        private void pictureBoxRepeat_MouseDown(object sender, MouseEventArgs e)
        {
            int splitPoint = (int)(pictureBoxRepeat.Width * (synthGenerator.RepeatBegin + synthGenerator.RepeatEnd) / 2);
            
            if (e.X < splitPoint)
            {
                changingRepeatBegin = true;
            }
            else
            {
                changingRepeatEnd = true;
            }
            UpdateRepeatValues(e.X);
        }

        private void UpdateRepeatValues(int x)
        {
            if (changingRepeatBegin)
            {
                var value = x / (float)pictureBoxRepeat.Width;
                if (value < synthGenerator.RepeatEnd)
                {
                    synthGenerator.RepeatBegin = value;
                    if (synthGenerator.RepeatBegin < 0)
                    {
                        synthGenerator.RepeatBegin = 0;
                    }
                }
            }
            if (changingRepeatEnd)
            {
                var value = x / (float)pictureBoxRepeat.Width;
                if (value > synthGenerator.RepeatBegin)
                {
                    synthGenerator.RepeatEnd = value;
                    if (synthGenerator.RepeatEnd > 1)
                    {
                        synthGenerator.RepeatEnd = 1;
                    }
                }
            }

            UpdateRepeatUI();
        }

        private void pictureBoxRepeat_MouseUp(object sender, MouseEventArgs e)
        {
            changingRepeatBegin = false;
            changingRepeatEnd = false;
        }

        private void gradientButtonSelectWave_Click(object sender, EventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

            formWaves.ShowDialog();
        }

        private void labelWaveFile_MouseMove(object sender, MouseEventArgs e)
        {
            labelWaveFile.Cursor = Cursors.Hand;
        }

        private void labelWaveFile_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void labelWaveFile_MouseUp(object sender, MouseEventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

            formWaves.ShowDialog();
        }

        private void gradientButtonNextWave_Click(object sender, EventArgs e)
        {
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(labelWaveFile.Text)));
            index++;
            if (index> wavefileNames.Count-1)
            {
                index = 0;
            }
            string waveFile = wavefileNames[index];
            setWaveFile(waveFile);
        }

        private void gradientButtonPreviousWave_Click(object sender, EventArgs e)
        {
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(labelWaveFile.Text)));
            index--;
            if (index < 0)
            {
                index = wavefileNames.Count - 1;
            }
            string waveFile = wavefileNames[index];
            setWaveFile(waveFile);
        }

        private void gradientButtonChangeDataFolder_Click(object sender, EventArgs e)
        {
            using (var opnDlg = new FolderBrowserDialog())
            {

                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    synthGenerator.DataFolder = opnDlg.SelectedPath;
                    UpdateWavefilesList();
                    SaveSettings();
                }
            }
        }

        private void labelPreset_Click(object sender, EventArgs e)
        {

        }

        private void gradientButtonAddPreset_Click(object sender, EventArgs e)
        {

        }

        private void gradientButtonPresetSave_Click(object sender, EventArgs e)
        {

        }

        private void gradientButtonPresetDelete_Click(object sender, EventArgs e)
        {

        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Peter Popma\\Rainbow");
            if (key != null)
            {
                synthGenerator.DataFolder = (key.GetValue("DataFolder") == null ? Directory.GetCurrentDirectory() : key.GetValue("DataFolder").ToString());
            }
            else
            {
                synthGenerator.DataFolder = Directory.GetCurrentDirectory();
            }
        }

        private void SaveSettings()
        {
            // Create or get existing subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Peter Popma\\Rainbow");

            key.SetValue("DataFolder", synthGenerator.DataFolder);
        }

        private void labelPreset_MouseMove(object sender, MouseEventArgs e)
        {
            labelPreset.Cursor = Cursors.Hand;
        }
    }
}
