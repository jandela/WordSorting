using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChoice : Form
    {
        public FormChoice()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxFile.Text = this.openFileDialog.FileName;
                // Load data to main text box
                Hide();
            }
        }

        private void FormChoice_Load(object sender, EventArgs e)
        {
            // Enable Main form
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("File"))
            {
                groupBoxPath.Enabled = true;
            }
            else
            {
                groupBoxPath.Enabled = false;
                // Enable Main form
                Hide();
            }
        }
    }
}
