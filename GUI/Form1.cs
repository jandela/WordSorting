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
            //TODO Resolve a bug: two words are connected to one word
            WordSorting.WordSorting.Sort(comboBoxLanguages.SelectedText, wordList);

            sortedList = WordSorting.WordSorting.SortedList;

            //TODO Find a better way to do this
            string sortedText = "";
            foreach (var word in sortedList)
            {
                if (sortedText.Length == 0)
                {
                    sortedText = word + "\n";
                    continue;
                }

                sortedText += (word+"\n");
            }

            textBoxSortedList.Text = sortedText;

            buttonClear.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSortedList.Clear();
            buttonClear.Enabled = false;
        }
    }
}
