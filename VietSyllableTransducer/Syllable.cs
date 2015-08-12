using System;

namespace VietSyllableTransducer
{
    public class Syllable
    {
        public string InitialConsonant { get; set; }
        public string Prefrontal { get; set; }
        public string VowelNucleus { get; set; }
        public string FinalConsonant { get; set; }

        public Syllable()
        {
            InitialConsonant = "";
            Prefrontal = "";
            VowelNucleus = "";
            FinalConsonant = "";
        }

        public override string ToString ()
        {
            return string.Format ("{0}/{1}/{2}/{3}", InitialConsonant, Prefrontal, VowelNucleus, FinalConsonant);
        }

        public void Parse(string str)
        {
            str.Split('/');
        }
    }
}

