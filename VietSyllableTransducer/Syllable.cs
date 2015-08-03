using System;

namespace VietSyllableTransducer
{
    public class Syllable
    {
        public string InitialConsonant { get; set; }
        public string Prefrontal { get; set; }
        public string ConsonantNucleus { get; set; }
        public string FinalConsonant { get; set; }

        public override string ToString ()
        {
            return string.Format ("{0}/{1}/{2}/{3}", InitialConsonant, Prefrontal, ConsonantNucleus, FinalConsonant);
        }

        public void Parse(string str)
        {
            str.Split('/');
        }
    }
}

