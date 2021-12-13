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
    internal sealed partial class FormAddPreset : Form
    {
        private FormMain myParent = null;

        public FormMain MyParent { get => myParent; set => myParent = value; }
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FormAddPreset()
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


        private void gradientButtonAdd_Click(object sender, EventArgs e)
        {
            if (myParent.FindPresetByName(textBoxPresetName.Text) != null)
            {
                MessageBox.Show("Preset does already exist!");
            }
            string category = comboBoxCategories.Text;
            if (category.Length == 0)
            {
                category = "[default]";
            }
            if (textBoxPresetName.Text.Length > 0)
            {
                CategoryItem presetItem = new CategoryItem(textBoxPresetName.Text, category);
                myParent.Presets.Add(presetItem);
                myParent.CurrentPreset = presetItem;
                myParent.labelPreset.Text = presetItem.Name;
                myParent.Preset.Save(myParent, myParent.SynthGenerator, presetItem);

                textBoxPresetName.Text = "";
            }
            Close();
        }

        private void gradientButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddPreset_Load(object sender, EventArgs e)
        {
            comboBoxCategories.Items.Clear();
            List<string> categories = myParent.GetAllPresetCategories();
            comboBoxCategories.Items.AddRange(categories.ToArray());
        }
    }
}
