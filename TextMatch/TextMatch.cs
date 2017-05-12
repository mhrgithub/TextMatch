using System;

namespace TextMatch
{
    public class TextMatch
    {
        public static string Find(string text, string subText)
        {
            var output = string.Empty;
            var subTextLength = subText.Length;
            var index = 1;
            var tempWord = string.Empty;

            while ((index + subTextLength - 1) <= text.Length)
            {
                for (var i = index - 1; i < index + subTextLength - 1; i++)
                {
                    tempWord += text[i];
                }

                if (string.Equals(tempWord, subText, StringComparison.CurrentCultureIgnoreCase))
                {
                    output += index + ",";
                }

                index++;
                tempWord = string.Empty;
            }

            return output.Trim(',');
        }
    }
}
