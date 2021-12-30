using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordSorting;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
        }

        private IList<string> sortedList;
        void Sort()
        {
            var wordList = new List<string>(textBoxWordList.Text.Split('\n'));
            WordSorting.WordSorting.Sort(comboBoxLanguages.SelectedText, wordList);
        }
    }
}
