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
            
            if (wordList == null || wordList.Count == 0)
                throw new InvalidOperationException("List is empty!");

            //select a Language:
            var languages = CultureInfo.GetCultures( CultureTypes.AllCultures);
            var language = languages.FirstOrDefault(culture => culture.EnglishName.Contains(comboBoxLanguages.SelectedText));
            //CultureInfo languageInfo = new CultureInfo(comboBoxLanguages.Text);
            if (language == null)
                throw new InvalidOperationException("Language does not exist!");
            StringComparer languageComp = StringComparer.Create(language, true);

            //foreach (var line in textBoxWordList.Text)
            //{

            //}
        }
    }
}
