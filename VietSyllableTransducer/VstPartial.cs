namespace VietSyllableTransducer
{
	partial class class VietSyllableTransducer
	{
		protected override IEnumerable WalkStates ()
		{
		Begin:
			BeginFunctionHandler()
			yield return null;
			if(actionParameter == 'p') goto Finale1;
			if(actionParameter == 't') goto Finale1;
			if(actionParameter == 'k') goto Finale1;
			if(actionParameter == 'm') goto Finale1;
			if(actionParameter == 'n') goto Finale1;
			if(actionParameter == 'h') goto Finale0_2;
			if(actionParameter == 'g') goto Finale0_3;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'a') goto NvGen;
			if(actionParameter == 'o') goto NvGen;
			if(actionParameter == 'y') goto NvY;
			if(actionParameter == 'a') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'ê') goto NvE;
			goto End;
		Finale0_2:
			Finale0_2FunctionHandler()
			yield return null;
			if(actionParameter == 'c') goto Finale2;
			if(actionParameter == 'h') goto Finale2;
			goto End;
		Finale0_3:
			Finale0_3FunctionHandler()
			yield return null;
			if(actionParameter == 'n') goto Finale3;
			goto End;
		Finale1:
			Finale1FunctionHandler()
			yield return null;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'ê') goto NvYe;
			goto End;
		Finale2:
			Finale2FunctionHandler()
			yield return null;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'a') goto NvAch;
			if(actionParameter == 'ê') goto NvYe;
			goto End;
		Finale3:
			Finale3FunctionHandler()
			yield return null;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'a') goto NvA;
			if(actionParameter == 'ê') goto NvYe;
			goto End;
		NvYe:
			NvYeFunctionHandler()
			yield return null;
			if(actionParameter == 'y') goto OutYe;
			if(actionParameter == 'u') goto PretonaleU;
			goto End;
		NvE:
			NvEFunctionHandler()
			yield return null;
			if(actionParameter == 'i') goto OutIE;
			goto End;
		OutIE:
			OutIEFunctionHandler()
			yield return null;
			if(actionParameter == 'u') goto PretonaleU;
			goto End;
		NvGen:
			NvGenFunctionHandler()
			yield return null;
			if(actionParameter == 'u') goto PretonaleU;
			goto End;
		OutYe:
			OutYeFunctionHandler()
			yield return null;
			if(actionParameter == 'u') goto PretonaleU;
			goto End;
		PretonaleU:
			PretonaleUFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto PretonaleEnd;
			goto End;
		InitH:
			InitHFunctionHandler()
			yield return null;
			if(actionParameter == 'c') goto OutXH;
			if(actionParameter == 'n') goto OutXH;
			if(actionParameter == 'p') goto OutXH;
			if(actionParameter == 'k') goto OutXH;
			if(actionParameter == 'g') goto OutXH;
			if(actionParameter == 't') goto OutXH;
			if(actionParameter == 'g') goto InitGH;
			if(actionParameter == 'ø') goto OutH;
			goto End;
		InitGH:
			InitGHFunctionHandler()
			yield return null;
			if(actionParameter == 'n') goto OutNGH;
			if(actionParameter == 'g') goto OutGH;
			goto End;
		OutNGH:
			OutNGHFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		OutGH:
			OutGHFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		OutXH:
			OutXHFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		InitG:
			InitGFunctionHandler()
			yield return null;
			if(actionParameter == 'n') goto OutNG;
			if(actionParameter == 'ø') goto OutG;
			goto End;
		OutNG:
			OutNGFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		InitGen:
			InitGenFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		InitR:
			InitRFunctionHandler()
			yield return null;
			if(actionParameter == 't') goto OutTR;
			if(actionParameter == 'ø') goto OutR;
			goto End;
		OutTR:
			OutTRFunctionHandler()
			yield return null;
			if(actionParameter == 'ø') goto End;
			goto End;
		End: ;		
}
		partial void BeginFunctionHandler();
		partial void Finale0_2FunctionHandler();
		partial void Finale0_3FunctionHandler();
		partial void Finale1FunctionHandler();
		partial void Finale2FunctionHandler();
		partial void Finale3FunctionHandler();
		partial void NvYeFunctionHandler();
		partial void NvEFunctionHandler();
		partial void OutIEFunctionHandler();
		partial void NvGenFunctionHandler();
		partial void OutYeFunctionHandler();
		partial void PretonaleUFunctionHandler();
		partial void InitHFunctionHandler();
		partial void InitGHFunctionHandler();
		partial void OutNGHFunctionHandler();
		partial void OutGHFunctionHandler();
		partial void OutXHFunctionHandler();
		partial void InitGFunctionHandler();
		partial void OutNGFunctionHandler();
		partial void InitGenFunctionHandler();
		partial void InitRFunctionHandler();
		partial void OutTRFunctionHandler();
	
}
}