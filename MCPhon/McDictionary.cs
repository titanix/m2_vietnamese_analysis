using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

namespace MCPhon
{
    /// <summary>
    /// Cette classe implmémente un dicitonnaire qui associe à un caractère chinois (char) un objet McReconstruction.
    /// </summary>
    public class McDictionary
    {
        private Dictionary<char, McReconstruction> dictionary = new Dictionary<char, McReconstruction>();

        public McDictionary()
        {
            using (StreamReader sr = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("MCPhon.baxter.txt")))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    else
                    {
                        string temp = ExtractString(line, ')', 1);
                        char hanzi = ExtractString(temp, ' ', 1).Trim()[0];

                        try
                        {
                            McReconstruction mcr = new McReconstruction(temp);
                            if (!dictionary.ContainsKey(hanzi))
                            {
                                dictionary.Add(hanzi, mcr);
                            }
                        }
                        catch
                        {
                            Debug.WriteLine(String.Format("unparsable reconstruction string [{0}]", temp));
                        }
                    }
                }
            }
        }

        public McReconstruction this[char c]
        {
            get
            {
                McReconstruction result = null;
                dictionary.TryGetValue(c, out result);
                return result;
            }
        }

        // renvoie une portion de chaîne de caractère qui va jusqu'à la n-ièm occurence d'un caractère (inclus) donné
        private string ExtractString(string str, char delimiter, int nb)
        {
            string buffer = "";
            foreach (char c in str)
            {
                buffer += c;
                if (c == delimiter)
                {
                    nb--;
                }
                if (nb == 0)
                {
                    break;
                }
            }
            return buffer;
        }
    }
}
