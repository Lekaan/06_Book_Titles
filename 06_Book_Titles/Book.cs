using System;
using System.Linq;
using System.Text;

namespace _06_Book_Titles
{
    internal class Book
    {
        private String titleValue;
        private String[] blacklist = { "the", "a", "an", "and", "in", "of" };

        public string Title
        {
            set { this.titleValue = StringLoop(value); }
            get { return this.titleValue; }
        }

        private String StringLoop(String input)
        {
            string[] inputArray = input.Split(' ');
            StringBuilder sbInput = new StringBuilder();

            foreach (string word in inputArray)
            {
                if (!blacklist.Contains(word))
                    sbInput.Append(ToUpper(word));
                else
                    sbInput.Append(word).Append(" ");
            }

            return ToUpper(sbInput.ToString()).Trim();
        }

        private String ToUpper(String input)
        {
            return input.First().ToString().ToUpper() + input.Substring(1) + " ";
        }
    }
}
 