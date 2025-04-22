using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Github_Demo
{
    public class LeetCode68
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();
            int index = 0;

            while (index < words.Length)
            {
                int totalChars = words[index].Length;
                int last = index + 1;

                // Find how many words can fit in the current line
                while (last < words.Length)
                {
                    if (totalChars + 1 + words[last].Length > maxWidth) break;
                    totalChars += 1 + words[last].Length;
                    last++;
                }

                int gaps = last - index - 1;
                var sb = new StringBuilder();

                // If it's the last line or only one word in the line
                if (last == words.Length || gaps == 0)
                {
                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1) sb.Append(' ');
                    }
                    int remaining = maxWidth - sb.Length;
                    sb.Append(' ', remaining);
                }
                else
                {
                    int totalSpaces = maxWidth - totalChars + gaps;
                    int spacePerGap = totalSpaces / gaps;
                    int extraSpaces = totalSpaces % gaps;

                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1)
                        {
                            int spacesToApply = spacePerGap + (extraSpaces-- > 0 ? 1 : 0);
                            sb.Append(' ', spacesToApply);
                        }
                    }
                }

                result.Add(sb.ToString());
                index = last;
            }

            return result;
        }
    }
}