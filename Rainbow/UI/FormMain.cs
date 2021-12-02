using Microsoft.Win32;
using Rainbow.Synth;
using System;
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
        Preset preset = new Preset();
        private string dataFolder = "";
        SynthGenerator synthGenerator;
        bool changingRepeatBegin = false;
        bool changingRepeatEnd = false;
        List<string> wavefileNames = new List<string>();
        string currentWaveFile = "";
        string currentSecondaryWaveFile = "[None]";
        List<PresetItem> presets = new List<PresetItem>();
        PresetItem currentPreset = new PresetItem("Preset1", "");

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
            comboBoxPostProcessing.SelectedIndex = 0;
            panel1.Paint += new PaintEventHandler(GroupBoxPaint);
            LoadPresets();
        }

        /// <summary>
        /// Contains a queue with note-on note numbers currently playing.
        /// </summary>
        internal SynthGenerator SynthGenerator { get => synthGenerator; set => synthGenerator = value; }
        public List<string> WavefileNames { get => wavefileNames; set => wavefileNames = value; }
        internal Preset Preset { get => Preset1; set => Preset1 = value; }
        public PresetItem CurrentPreset { get => currentPreset; set => currentPreset = value; }
        public List<PresetItem> Presets { get => presets; set => presets = value; }
        internal Preset Preset1 { get => preset; set => preset = value; }
        public string DataFolder { get => dataFolder; set => dataFolder = value; }
        public string CurrentWaveFile { get => currentWaveFile; set => currentWaveFile = value; }
        public string CurrentSecondaryWaveFile { get => currentSecondaryWaveFile; set => currentSecondaryWaveFile = value; }

        public void ReloadPresets()
        {
            Presets.Clear();
            currentPreset = new PresetItem("Preset1", "");
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
                        PresetItem presetItem = new PresetItem(name, category);
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

        public void UpdateWavefilesList()
        {
            WavefileNames.Clear();
            // find all wavefiles
            try
            {
                string[] fileEntries = Directory.GetFiles(DataFolder + "\\wavefiles\\");
                foreach (string fileName in fileEntries)
                {
                    if (fileName.EndsWith(".wav"))
                    {

                        string wavefile = fileName.Substring(DataFolder.Length + 11);
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


        public void setWaveFile(string waveFile)
        {
            CurrentWaveFile = labelWaveFile.Text = waveFile;
            synthGenerator.LoadWaveFile(dataFolder, waveFile);
            synthGenerator.UpdateEffects();
            //this.Focus();
            //labelDataFolder.Select();
        }
        public void setSecondaryWaveFile(string waveFile)
        {
            CurrentSecondaryWaveFile = labelSecondary.Text = waveFile;
            synthGenerator.LoadSecondaryWaveFile(dataFolder, waveFile);
            synthGenerator.UpdateEffects();
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

        private void gradientButtonNextWave_Click(object sender, EventArgs e)
        {
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(CurrentWaveFile)));
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
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(CurrentWaveFile)));
            index--;
            if (index < 0)
            {
                index = wavefileNames.Count - 1;
            }
            string waveFile = wavefileNames[index];
            setWaveFile(waveFile);
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
            UpdateRepeatUI();
            labelWaveFile.Text = CurrentWaveFile;
            pictureBoxVolumeShape.Refresh();
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Peter Popma\\Rainbow");
            if (key != null)
            {
                DataFolder = (key.GetValue("DataFolder") == null ? Directory.GetCurrentDirectory() : key.GetValue("DataFolder").ToString());
            }
            else
            {
                DataFolder = Directory.GetCurrentDirectory();
            }
        }

        public void SaveSettings()
        {
            // Create or get existing subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Peter Popma\\Rainbow");

            key.SetValue("DataFolder", DataFolder);
        }

        private void labelPreset_MouseMove(object sender, MouseEventArgs e)
        {
            labelPreset.Cursor = Cursors.Hand;
        }

        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();
            foreach (PresetItem presetItem in Presets)
            {
                if (!categories.Contains(presetItem.Category))
                {
                    categories.Add(presetItem.Category);
                }
            }

            return categories;
        }

        public PresetItem FindPresetByName(string name)
        {
            return Presets.Find(x => x.Name.Equals(name));
        }

        private void labelWaveFile_Click(object sender, EventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

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

        private void pictureBoxRepeat_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownFlattenEffect_ValueChanged(object sender, EventArgs e)
        {
            synthGenerator.EffectOne = (float)numericUpDownEffect1.Value;
            synthGenerator.UpdateEffects();
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
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

            formWaves.ShowDialog();
        }

        private void gradientButtonNextSecondary_Click(object sender, EventArgs e)
        {
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(CurrentSecondaryWaveFile)));
            index++;
            if (index > wavefileNames.Count - 1)
            {
                index = 0;
            }
            string waveFile = wavefileNames[index];
            setSecondaryWaveFile(waveFile);
        }

        private void gradientButtonPreviousSecondary_Click(object sender, EventArgs e)
        {
            int index = wavefileNames.IndexOf(wavefileNames.Find(x => x.Equals(CurrentSecondaryWaveFile)));
            index--;
            if (index < 0)
            {
                index = wavefileNames.Count - 1;
            }
            string waveFile = wavefileNames[index];
            setSecondaryWaveFile(waveFile);
        }

        private void panelBaseSound_MouseClick(object sender, MouseEventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

            formWaves.ShowDialog();

        }

        private void panelSecondarySound_MouseClick(object sender, MouseEventArgs e)
        {
            FormWaves formWaves = new FormWaves();
            formWaves.MyParent = this;
            formWaves.IsSecondary = true;
            Point location = this.PointToScreen(Point.Empty);
            formWaves.Location = new Point(location.X + 10, location.Y + 10);

            formWaves.ShowDialog();
        }

        private void pictureBoxVolumeShape_Click(object sender, EventArgs e)
        {
            FormVolume formVolume = new FormVolume();
            formVolume.MyParent = this;
            formVolume.ShowDialog();
        }

        private void pictureBoxVolumeShape_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxVolumeShape.Cursor = Cursors.Hand;
        }

        private void pictureBoxVolumeShape_Paint(object sender, PaintEventArgs e)
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

            if (synthGenerator.WaveInfo.ShapeVolume.Length == SynthGenerator.SHAPE_NUMPOINTS)
            {
                for (int x = 0; x < pictureBoxVolumeShape.Width; x++)
                {
                    int position = (int)(x / (double)pictureBoxVolumeShape.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    int next_position = (int)((x + 1) / (double)pictureBoxVolumeShape.Width * SynthGenerator.SHAPE_NUMPOINTS);
                    if (next_position < SynthGenerator.SHAPE_NUMPOINTS)
                    {
                        int value1 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume[position]) * (pictureBoxVolumeShape.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        int value2 = (int)((SynthGenerator.SHAPE_MAX_VALUE - synthGenerator.WaveInfo.ShapeVolume[next_position]) * (pictureBoxVolumeShape.Height / (double)SynthGenerator.SHAPE_MAX_VALUE));
                        e.Graphics.DrawLine(pen, new Point(x, value1), new Point(x + 1, value2));
                    }
                }
            }
        }
    }
}
