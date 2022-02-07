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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Languages = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            IEnumerable<string> allCultures = Languages.Select(lang => lang.EnglishName);
            var languageList = from lang in allCultures
                               orderby lang
                               select lang;

            this.comboBoxLanguages.Items.AddRange(languageList.ToArray());
        }

        private readonly CultureInfo[] Languages;
        private CultureInfo language;
        private List<string> sortedList;

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (textBoxWordList.Text.Length == 0)
                MessageBox.Show("Text is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Sort();
        }

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSort.Enabled = true;
        }

        void Sort()
        {
            List<string> wordList = GetInputList();

            SortListByLanguage(comboBoxLanguages.SelectedItem.ToString(), wordList);

            textBoxSortedList.Text = string.Join(Environment.NewLine, sortedList);

            buttonClear.Enabled = true;
        }

        
        private List<string> GetInputList()
        {
            var wordList = new List<string>(textBoxWordList.Text.Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries));
            
            return wordList;
        }

        private void SortListByLanguage(string languageName, List<string> textList)
        {
            SelectCulture(languageName);
            sortedList = textList;

            var langComp = StringComparer.Create(language, true);

            sortedList.Sort(langComp);
        }

        private void SelectCulture(string languageName)
        {
            //select a Language:
            language = Languages.FirstOrDefault(x => x.EnglishName.Equals(languageName));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSortedList.Clear();
            buttonClear.Enabled = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormChoice sourceChoice = new FormChoice();
            sourceChoice.Location = this.Location;
            sourceChoice.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ClearForm();
            // Show Initial Form (form choice)
        }

        private void ClearForm()
        {
            textBoxWordList.Clear();
            textBoxSortedList.Clear();
            buttonClear.Enabled = false;
            buttonSort.Enabled = false;
            Enabled = false;
        }
    }
}
