using System;
using System.Collections;
using System.Collections.Generic;
using YieldMachine;

namespace VietSyllableTransducer
{
    class VietSyllableTransducer : StateMachine<char>
    {
        [Trigger]
        public readonly Action<char> ReadLetter;

        protected override IEnumerable WalkStates ()
        {
            Init:
            Console.WriteLine("Début du parsing");
            yield return null;
            if(actionParameter == 'y') goto nv_2;
            goto End;

            nv_2:
            Console.WriteLine("n(y)");
            yield return null;
            goto End;

            End:
            Console.WriteLine("Fin du parsing");
            yield return null;
            ;
            ///[state name]:
            ///         // State entry actions
            ///         yield return null;  // (wait for a trigger to be called)
            ///         // State exit actions
            ///         
            ///         // Transitions from this state, by checking which trigger has been called
            ///         if (Trigger == PressSwitch) goto [some other state];
            ///         
            ///         // Throw an exception if the trigger was invalid
            ///         InvalidState();
            ///         
            ///     [some other state]:
        }
    }
}
