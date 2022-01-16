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

        private static CultureInfo language;
        private static List<string> sortedList;

        void Sort()
        {
            List<string> wordList = GetInputList();

            SortListByLanguage(comboBoxLanguages.SelectedText, wordList);

            textBoxSortedList.Text = string.Join("\n", sortedList);

            buttonClear.Enabled = true;
        }

        private List<string> GetInputList()
        {
            var wordList = new List<string>(textBoxWordList.Text.Split('\n'));

            // Check if the last element has \r. If not, add it.
            var lastElement = wordList.Last();
            if (!lastElement.Contains('\r'))
            {
                wordList.RemoveAt(wordList.Count - 1);
                wordList.Add(lastElement + "\r");
            }

            return wordList;
        }

        public static void SortListByLanguage(string languageName, List<string> textList)
        {
            SelectCulture(languageName);
            sortedList = textList;

            if (language == null)
                throw new InvalidOperationException("Language does not exist!");

            var langComp = StringComparer.Create(language, true);

            sortedList.Sort(langComp);
        }

        private static void SelectCulture(string languageName)
        {
            //select a Language:
            var languages = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach(var culture in languages)
            {
                if (culture.EnglishName.Contains(languageName))
                    language = culture;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSortedList.Clear();
            buttonClear.Enabled = false;
        }
    }
}
