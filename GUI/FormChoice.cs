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

        public delegate void SendPathHandler(object sender, string path);
        public event SendPathHandler ChoiceMade;
        public event EventHandler CloseMainForm;

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog.FileName;
                EnableMainForm(textBoxFile.Text);
                Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoice.SelectedItem.Equals("File"))
            {
                groupBoxPath.Enabled = true;
            }
            else if (comboBoxChoice.SelectedItem.Equals("Manual"))
            {
                groupBoxPath.Enabled = false;
                EnableMainForm(null);
                Hide();
            }
        }

        private void EnableMainForm(string path)
        {
            if (ChoiceMade != null)
                ChoiceMade(this, path);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            
            if (CloseMainForm != null)
                CloseMainForm(this, EventArgs.Empty);

        }
    }
}
