using System;
using System.Collections;
using System.Collections.Generic;
using YieldMachine;

namespace VietSyllableTransducer
{
    partial class VietSyllableTransducer : StateMachine<char>
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
        #endregion

        partial void OutAchFunctionHandler ()
        {
            syllable.FinalConsonant = "ch";
            syllable.ConsonantNucleus = "a";
        }

        partial void OutAnhFunctionHandler ()
        {
            syllable.FinalConsonant = "nh";
            syllable.ConsonantNucleus = "a";
        }

        #region Noyau Consonantique
        partial void NvYEndFunctionHandler()
        {
            syllable.ConsonantNucleus = "y";
        }

        partial void NvGenFunctionHandler()
        {
            syllable.ConsonantNucleus = base.actionParameter.ToString();
        }

        partial void OutYeFunctionHandler()
        {
            syllable.ConsonantNucleus = "ya"; // cas particulier
        }

        partial void OutIEFunctionHandler()
        {
            syllable.ConsonantNucleus = "iê";
        }

        partial void NvAFunctionHandler ()
        {
            syllable.ConsonantNucleus = "a";
        }

        partial void NvAchFunctionHandler ()
        {
            syllable.ConsonantNucleus = "e"; // cas particulier
        }
        #endregion

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

        partial void OutXHFunctionHandler ()
        {
            syllable.InitialConsonant = base.actionParameter.ToString() + "h";
        }

        partial void OutNGHFunctionHandler ()
        {
            syllable.InitialConsonant = "ngh";
        }

        partial void OutGHFunctionHandler ()
        {
            syllable.InitialConsonant = "gh";
        }

        partial void OutHFunctionHandler ()
        {
            syllable.InitialConsonant = "h";
        }

        partial void OutNGFunctionHandler ()
        {
            syllable.InitialConsonant = "ng";
        }

        partial void OutGFunctionHandler ()
        {
            syllable.InitialConsonant = "g";
        }

        partial void OutTRFunctionHandler ()
        {
            syllable.InitialConsonant = "tr";
        }

        partial void OutRFunctionHandler ()
        {
            syllable.InitialConsonant = "r";
        }

        partial void InitQFunctionHandler ()
        {
            syllable.InitialConsonant = "q";
        }
        #endregion
    }
}
