using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VietSyllableTransducer
{
    public static class Vietdex
    {
        // associe une initiale (en lettre minuscule) à une classe de phonème (par convention une majuscule)
        private static Dictionary<string, string> VietConsonantMap = new Dictionary<string, string>()
        {
            { "b", "B" },
            { "c", "K" },
            { "k", "K" },
            { "kh", "K" },
            { "g", "G" },
            { "d", "D" },
            { "đ", "D" },
            { "h", "H" },
            { "l", "L" },
            { "r", "L" },
            { "m", "M" },
            { "n", "N" },
            { "ph", "F" },
            { "qu", "K" }, // ?
            { "s", "X" },
            { "x", "X" },
            { "t", "T" },
            { "th", "T" },
            { "v", "V" },
            { "ng", "Ñ" },
            { "", "Ø" },
            { "tr", "T" },
            { "ngh", "Ñ" },
            { "nh", "N" },
            { "ch", "Č" }, // ?

            // finale
            { "i", "Y" },
            { "y", "Y" },
            { "u", "W" },

            // MC
            { "'", "Ø" },
            { "tsh", "Č" },
            { "j", "Y" },
            { "w", "W" },
            { "p", "B" },
            { "ny", "N" },
            { "dz", "D" },
            //{ "", "" },
        };

        private static Dictionary<string, string> VietVowelMap = new Dictionary<string, string>()
        {
            { "a", "a" },
            { "e", "é" },
            { "ê", "é" },
            { "i", "i" },
            { "y", "i" },
            { "o", "o" },
            { "ô", "o" },
            { "ư", "ü" },
            { "ơ", "e" },
        };

        public static string VietDex(this Syllable syllable)
        {
            string result = "";

            try
            {
                result += VietConsonantMap[syllable.InitialConsonant];
                result += VietConsonantMap[syllable.FinalConsonant];
                //result += VietVowelMap[syllable.VowelNucleus];
            }
            catch
            {
                result = "";
            }

            return result;
        }

        public static string McDex(this MCPhon.McReconstruction reconstruction)
        {
            string result = "";

            try
            {
                result += VietConsonantMap[reconstruction.InitialConsonant];
                result += VietConsonantMap[reconstruction.FinalConsonant];
            }
            catch
            {
                result = "";
            }

            return result;
        }
    }
}
