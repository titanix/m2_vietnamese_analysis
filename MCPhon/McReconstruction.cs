using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MCPhon
{
    public class NotParsableStringException : Exception { }

    public class McReconstruction
    {
        // nécessite une chaîne de la forme (initiale- + -finale ton)
        // ex : (ng- + -aw A)
        public McReconstruction(string str)
        {
            string[] captures = ExtractPattern(str, @"\(([\w']+)- \+ -(\w+) [ABCD]\)$");

            if (captures.Length < 2)
            {
                throw new NotParsableStringException();
            }
            else
            {
                Debug.WriteLine("mcr: " + captures[0] + " " + captures[1]);
            }      
        }

        // renvoie un groupe de chaînes de caractères correspondant au groupe matché par une expression régulière
        private string[] ExtractPattern(string str, string pattern)
        {
            List<string> result = new List<string>();
            Regex regex = new Regex(pattern);
            Match m = regex.Match(str);
            if (m.Success)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    result.Add(m.Groups[i].Value);
                }
            }
            return result.ToArray();
        }
    }
}
