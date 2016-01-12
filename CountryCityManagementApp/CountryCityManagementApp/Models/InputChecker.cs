using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CountryCityManagementApp.Models
{
    public class InputChecker
    {
        public static string CheckInput(string input) {
            string inputNoWhiteSpace= input.Replace("  ", String.Empty);
            //string removeSpecialChar = RemoveSpecialCharacters(inputNoWhiteSpace);
            //return removeSpecialChar;
            return inputNoWhiteSpace;
        }

        private static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c == 39)
                {
                    sb.Append(c);
                }
                else
                {
                    if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
                    {
                        sb.Append(c);
                    }
                }

            }
            return sb.ToString();
        }
    }
}