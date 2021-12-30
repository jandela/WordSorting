using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSorting
{
    public static class WordSorting
    {
        private static CultureInfo language;
        public static List<string> SortedList { get; private set; }

        public static void Sort(string languageName, List<string> textList)
        {
            SelectCulture(languageName);

            if (language == null)
                throw new InvalidOperationException("Language does not exist!");

            var langComp = StringComparer.Create(language, true);
            
            textList.Sort(langComp);
            SortedList = textList;
        }

        private static void SelectCulture(string languageName)
        {
            //select a Language:
            var languages = CultureInfo.GetCultures(CultureTypes.AllCultures);
            language = languages.FirstOrDefault(culture => culture.EnglishName.Contains(languageName));
        }

    }
}
