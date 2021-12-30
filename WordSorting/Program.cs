using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = new List<string>();
            text.Add("hello");
            text.Add("What");
            text.Add("Ciao");
            text.Add("Bok");
            text.Add("who");
            text.Add("tko");
            text.Add("što");
            text.Add("casa");
            text.Add("where");
            text.Add("bus");
            text.Add("house");

            var language = "Croatian";

            var sort = new WordSorting();
            sort.Sort(language, text);

            Console.ReadKey(false);
        }
    }
}
