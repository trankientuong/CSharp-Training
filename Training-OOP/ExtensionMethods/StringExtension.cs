using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputString){
            if (!string.IsNullOrEmpty(inputString))
            {
                //Split the string by a space
                string[] strArray = inputString.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }
}