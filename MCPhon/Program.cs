using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;

namespace MCPhon
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            using (StreamReader sr = new StreamReader("/Users/Louis/Code/VietPhon/Data/baxter.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(String.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    else
                    {
                        string temp = ExtractString(line, ')', 1);
                        string hanzi = ExtractString(temp, ' ', 1).Trim();
                        string[] captures = ExtractPattern(temp, 
                            @"\(([\w']+)- \+ -(\w+) [ABCD]\)$");

                        if(captures.Length < 2)
                        {
                            Debug.WriteLine(hanzi + " continue");
                        }
                        else
                        {
                            Debug.WriteLine(hanzi + " " + captures[0] + " " + captures[1]);
                        }
                    }
                }
            }
        }

        // 艾 ài ngajH (ng- + -aj C) *C.ŋˤa[t]-s Artemisia; moxa 0347c 53172.09 140 2 U+827E
        public static string ExtractString (string str, char delimiter, int nb)
        {
            string buffer = "";
            foreach (char c in str)
            {
                buffer += c;
                if(c == delimiter)
                {
                    nb--;
                }
                if(nb == 0)
                {
                    break;
                }
            }
            return buffer;
        }

        // renvoie un groupe de chaînes de caractères correspondant au groupe matché par une expression régulière
        public static string[] ExtractPattern(string str, string pattern)
        {
            List<string> result = new List<string>();
            Regex regex = new Regex(pattern);
            Match m = regex.Match(str);
            if(m.Success)
            {
                for(int i = 1; i < m.Groups.Count; i++)
                {
                    result.Add(m.Groups[i].Value);
                }
            }
            return result.ToArray();
        }
    }
}
