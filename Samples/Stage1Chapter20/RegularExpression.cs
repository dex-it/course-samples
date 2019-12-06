using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Stage1Chapter20
{
    public class RegularExpression
    {
        public bool IsEmail(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public void IsEmailInfo(bool val)
        {
            if (val)
            {
                Console.WriteLine("Email подтвержден");
            }
            else
            {
                Console.WriteLine("Некорректный email");
            }
            Console.ReadLine();
        }

        public List <string> NumberExpression(string strExp)
        {
            List<string> listNumExp = new List<string>();
            
            string pattern = @"([0-9.](\w*))";

            foreach (Match match in Regex.Matches(strExp, pattern)) 
            {
                if (Regex.IsMatch(strExp, pattern))
                {
                    listNumExp.Add(match.Groups[0].Value);
                }
            }
            return listNumExp;
        }

    }
}
