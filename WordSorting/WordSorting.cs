using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSorting
{
    public class WordSorting
    {
        private CultureInfo language; 
        public void Sort(string languageName, List<string> textList)
        {
            SelectCulture(languageName);

            if (language == null)
                throw new InvalidOperationException("Language does not exist!");

            var langComp = StringComparer.Create(language, true);
            
            textList.Sort(langComp);

            Display(textList, language.EnglishName);
        }

        private void SelectCulture(string languageName)
        {
            //select a Language:
            var languages = CultureInfo.GetCultures(CultureTypes.AllCultures);
            language = languages.FirstOrDefault(culture => culture.EnglishName.Contains(languageName));
        }

        private void Display(List<string> textList, string language)
        {
            Console.WriteLine(language);
            foreach (var line in textList)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }

    }
}
