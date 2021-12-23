using Jacobi.Vst.Core;
using Microsoft.Win32;
using Rainbow.Synth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Rainbow.UI
{
    /// <summary>
    /// The plugin custom editor UI.
    /// </summary>
    internal sealed partial class FormMain : UserControl
    {
        Preset preset = new Preset();
        private string dataFolder = "";
        SynthGenerator synthGenerator;
        bool changingRepeatBegin = false;
        bool changingRepeatEnd = false;
        bool changingDuration = false;
        CategoryItem currentWaveFile1;
        CategoryItem currentWaveFile2;
        List<CategoryItem> waveFiles = new List<CategoryItem>();
        List<CategoryItem> presets = new List<CategoryItem>();
        CategoryItem currentPreset = new CategoryItem("Preset1", "");

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            SynthGenerator.Initialize();
            LoadSettings();
            UpdateWavefilesList();
            UpdateRepeatUI();
            panel1.Paint += new PaintEventHandler(GroupBoxPaint);
            LoadPresets();
            UpdateMixMode();
            UpdateStretchMode();
        }

        /// <summary>
        /// Contains a queue with note-on note numbers currently playing.
        /// </summary>
        internal SynthGenerator SynthGenerator { get => synthGenerator; set => synthGenerator = value; }
        internal Preset Preset { get => Preset1; set => Preset1 = value; }
        public CategoryItem CurrentPreset { get => currentPreset; set => currentPreset = value; }
        public List<CategoryItem> Presets { get => presets; set => presets = value; }
        internal Preset Preset1 { get => preset; set => preset = value; }
        public string DataFolder { get => dataFolder; set => dataFolder = value; }
        public CategoryItem CurrentWaveFile1 { get => currentWaveFile1; set => currentWaveFile1 = value; }
        public CategoryItem CurrentWaveFile2 { get => currentWaveFile2; set => currentWaveFile2 = value; }
        public List<CategoryItem> WaveFiles { get => waveFiles; set => waveFiles = value; }

        public void ReloadPresets()
        {
            Presets.Clear();
            currentPreset = new CategoryItem("Preset1", "");
            LoadPresets();
        }

        public void LoadPresets()
        {
            // find all presets
            try
            {
                string[] fileEntries = Directory.GetFiles(DataFolder + "\\presets\\");
                foreach (string fileName in fileEntries)
                {
                    if (fileName.EndsWith(".pst"))
                    {
                        string name = fileName.Substring(DataFolder.Length+9, fileName.Length - DataFolder.Length - 13);
                        string category = Preset.ReadCategory(dataFolder, name);
                        CategoryItem presetItem = new CategoryItem(name, category);
                        Presets.Add(presetItem);
                        if (currentPreset.Name.Equals("Preset1"))        // set first preset
                        {
                            currentPreset = presetItem;
                            Preset.Load(this, SynthGenerator, dataFolder, name);
                        }
                    }
                }
                labelPreset.Text = currentPreset.Name;

            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory(DataFolder + "\\presets");
            }
        }

        public void setWaveFile1(string name, string category)
        {
            CategoryItem item = WaveFiles.Find(x => x.Name.Equals(name) && x.Category.Equals(category));
            if (item!=null)
            {
                CurrentWaveFile1 = item;
            }
            else
            {
                int error = 1;
            }
        }

        public void setWaveFile2(string name, string category)
        {
            CategoryItem item = WaveFiles.Find(x => x.Name.Equals(name) && x.Category.Equals(category));
            if (item != null)
            {
                CurrentWaveFile2 = item;
            }
            else
            {
                int error = 1;
            }
        }

        public void UpdateWavefilesList()
        {
            waveFiles.Clear();
            // find all wavefiles
            try
            {
                string[] fileEntries = Directory.GetFiles(DataFolder + "\\wavefiles\\");
                foreach (string fileName in fileEntries)
                {
                    if (fileName.EndsWith(".wav"))
                    {

                        string wavefile = fileName.Substring(DataFolder.Length + 11);
                        wavefile = wavefile.Substring(0, wavefile.Length - 4);
                        waveFiles.Add(new CategoryItem(wavefile, "[none]"));
                    }
                }

                string[] directories = Directory.GetDirectories(DataFolder + "\\wavefiles\\");
                foreach (string directory in directories) {
                    string dirname = directory.Substring(DataFolder.Length + 11);
                    fileEntries = Directory.GetFiles(directory + "\\");
                    foreach (string fileName in fileEntries)
                    {
                        if (fileName.EndsWith(".wav"))
                        {
                            string wavefile = fileName.Substring(directory.Length + 1);
                            wavefile = wavefile.Substring(0, wavefile.Length - 4);
                            waveFiles.Add(new CategoryItem(wavefile, dirname));
                        }
                    } 
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory("wavefiles");
            }

            if (waveFiles.Count>0)
            {
                setWaveFile1(waveFiles[0]);
                setWaveFile2(waveFiles[0]);
            }
            if (waveFiles.Count > 1)
            {
                setWaveFile2(waveFiles[1]);
            }
        }

         protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(0, 0, 0),
                                                                       Color.FromArgb(80, 80, 104),
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

        private string GetWaveFileName(CategoryItem waveFile)
        {
            if(waveFile.Category.Equals("[none]"))
                return dataFolder + "\\wavefiles\\" + waveFile.Name + ".wav";
            else
                return dataFolder + "\\wavefiles\\" + waveFile.Category + "\\" + waveFile.Name + ".wav";
        }

        public void setWaveFile1(CategoryItem waveFile)
        {
            CurrentWaveFile1 = waveFile;
            labelWaveFile.Text = CurrentWaveFile1.Name;

            synthGenerator.LoadWaveFile(GetWaveFileName(waveFile), 1);
            UpdateStretchMode();
            //this.Focus();
            //labelDataFolder.Select();
        }
        public void setWaveFile2(CategoryItem waveFile)
        {
            CurrentWaveFile2 = waveFile;
            labelSecondary.Text = CurrentWaveFile2.Name;
            synthGenerator.LoadWaveFile(GetWaveFileName(waveFile), 2);
            UpdateStretchMode();
        }

        public void UpdateRepeatUI()
        {
            labelRepeatBegin.Text = (synthGenerator.RepeatBegin * 100).ToString("0.0") + " %";
            labelRepeatEnd.Text = (synthGenerator.RepeatEnd * 100).ToString("0.0") + " %";
            pictureBoxRepeat.Invalidate();
        }

        public void UpdateDurationUI()
        {
            labelDuration.Text = synthGenerator.Duration.ToString("0.000");
            pictureBoxDuration.Invalidate();
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
                UpdateRepeatUI();
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
                UpdateRepeatUI();
            }
        }

        private void UpdateDurationValue(int x)
        {
            if (changingDuration && x >= pictureBoxDuration.Width/20.0 && x <= pictureBoxDuration.Width)
            {
                synthGenerator.Duration = synthGenerator.MaxDuration * (x / (float)pictureBoxDuration.Width);
                synthGenerator.UpdateEffects();
                UpdateDurationUI();
            }
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

        private void gradientButtonNextWave_Click(object sender, EventArgs e)
        {
            int index = WaveFiles.IndexOf(WaveFiles.Find(x => x.Equals(CurrentWaveFile1)));
            index++;
            if (index> WaveFiles.Count-1)
            {
                index = 0;
            }
            CategoryItem waveFile = waveFiles[index];
            setWaveFile1(waveFile);
        }

        private void gradientButtonPreviousWave_Click(object sender, EventArgs e)
        {
            int index = WaveFiles.IndexOf(WaveFiles.Find(x => x.Equals(CurrentWaveFile1)));
            index--;
            if (index < 0)
            {
                index = WaveFiles.Count - 1;
            }
            CategoryItem waveFile = waveFiles[index];
            setWaveFile1(waveFile);
        }

        private void labelPreset_Click(object sender, EventArgs e)
        {
            FormPresets formPresets = new FormPresets();
            formPresets.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formPresets.Location = new Point(location.X + 10, location.Y + 10);

            formPresets.ShowDialog();
        }

        private void gradientButtonAddPreset_Click(object sender, EventArgs e)
        {
            FormAddPreset formAddPreset = new FormAddPreset();
            formAddPreset.MyParent = this;
            formAddPreset.ShowDialog();
        }

        private void gradientButtonPresetSave_Click(object sender, EventArgs e)
        {
            if (CurrentPreset != null && CurrentPreset.Name.Length > 0)
            {
                Preset.Save(this, synthGenerator, CurrentPreset);
            }
        }

        private void gradientButtonPresetDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Preset?", "Delete Preset", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Preset.Delete(labelPreset.Text);
                Presets.Remove(FindPresetByName(labelPreset.Text));
                if (Presets.Count > 0)
                {
                    Preset.Load(this, synthGenerator, dataFolder, Presets[0].Name);
                    labelPreset.Text = Presets[0].Name;
                }
            }
        }

        public void SetPreset(string name)
        {
            CurrentPreset = FindPresetByName(name);
            
            try
            {
                Preset.Load(this, SynthGenerator, DataFolder, name);
            }
            catch (Exception)
            {

            }
        }

        public void UpdatePresetControls()
        {
            labelPreset.Text = CurrentPreset.Name;
            setWaveFile1(CurrentWaveFile1);
            setWaveFile2(CurrentWaveFile2);
            UpdateRepeatUI();
            pictureBoxVolume1.Refresh();
            pictureBoxVolume2.Refresh();
            UpdateMixMode();
            checkBoxInvert1.Checked = synthGenerator.WaveInfo.Inverted1;
            checkBoxInvert2.Checked = synthGenerator.WaveInfo.Inverted2;
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Peter Popma\\Rainbow");
            if (key != null)
            {
                DataFolder = (key.GetValue("DataFolder") == null ? Directory.GetCurrentDirectory() : key.GetValue("DataFolder").ToString());
                synthGenerator.SamplesPerSecondOutput = key.GetValue("SamplesPerSecond") == null ? 44100 : Convert.ToInt32(key.GetValue("SamplesPerSecond"));
                synthGenerator.BitsPerSample = key.GetValue("BitsPerSample") == null ? 32 : Convert.ToInt32(key.GetValue("BitsPerSample"));
            }
            else
            {
                DataFolder = Directory.GetCurrentDirectory();
                synthGenerator.SamplesPerSecondOutput = 44100;
                synthGenerator.BitsPerSample = 32;
            }
        }

        public void SaveSettings()
        {
            // Create or get existing subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Peter Popma\\Rainbow");

            key.SetValue("DataFolder", DataFolder);
            key.SetValue("SamplesPerSecond", synthGenerator.SamplesPerSecondOutput);
            key.SetValue("BitsPerSample", synthGenerator.BitsPerSample);
        }

        private void labelPreset_MouseMove(object sender, MouseEventArgs e)
        {
            labelPreset.Cursor = Cursors.Hand;
        }

        public List<string> GetAllPresetCategories()
        {
            List<string> categories = new List<string>();
            foreach (CategoryItem presetItem in Presets)
            {
                if (!categories.Contains(presetItem.Category))
                {
                    categories.Add(presetItem.Category);
                }
            }

            return categories;
        }
        public List<string> GetAllWaveFileCategories()
        {
            List<string> categories = new List<string>();
            foreach (CategoryItem presetItem in WaveFiles)
            {
                if (!categories.Contains(presetItem.Category) && !presetItem.Category.Equals("[none]"))
                {
                    categories.Add(presetItem.Category);
                }
            }

            return categories;
        }

        public CategoryItem FindPresetByName(string name)
        {
            return Presets.Find(x => x.Name.Equals(name));
        }

        private void labelWaveFile_Click(object sender, EventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 1, location.Y + 1);

            formWaves.ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.MyParent = this;
            formSettings.ShowDialog();
        }

        private void gradientButtonNextPreset_Click(object sender, EventArgs e)
        {
            int index = presets.IndexOf(presets.Find(x => x.Equals(CurrentPreset)));
            index++;
            if (index > presets.Count - 1)
            {
                index = 0;
            }
            string currentPreset = presets[index].Name;
            SetPreset(currentPreset);
        }

        private void gradientButtonPreviousPreset_Click(object sender, EventArgs e)
        {
            int index = presets.IndexOf(presets.Find(x => x.Equals(CurrentPreset)));
            index--;
            if (index < 0)
            {
                index = presets.Count - 1;
            }
            string currentPreset = presets[index].Name;
            SetPreset(currentPreset);
        }


        private void labelSecondary_MouseMove(object sender, MouseEventArgs e)
        {
            labelSecondary.Cursor = Cursors.Hand;
        }

        private void labelSecondary_Click(object sender, EventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            formWaves.IsSecondary = true;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 1, location.Y + 1);

            formWaves.ShowDialog();
        }

        private void gradientButtonNextSecondary_Click(object sender, EventArgs e)
        {
            int index = WaveFiles.IndexOf(WaveFiles.Find(x => x.Equals(CurrentWaveFile2)));
            index++;
            if (index > WaveFiles.Count - 1)
            {
                index = 0;
            }
            CategoryItem waveFile = waveFiles[index];
            setWaveFile2(waveFile);
        }

        private void gradientButtonPreviousSecondary_Click(object sender, EventArgs e)
        {
            int index = WaveFiles.IndexOf(WaveFiles.Find(x => x.Equals(CurrentWaveFile2)));
            index--;
            if (index < 0)
            {
                index = WaveFiles.Count - 1;
            }
            CategoryItem waveFile = waveFiles[index];
            setWaveFile2(waveFile);
        }

        private void panelBaseSound_MouseClick(object sender, MouseEventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 1, location.Y + 1);

            formWaves.ShowDialog();

        }

        private void panelSecondarySound_MouseClick(object sender, MouseEventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            formWaves.IsSecondary = true;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 1, location.Y + 1);

            formWaves.ShowDialog();
        }

        private void pictureBoxVolume1_Click(object sender, EventArgs e)
        {
            FormVolume formVolume = new FormVolume();
            formVolume.MyParent = this;
            formVolume.IsSecondarySound = false;
            formVolume.ShowDialog();
        }

        private void pictureBoxVolume1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxVolume1.Cursor = Cursors.Hand;
        }

        private void pictureBoxVolume1_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            using (LinearGradientBrush brush = new LinearGradientBrush(control.ClientRectangle,
                                                                       Color.FromArgb(70, 87, 195),
                                                                       Color.FromArgb(0, 0, 15),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, control.ClientRectangle);
                ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
            }

            Pen pen = new Pen(Color.White);

            if (synthGenerator.WaveInfo.ShapeVolume1.Length == SynthGenerator.SHAPE_NUMPOINTS)
            {
                for (int x = 0; x < pictureBoxVolume1.Width; x++)
                {
                    int position = (int)(x / (double)pictureBoxVolume1.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    int next_position = (int)((x + 1) / (double)pictureBoxVolume1.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    if (next_position < SynthGenerator.SHAPE_NUMPOINTS)
                    {
                        int value1 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume1[position]) * (pictureBoxVolume1.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        int value2 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume1[next_position]) * (pictureBoxVolume1.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        e.Graphics.DrawLine(pen, new Point(x, value1), new Point(x + 1, value2));
                    }
                }
            }
        }

        private void panelBaseSound_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSecondarySound_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxVolume2_Click(object sender, EventArgs e)
        {
            FormVolume formVolume = new FormVolume();
            formVolume.IsSecondarySound = true;
            formVolume.MyParent = this;
            formVolume.ShowDialog();
        }

        private void pictureBoxVolume2_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            using (LinearGradientBrush brush = new LinearGradientBrush(control.ClientRectangle,
                                                                       Color.FromArgb(70, 87, 195),
                                                                       Color.FromArgb(0, 0, 15),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, control.ClientRectangle);
                ControlPaint.DrawBorder(e.Graphics, control.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
            }

            Pen pen = new Pen(Color.White);

            if (synthGenerator.WaveInfo.ShapeVolume2.Length == SynthGenerator.SHAPE_NUMPOINTS)
            {
                for (int x = 0; x < pictureBoxVolume2.Width; x++)
                {
                    int position = (int)(x / (double)pictureBoxVolume2.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    int next_position = (int)((x + 1) / (double)pictureBoxVolume2.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    if (next_position < SynthGenerator.SHAPE_NUMPOINTS)
                    {
                        int value1 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume2[position]) * (pictureBoxVolume2.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        int value2 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume2[next_position]) * (pictureBoxVolume2.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        e.Graphics.DrawLine(pen, new Point(x, value1), new Point(x + 1, value2));
                    }
                }
            }
        }

        private void pictureBoxVolume2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxVolume2.Cursor = Cursors.Hand;
        }

        private void pictureBoxMixMode_Click(object sender, EventArgs e)
        {
            FormStretchMode formStretchMode = new FormStretchMode();
            formStretchMode.MyParent = this;
            formStretchMode.ShowDialog();
        }

        private void gradientButtonNextMixMode_Click(object sender, EventArgs e)
        {
            synthGenerator.MixMode++;
            if (synthGenerator.MixMode>5)
            {
                synthGenerator.MixMode = 0;
            }
            UpdateMixMode();
        }

        public void UpdateMixMode()
        {
            switch(synthGenerator.MixMode)
            {
                case 0:
                    labelMixMode.Text = "Fade in - Fade out";
                    pictureBoxMixMode.Image = Properties.Resources.fadeinfadeout;
                    break;
                case 1:
                    labelMixMode.Text = "Both same weight";
                    pictureBoxMixMode.Image = Properties.Resources.sameweight;
                    break;
                case 2:
                    labelMixMode.Text = "Multiply 1 by 2";
                    pictureBoxMixMode.Image = Properties.Resources.multiply;
                    break;
                case 3:
                    labelMixMode.Text = "Alternate Square (" + synthGenerator.NumMixWaves + "x)";
                    pictureBoxMixMode.Image = Properties.Resources.alternatesquare;
                    break;
                case 4:
                    labelMixMode.Text = "Alternate Triangle (" + synthGenerator.NumMixWaves + "x)";
                    pictureBoxMixMode.Image = Properties.Resources.alternatetriangle;
                    break;
                case 5:
                    labelMixMode.Text = "Alternate Sine (" + synthGenerator.NumMixWaves + "x)";
                    pictureBoxMixMode.Image = Properties.Resources.alternatesine;
                    break;
            }
            synthGenerator.UpdateEffects();
        }

        public void UpdateStretchMode()
        {
            switch (synthGenerator.StretchMode)
            {
                case 0:
                    labelStretchMode.Text = "Overlapping";
                    pictureBoxStretchMode.Image = Properties.Resources.overlap;
                    break;
                case 1:
                    labelStretchMode.Text = "Repeat smallest";
                    pictureBoxStretchMode.Image = Properties.Resources.repeatsmallest;
                    break;
                case 2:
                    labelStretchMode.Text = "Stretch to Largest";
                    pictureBoxStretchMode.Image = Properties.Resources.stretchtolargest;
                    break;
                case 3:
                    labelStretchMode.Text = "Shrink to Smallest";
                    pictureBoxStretchMode.Image = Properties.Resources.shrinktosmallest;
                    break;
            }
            synthGenerator.UpdateSoundBufferSize();
            pictureBoxDuration.Refresh();
            labelDuration.Text = synthGenerator.Duration.ToString("0.000");
        }

        private void gradientButtonPreviousMixMode_Click(object sender, EventArgs e)
        {
            synthGenerator.MixMode--;
            if (synthGenerator.MixMode < 0)
            {
                synthGenerator.MixMode = 5;
            }
            UpdateMixMode();
        }

        private void gradientButtonPreviousStretchMode_Click(object sender, EventArgs e)
        {
            synthGenerator.StretchMode--;
            if (synthGenerator.StretchMode < 0)
            {
                synthGenerator.StretchMode = 3;
            }
            UpdateStretchMode();
        }

        private void gradientButtonNextStretchMode_Click(object sender, EventArgs e)
        {
            synthGenerator.StretchMode++;
            if (synthGenerator.StretchMode > 3)
            {
                synthGenerator.StretchMode = 0;
            }
            UpdateStretchMode();
        }

        private void pictureBoxDuration_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                      new Point(0, 10),
                                      new Point(pictureBoxDuration.Width, 10),
                                      Color.FromArgb(255, 80, 80, 80),
                                      Color.FromArgb(255, 200, 200, 200));

            Rectangle rect = new Rectangle(0, 0, pictureBoxDuration.Width, pictureBoxDuration.Height);
            e.Graphics.FillRectangle(linGrBrush, rect);

            linGrBrush = new LinearGradientBrush(
                                                  new Point(0, 10),
                                                  new Point(pictureBoxDuration.Width, 10),
                                                  Color.FromArgb(255, 0, 0, 0),     // Opaque black
                                                  Color.FromArgb(255, 255, 0, 0));  // Opaque red

            rect = new Rectangle(0, 0, (int)(pictureBoxDuration.Width * (synthGenerator.Duration / synthGenerator.MaxDuration)), pictureBoxDuration.Height);
            e.Graphics.FillRectangle(linGrBrush, rect);
        }

        private void checkBoxInvert1_CheckedChanged(object sender, EventArgs e)
        {
            synthGenerator.WaveInfo.Inverted1 = checkBoxInvert1.Checked;
        }

        private void checkBoxInvert2_CheckedChanged(object sender, EventArgs e)
        {
            synthGenerator.WaveInfo.Inverted2 = checkBoxInvert2.Checked;
        }

        private void pictureBoxDuration_MouseDown(object sender, MouseEventArgs e)
        {
            changingDuration = true;
            UpdateDurationValue(e.X);
        }

        private void pictureBoxDuration_MouseUp(object sender, MouseEventArgs e)
        {
            changingDuration = false;
        }

        private void pictureBoxDuration_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxDuration.Cursor = Cursors.VSplit;
            UpdateDurationValue(e.X);
        }

        private void pictureBoxMixMode_Click_1(object sender, EventArgs e)
        {
            FormMixMode formMixMode = new FormMixMode();
            formMixMode.MyParent = this;
            formMixMode.ShowDialog();
        }

        private void checkBoxInvert1_MouseUp(object sender, MouseEventArgs e)
        {
            synthGenerator.UpdateEffects();
        }

        private void checkBoxInvert2_MouseUp(object sender, MouseEventArgs e)
        {
            synthGenerator.UpdateEffects();
        }

        private void buttonPlay1_Click(object sender, EventArgs e)
        {
           
            SoundPlayer wavFile = new SoundPlayer(GetWaveFileName(currentWaveFile1));
            wavFile.Play();
        }

        private void buttonPlay2_Click(object sender, EventArgs e)
        {
            SoundPlayer wavFile = new SoundPlayer(GetWaveFileName(currentWaveFile2));
            wavFile.Play();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "Wave file|*.wav";
            saveFileDialog1.Title = "Save to .wav file";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                synthGenerator.Save(saveFileDialog1.FileName);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            synthGenerator.Play();
        }
    }
}
