using System;
using System.Collections;
using System.Collections.Generic;
using YieldMachine;

namespace VietSyllableTransducer
{
    public partial class VietSyllableTransducer : StateMachine<char>
    {
        [Trigger]
        public readonly Action<char> ReadLetter;

        // est fixée si une transition vers l'état __END est utilisée
        private string defaultTransitionReached; 
        public string DefaultTransitionReached { get { return defaultTransitionReached; } }

        private Syllable syllable = new Syllable();

        public Syllable AnalyzeSyllable(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            str = new string(charArray);
            str = str + "ø";

            foreach (char c in str)
            {
                this.ReadLetter(c);
            }
            return syllable;
        }

        # region Finale
        partial void Finale1FunctionHandler()
        {
            syllable.FinalConsonant = base.actionParameter.ToString();
        }

        partial void Finale3FunctionHandler()
        {
            syllable.FinalConsonant = "ng";
        }

        partial void FinaleNHFunctionHandler ()
        {
            syllable.FinalConsonant = "nh";
        }
        #endregion

        partial void OutAchFunctionHandler()
        {
            syllable.FinalConsonant = "ch";
            syllable.VowelNucleus = "a";
        }

        partial void OutAnhFunctionHandler()
        {
            syllable.FinalConsonant = "nh";
            syllable.VowelNucleus = "a";
        }

        partial void OutFIFunctionHandler()
        {
            syllable.FinalConsonant = "i";
            syllable.VowelNucleus = base.actionParameter.ToString();
        }

        partial void OutGIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "d";
        }

        partial void OutAEoFunctionHandler()
        {
            syllable.FinalConsonant = "u";
            syllable.VowelNucleus = base.actionParameter.ToString();
        }

        partial void OutXHnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = base.actionParameter.ToString() + "h";
        }

        partial void OutHnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "h";
        }

        partial void OutNGHnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "ngh";
        }

        partial void OutGHnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "gh";
        }

        partial void InitGhnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = base.actionParameter.ToString();
        }

        partial void OutTRnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "tr";
        }

        partial void OutRnIFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = "r";
        }

        partial void InitGenNiFunctionHandler()
        {
            syllable.VowelNucleus = "i";
            syllable.InitialConsonant = base.actionParameter.ToString();
        }

        #region InitXnO
        partial void OutXHnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = base.actionParameter.ToString() + "h";
        }

        partial void OutNGHnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "ngh";
        }

        partial void OutGHnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "gh";
        }

        partial void OutHnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "h";
        }

        partial void InitGenNOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = base.actionParameter.ToString();
        }

        partial void OutTRnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "tr";
        }

        partial void OutRnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "r";
        }

        partial void InitGnOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.InitialConsonant = "g";
        }

        partial void OutGNnOFunctionHandler()
        {
            syllable.InitialConsonant = "n" + syllable.InitialConsonant;
        }
        #endregion

        #region InitXnU
        partial void OutXHnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = base.actionParameter.ToString() + "h";
        }

        partial void OutNGHnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "ngh";
        }

        partial void OutGHnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "gh";
        }

        partial void OutHnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "h";
        }

        partial void InitGenNUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = base.actionParameter.ToString();
        }

        partial void OutTRnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "tr";
        }

        partial void OutRnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "r";
        }

        partial void InitGnUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
            syllable.InitialConsonant = "g";
        }

        partial void OutGNnUFunctionHandler()
        {
            syllable.InitialConsonant = "n" + syllable.InitialConsonant;
        }
        #endregion

        partial void FuNxFunctionHandler()
        {
            syllable.FinalConsonant = "u";
            syllable.VowelNucleus = base.actionParameter.ToString();
        }

        partial void FuNiFunctionHandler()
        {
            syllable.FinalConsonant = "u";
            syllable.VowelNucleus = "i";
        }

        partial void ObFunctionHandler()
        {
            syllable.FinalConsonant = "u";
            syllable.VowelNucleus = base.actionParameter.ToString();
        }

        partial void OutUOFunctionHandler()
        {
            syllable.VowelNucleus = base.actionParameter.ToString() + syllable.VowelNucleus;
        }

        #region Noyau Vocalique
        partial void OutOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
        }

        partial void NvYEndFunctionHandler()
        {
            syllable.VowelNucleus = "y";
        }

        partial void NvGenFunctionHandler()
        {
            syllable.VowelNucleus = base.actionParameter.ToString();
        }

        partial void OutYeFunctionHandler()
        {
            syllable.VowelNucleus = "ya"; // cas particulier
        }

        partial void OutIEFunctionHandler()
        {
            syllable.VowelNucleus = "iê";
        }

        partial void NvAFunctionHandler ()
        {
            syllable.VowelNucleus = "a";
        }

        partial void NvAchFunctionHandler()
        {
            syllable.VowelNucleus = "e"; // cas particulier
        }

        partial void OutYaFunctionHandler()
        {
            syllable.VowelNucleus = "a";
            syllable.FinalConsonant = "i";
        }

        partial void OutUbFunctionHandler()
        {
            syllable.VowelNucleus = "ư" + syllable.VowelNucleus;
        }

        partial void OutUpFunctionHandler()
        {
            syllable.VowelNucleus = "ư" + syllable.VowelNucleus;
        }

        partial void OutDiphFunctionHandler()
        {
            syllable.VowelNucleus = "i" + syllable.VowelNucleus;
        }

        partial void NvUFunctionHandler()
        {
            syllable.VowelNucleus = "u";
        }

        partial void OutNvpIFunctionHandler()
        {
            syllable.VowelNucleus = "i" + syllable.VowelNucleus;
        }

        #endregion

        partial void PrétonaleUOFunctionHandler()
        {
            syllable.VowelNucleus = "o";
            syllable.Prefrontal = "u";
        }

        #region Pretonale
        partial void PretonaleUFunctionHandler()
        {
            syllable.Prefrontal = "u";
        }
        #endregion

        #region Initiale
        partial void InitGenFunctionHandler()
        {
            syllable.InitialConsonant = base.actionParameter.ToString();
        }

        partial void OutXHFunctionHandler()
        {
            syllable.InitialConsonant = base.actionParameter.ToString() + "h";
        }

        partial void OutNGHFunctionHandler()
        {
            syllable.InitialConsonant = "ngh";
        }

        partial void OutGHFunctionHandler()
        {
            syllable.InitialConsonant = "gh";
        }

        partial void OutHFunctionHandler()
        {
            syllable.InitialConsonant = "h";
        }

        partial void OutNGFunctionHandler()
        {
            syllable.InitialConsonant = "ng";
        }

        partial void OutGFunctionHandler()
        {
            syllable.InitialConsonant = "g";
        }

        partial void OutTRFunctionHandler()
        {
            syllable.InitialConsonant = "tr";
        }

        partial void OutRFunctionHandler()
        {
            syllable.InitialConsonant = "r";
        }

        partial void InitQFunctionHandler()
        {
            syllable.InitialConsonant = "q";
        }
        #endregion
    }
}
