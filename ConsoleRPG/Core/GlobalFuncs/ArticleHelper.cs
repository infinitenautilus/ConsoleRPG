using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.GlobalFuncs
{
    public static class ArticleHelper
    {
        public static string GetArticle(string word)
        {
            if(string.IsNullOrEmpty(word))
            {
                return "a ";
            }

            char firstLetter = char.ToLower(word[0]);

            switch(firstLetter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "an ";
                default:
                    return "a ";
            }
        }
    }
}
