using System;
using System.Windows.Forms;

namespace Rainbow.UI
{
    /// <summary>
    /// A form that allows the user to edit the details of a note map item.
    /// </summary>
    internal sealed partial class MapNoteDetails : Form
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MapNoteDetails()
        {
            InitializeComponent();
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
    }
}
