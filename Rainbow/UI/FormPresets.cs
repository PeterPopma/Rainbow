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


        private void MapNoteDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
            }
        }


        private void gradientButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void presetbutton_Click(object sender, EventArgs e)
        {
            GradientButton2 myButton = (GradientButton2)sender;
            Cursor = Cursors.WaitCursor;
            myParent.SetPreset(myButton.Text);
            Cursor = Cursors.Default;
            Close();
        }

        private void FormPresets_Load(object sender, EventArgs e)
        {
            List<string> categories = myParent.GetAllCategories();
            int x = 20;
            int[] y = new int[] { 20, 20 };
            for (int i = 0; i < categories.Count; i++)
            {
                string category = categories[i];
                int x_offset = i % 2 * (Width / 2);
                Label label = new Label();
                label.BackColor = Color.FromArgb(0, 0, 0, 0);
                label.ForeColor = Color.FromArgb(192, 192, 255);
                label.Font = new Font("Serif", 16, FontStyle.Bold);
                label.Text = category;
                label.Left = x + x_offset;
                label.Top = y[i % 2];
                label.Height = 30;
                label.Width = Width / 2 - 40;
                Controls.Add(label);
                y[i % 2] += label.Height + 4;
                foreach (PresetItem presetItem in myParent.Presets)
                {
                    if (presetItem.Category.Equals(category))
                    {
                        if (x > Width / 2 - 150)       // next row of presets
                        {
                            y[i % 2] += 30;
                            x = 20;
                        }
                        GradientButton2 button = new GradientButton2();
                        button.Left = x + x_offset;
                        button.Top = y[i % 2];
                        button.Text = presetItem.Name;
                        button.Width = 120;
                        button.ForeColor = Color.White;
                        button.Font = new Font("Serif", 8.25f, FontStyle.Bold);
                        button.FlatStyle = FlatStyle.Standard;
                        button.Click += new EventHandler(presetbutton_Click);
                        Controls.Add(button);
                        x += button.Width + 8;
                    }
                }
                x = 20;
                y[i % 2] += 40;
            }
        }
    }
}
