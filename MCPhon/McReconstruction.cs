using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MCPhon
{
    public class NotParsableStringException : Exception { }

    public class McReconstruction
    {
        private string fullForm;
        private string fullFinal;
        private string initialConsonant;
        private string finalConsonant;

        public string FullForm
        {
            get { return fullForm; }
            private set { fullForm = value; }
        }

        public string InitialConsonant
        {
            get { return initialConsonant; }
            private set { initialConsonant = value; }
        }

        public string FinalConsonant
        {
            get { return finalConsonant; }
            private set { finalConsonant = value; }
        }

        public string FullFinal
        {
            get { return fullFinal; }
            private set { fullFinal = value; }
        }

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
                fullForm = captures[0] + captures[1];
                initialConsonant = captures[0];
                fullFinal = captures[1];

                char finalChar = captures[1][captures[1].Length - 1];
                finalConsonant = finalChar == 'g' ? "ng" : finalChar.ToString();

                Debug.WriteLine("mcr: " + captures[0] + " " + captures[1]);
            }

            //string initialAlphabet = "'bdghklmnprstxyz";
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
