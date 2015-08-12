using System.Collections;

namespace VietSyllableTransducer
{
	partial class VietSyllableTransducer
	{
		protected override IEnumerable WalkStates ()
		{
		Begin:
			BeginFunctionHandler();
			yield return null;
			if(actionParameter == 'p') goto Finale1;
			if(actionParameter == 't') goto Finale1;
			if(actionParameter == 'k') goto Finale1;
			if(actionParameter == 'm') goto Finale1;
			if(actionParameter == 'n') goto Finale1;
			if(actionParameter == 'c') goto Finale1;
			if(actionParameter == 'h') goto FinaleH;
			if(actionParameter == 'g') goto Finale0_3;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'a') goto NvGen;
			if(actionParameter == 'o') goto FinaleO;
			if(actionParameter == 'i') goto EtatI;
			if(actionParameter == 'a') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'ơ') goto NvGen;
			if(actionParameter == 'ê') goto NvE;
			if(actionParameter == 'y') goto NvY;
			if(actionParameter == 'ư') goto OutUb;
			if(actionParameter == 'u') goto EtatU;
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol l
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			defaultTransitionReached = "Begin";
			goto __END;
		FinaleH:
			FinaleHFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto FinaleNH;
			if(actionParameter == 'c') goto FinaleCH;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FinaleH";
			goto __END;
		Finale0_3:
			Finale0_3FunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto Finale3;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "Finale0_3";
			goto __END;
		FinaleO:
			FinaleOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto OutO;
			if(actionParameter == 'a') goto OutAEo;
			if(actionParameter == 'e') goto OutAEo;
			if(actionParameter == 'u') goto PrétonaleUO;
			if(actionParameter == 'h') goto InitHnO;
			if(actionParameter == 'b') goto InitGenNO;
			if(actionParameter == 'm') goto InitGenNO;
			if(actionParameter == 'p') goto InitGenNO;
			if(actionParameter == 't') goto InitGenNO;
			if(actionParameter == 'c') goto InitGenNO;
			if(actionParameter == 'x') goto InitGenNO;
			if(actionParameter == 'd') goto InitGenNO;
			if(actionParameter == 'đ') goto InitGenNO;
			if(actionParameter == 'l') goto InitGenNO;
			if(actionParameter == 'n') goto InitGenNO;
			if(actionParameter == 's') goto InitGenNO;
			if(actionParameter == 'v') goto InitGenNO;
			if(actionParameter == 'r') goto InitRnO;
			if(actionParameter == 'g') goto InitGnO;
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FinaleO";
			goto __END;
		OutAEo:
			OutAEoFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutAEo";
			goto __END;
		EtatI:
			EtatIFunctionHandler();
			yield return null;
			if(actionParameter == 'a') goto OutFI;
			if(actionParameter == 'o') goto OutFI;
			if(actionParameter == 'ư') goto OutFI;
			if(actionParameter == 'ơ') goto OutFI;
			if(actionParameter == 'e') goto OutFI;
			if(actionParameter == 'g') goto OutGI;
			if(actionParameter == 'u') goto NvU;
			if(actionParameter == 'h') goto InitHnI;
			if(actionParameter == 'b') goto InitGenNi;
			if(actionParameter == 'm') goto InitGenNi;
			if(actionParameter == 'p') goto InitGenNi;
			if(actionParameter == 't') goto InitGenNi;
			if(actionParameter == 'c') goto InitGenNi;
			if(actionParameter == 'x') goto InitGenNi;
			if(actionParameter == 'd') goto InitGenNi;
			if(actionParameter == 'đ') goto InitGenNi;
			if(actionParameter == 'l') goto InitGenNi;
			if(actionParameter == 'n') goto InitGenNi;
			if(actionParameter == 's') goto InitGenNi;
			if(actionParameter == 'v') goto InitGenNi;
			if(actionParameter == 'k') goto InitGenNi;
			if(actionParameter == 'r') goto InitRnI;
			#warning missing transition for symbol i
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			defaultTransitionReached = "EtatI";
			goto __END;
		OutFI:
			OutFIFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'ư') goto OutUb;
			if(actionParameter == 'u') goto OutUp;
			if(actionParameter == 'o') goto OutUp;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			defaultTransitionReached = "OutFI";
			goto __END;
		FinaleCH:
			FinaleCHFunctionHandler();
			yield return null;
			if(actionParameter == 'a') goto NvAch;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'ê') goto NvYe;
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FinaleCH";
			goto __END;
		FinaleNH:
			FinaleNHFunctionHandler();
			yield return null;
			if(actionParameter == 'a') goto NvAnh;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'ê') goto NvYe;
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FinaleNH";
			goto __END;
		NvAch:
			NvAchFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto OutAch;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvAch";
			goto __END;
		NvAnh:
			NvAnhFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto OutAnh;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvAnh";
			goto __END;
		NvGen:
			NvGenFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'ư') goto OutUb;
			if(actionParameter == 'i') goto OutDiph;
			if(actionParameter == 'u') goto PretonaleU;
			if(actionParameter == 'o') goto PretonaleU;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			defaultTransitionReached = "NvGen";
			goto __END;
		NvY:
			NvYFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto NvYEnd;
			if(actionParameter == 'a') goto OutYa;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvY";
			goto __END;
		Finale1:
			Finale1FunctionHandler();
			yield return null;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'a') goto NvGen;
			if(actionParameter == 'o') goto NvGen;
			if(actionParameter == 'ơ') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'ê') goto NvYe;
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ư
			defaultTransitionReached = "Finale1";
			goto __END;
		Finale3:
			Finale3FunctionHandler();
			yield return null;
			if(actionParameter == 'y') goto NvGen;
			if(actionParameter == 'e') goto NvGen;
			if(actionParameter == 'i') goto NvGen;
			if(actionParameter == 'o') goto NvGen;
			if(actionParameter == 'ư') goto NvGen;
			if(actionParameter == 'ơ') goto NvGen;
			if(actionParameter == 'a') goto NvA;
			if(actionParameter == 'ê') goto NvYe;
			if(actionParameter == 'u') goto NvU;
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			defaultTransitionReached = "Finale3";
			goto __END;
		NvYe:
			NvYeFunctionHandler();
			yield return null;
			if(actionParameter == 'y') goto OutYe;
			if(actionParameter == 'u') goto PretonaleU;
			if(actionParameter == 'o') goto PretonaleU;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvYe";
			goto __END;
		NvE:
			NvEFunctionHandler();
			yield return null;
			if(actionParameter == 'i') goto OutIE;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvE";
			goto __END;
		OutIE:
			OutIEFunctionHandler();
			yield return null;
			if(actionParameter == 'u') goto PretonaleU;
			if(actionParameter == 'o') goto PretonaleU;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutIE";
			goto __END;
		OutYa:
			OutYaFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutYa";
			goto __END;
		OutYe:
			OutYeFunctionHandler();
			yield return null;
			if(actionParameter == 'u') goto PretonaleU;
			if(actionParameter == 'o') goto PretonaleU;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutYe";
			goto __END;
		PretonaleU:
			PretonaleUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto PretonaleEnd;
			if(actionParameter == 'q') goto InitQ;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "PretonaleU";
			goto __END;
		InitQ:
			InitQFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitQ";
			goto __END;
		NvA:
			NvAFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvA";
			goto __END;
		PrétonaleUO:
			PrétonaleUOFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "PrétonaleUO";
			goto __END;
		OutUb:
			OutUbFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutUb";
			goto __END;
		OutDiph:
			OutDiphFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutDiph";
			goto __END;
		OutUp:
			OutUpFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutUp";
			goto __END;
		NvU:
			NvUFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "NvU";
			goto __END;
		FuNx:
			FuNxFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			if(actionParameter == 'i') goto OutNvpI;
			if(actionParameter == 'y') goto OutNvpI;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FuNx";
			goto __END;
		OutNvpI:
			OutNvpIFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNvpI";
			goto __END;
		FuNi:
			FuNiFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "FuNi";
			goto __END;
		Ob:
			ObFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			if(actionParameter == 'u') goto OutUO;
			if(actionParameter == 'ư') goto OutUO;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			defaultTransitionReached = "Ob";
			goto __END;
		OutUO:
			OutUOFunctionHandler();
			yield return null;
			if(actionParameter == 'h') goto InitH;
			if(actionParameter == 'g') goto InitG;
			if(actionParameter == 'b') goto InitGen;
			if(actionParameter == 'm') goto InitGen;
			if(actionParameter == 'p') goto InitGen;
			if(actionParameter == 't') goto InitGen;
			if(actionParameter == 'x') goto InitGen;
			if(actionParameter == 'd') goto InitGen;
			if(actionParameter == 'đ') goto InitGen;
			if(actionParameter == 'l') goto InitGen;
			if(actionParameter == 'n') goto InitGen;
			if(actionParameter == 's') goto InitGen;
			if(actionParameter == 'v') goto InitGen;
			if(actionParameter == 'c') goto InitGen;
			if(actionParameter == 'r') goto InitR;
			#warning missing transition for symbol a
			#warning missing transition for symbol e
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol ø
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutUO";
			goto __END;
		InitH:
			InitHFunctionHandler();
			yield return null;
			if(actionParameter == 'c') goto OutXH;
			if(actionParameter == 'n') goto OutXH;
			if(actionParameter == 'p') goto OutXH;
			if(actionParameter == 'k') goto OutXH;
			if(actionParameter == 't') goto OutXH;
			if(actionParameter == 'g') goto InitGH;
			if(actionParameter == 'ø') goto OutH;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitH";
			goto __END;
		InitGH:
			InitGHFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto OutNGH;
			if(actionParameter == 'ø') goto OutGH;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGH";
			goto __END;
		OutNGH:
			OutNGHFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNGH";
			goto __END;
		OutXH:
			OutXHFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutXH";
			goto __END;
		InitG:
			InitGFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto OutNG;
			if(actionParameter == 'ø') goto OutG;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitG";
			goto __END;
		OutNG:
			OutNGFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNG";
			goto __END;
		InitGen:
			InitGenFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGen";
			goto __END;
		InitR:
			InitRFunctionHandler();
			yield return null;
			if(actionParameter == 't') goto OutTR;
			if(actionParameter == 'ø') goto OutR;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitR";
			goto __END;
		OutTR:
			OutTRFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutTR";
			goto __END;
		InitHnI:
			InitHnIFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto OutHnI;
			if(actionParameter == 'c') goto OutXHnI;
			if(actionParameter == 'n') goto OutXHnI;
			if(actionParameter == 'p') goto OutXHnI;
			if(actionParameter == 'k') goto OutXHnI;
			if(actionParameter == 't') goto OutXHnI;
			if(actionParameter == 'g') goto InitGhnI;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitHnI";
			goto __END;
		InitGhnI:
			InitGhnIFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto OutNGHnI;
			if(actionParameter == 'ø') goto OutGHnI;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGhnI";
			goto __END;
		InitRnI:
			InitRnIFunctionHandler();
			yield return null;
			if(actionParameter == 't') goto OutTRnI;
			if(actionParameter == 'ø') goto OutRnI;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitRnI";
			goto __END;
		OutXHnI:
			OutXHnIFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutXHnI";
			goto __END;
		OutNGHnI:
			OutNGHnIFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNGHnI";
			goto __END;
		OutTRnI:
			OutTRnIFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutTRnI";
			goto __END;
		InitGenNi:
			InitGenNiFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGenNi";
			goto __END;
		EtatU:
			EtatUFunctionHandler();
			yield return null;
			if(actionParameter == 'a') goto FuNx;
			if(actionParameter == 'ê') goto FuNx;
			if(actionParameter == 'i') goto FuNi;
			if(actionParameter == 'ơ') goto Ob;
			if(actionParameter == 'o') goto Ob;
			if(actionParameter == 'h') goto InitHnU;
			if(actionParameter == 'b') goto InitGenNU;
			if(actionParameter == 'm') goto InitGenNU;
			if(actionParameter == 'p') goto InitGenNU;
			if(actionParameter == 't') goto InitGenNU;
			if(actionParameter == 'c') goto InitGenNU;
			if(actionParameter == 'x') goto InitGenNU;
			if(actionParameter == 'd') goto InitGenNU;
			if(actionParameter == 'đ') goto InitGenNU;
			if(actionParameter == 'l') goto InitGenNU;
			if(actionParameter == 'n') goto InitGenNU;
			if(actionParameter == 's') goto InitGenNU;
			if(actionParameter == 'v') goto InitGenNU;
			if(actionParameter == 'r') goto InitRnU;
			if(actionParameter == 'g') goto InitGnU;
			#warning missing transition for symbol e
			#warning missing transition for symbol k
			#warning missing transition for symbol q
			#warning missing transition for symbol u
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ø
			#warning missing transition for symbol ư
			defaultTransitionReached = "EtatU";
			goto __END;
		InitHnO:
			InitHnOFunctionHandler();
			yield return null;
			if(actionParameter == 'c') goto OutXHnO;
			if(actionParameter == 'n') goto OutXHnO;
			if(actionParameter == 'p') goto OutXHnO;
			if(actionParameter == 'k') goto OutXHnO;
			if(actionParameter == 't') goto OutXHnO;
			if(actionParameter == 'g') goto InitGHnO;
			if(actionParameter == 'ø') goto OutHnO;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitHnO";
			goto __END;
		InitGHnO:
			InitGHnOFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto OutNGHnO;
			if(actionParameter == 'ø') goto OutGHnO;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGHnO";
			goto __END;
		OutXHnO:
			OutXHnOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutXHnO";
			goto __END;
		OutNGHnO:
			OutNGHnOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNGHnO";
			goto __END;
		InitGenNO:
			InitGenNOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGenNO";
			goto __END;
		InitRnO:
			InitRnOFunctionHandler();
			yield return null;
			if(actionParameter == 't') goto OutTRnO;
			if(actionParameter == 'ø') goto OutRnO;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitRnO";
			goto __END;
		OutTRnO:
			OutTRnOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutTRnO";
			goto __END;
		InitGnO:
			InitGnOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'n') goto OutGNnO;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGnO";
			goto __END;
		OutGNnO:
			OutGNnOFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutGNnO";
			goto __END;
		InitHnU:
			InitHnUFunctionHandler();
			yield return null;
			if(actionParameter == 'c') goto OutXHnU;
			if(actionParameter == 'n') goto OutXHnU;
			if(actionParameter == 'p') goto OutXHnU;
			if(actionParameter == 'k') goto OutXHnU;
			if(actionParameter == 't') goto OutXHnU;
			if(actionParameter == 'g') goto InitGHnU;
			if(actionParameter == 'ø') goto OutHnU;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitHnU";
			goto __END;
		InitGHnU:
			InitGHnUFunctionHandler();
			yield return null;
			if(actionParameter == 'n') goto OutNGHnU;
			if(actionParameter == 'ø') goto OutGHnU;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGHnU";
			goto __END;
		OutXHnU:
			OutXHnUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutXHnU";
			goto __END;
		OutNGHnU:
			OutNGHnUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutNGHnU";
			goto __END;
		InitGenNU:
			InitGenNUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGenNU";
			goto __END;
		InitRnU:
			InitRnUFunctionHandler();
			yield return null;
			if(actionParameter == 't') goto OutTRnU;
			if(actionParameter == 'ø') goto OutRnU;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitRnU";
			goto __END;
		OutTRnU:
			OutTRnUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutTRnU";
			goto __END;
		InitGnU:
			InitGnUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			if(actionParameter == 'n') goto OutGNnU;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "InitGnU";
			goto __END;
		OutGNnU:
			OutGNnUFunctionHandler();
			yield return null;
			if(actionParameter == 'ø') goto End;
			#warning missing transition for symbol a
			#warning missing transition for symbol b
			#warning missing transition for symbol c
			#warning missing transition for symbol d
			#warning missing transition for symbol e
			#warning missing transition for symbol g
			#warning missing transition for symbol h
			#warning missing transition for symbol i
			#warning missing transition for symbol k
			#warning missing transition for symbol l
			#warning missing transition for symbol m
			#warning missing transition for symbol n
			#warning missing transition for symbol o
			#warning missing transition for symbol p
			#warning missing transition for symbol q
			#warning missing transition for symbol r
			#warning missing transition for symbol s
			#warning missing transition for symbol t
			#warning missing transition for symbol u
			#warning missing transition for symbol v
			#warning missing transition for symbol x
			#warning missing transition for symbol y
			#warning missing transition for symbol z
			#warning missing transition for symbol ê
			#warning missing transition for symbol đ
			#warning missing transition for symbol ơ
			#warning missing transition for symbol ư
			defaultTransitionReached = "OutGNnU";
			goto __END;
		End:
			EndFunctionHandler();
			goto __END;
		NvYEnd:
			NvYEndFunctionHandler();
			goto __END;
		OutAch:
			OutAchFunctionHandler();
			goto __END;
		OutAnh:
			OutAnhFunctionHandler();
			goto __END;
		OutG:
			OutGFunctionHandler();
			goto __END;
		OutGH:
			OutGHFunctionHandler();
			goto __END;
		OutGHnI:
			OutGHnIFunctionHandler();
			goto __END;
		OutGHnO:
			OutGHnOFunctionHandler();
			goto __END;
		OutGHnU:
			OutGHnUFunctionHandler();
			goto __END;
		OutGI:
			OutGIFunctionHandler();
			goto __END;
		OutH:
			OutHFunctionHandler();
			goto __END;
		OutHnI:
			OutHnIFunctionHandler();
			goto __END;
		OutHnO:
			OutHnOFunctionHandler();
			goto __END;
		OutHnU:
			OutHnUFunctionHandler();
			goto __END;
		OutO:
			OutOFunctionHandler();
			goto __END;
		OutR:
			OutRFunctionHandler();
			goto __END;
		OutRnI:
			OutRnIFunctionHandler();
			goto __END;
		OutRnO:
			OutRnOFunctionHandler();
			goto __END;
		OutRnU:
			OutRnUFunctionHandler();
			goto __END;
		PretonaleEnd:
			PretonaleEndFunctionHandler();
			goto __END;
		__END:
		;		
}
		partial void BeginFunctionHandler();
		partial void FinaleHFunctionHandler();
		partial void Finale0_3FunctionHandler();
		partial void FinaleOFunctionHandler();
		partial void OutAEoFunctionHandler();
		partial void EtatIFunctionHandler();
		partial void OutFIFunctionHandler();
		partial void FinaleCHFunctionHandler();
		partial void FinaleNHFunctionHandler();
		partial void NvAchFunctionHandler();
		partial void NvAnhFunctionHandler();
		partial void NvGenFunctionHandler();
		partial void NvYFunctionHandler();
		partial void Finale1FunctionHandler();
		partial void Finale3FunctionHandler();
		partial void NvYeFunctionHandler();
		partial void NvEFunctionHandler();
		partial void OutIEFunctionHandler();
		partial void OutYaFunctionHandler();
		partial void OutYeFunctionHandler();
		partial void PretonaleUFunctionHandler();
		partial void InitQFunctionHandler();
		partial void NvAFunctionHandler();
		partial void PrétonaleUOFunctionHandler();
		partial void OutUbFunctionHandler();
		partial void OutDiphFunctionHandler();
		partial void OutUpFunctionHandler();
		partial void NvUFunctionHandler();
		partial void FuNxFunctionHandler();
		partial void OutNvpIFunctionHandler();
		partial void FuNiFunctionHandler();
		partial void ObFunctionHandler();
		partial void OutUOFunctionHandler();
		partial void InitHFunctionHandler();
		partial void InitGHFunctionHandler();
		partial void OutNGHFunctionHandler();
		partial void OutXHFunctionHandler();
		partial void InitGFunctionHandler();
		partial void OutNGFunctionHandler();
		partial void InitGenFunctionHandler();
		partial void InitRFunctionHandler();
		partial void OutTRFunctionHandler();
		partial void InitHnIFunctionHandler();
		partial void InitGhnIFunctionHandler();
		partial void InitRnIFunctionHandler();
		partial void OutXHnIFunctionHandler();
		partial void OutNGHnIFunctionHandler();
		partial void OutTRnIFunctionHandler();
		partial void InitGenNiFunctionHandler();
		partial void EtatUFunctionHandler();
		partial void InitHnOFunctionHandler();
		partial void InitGHnOFunctionHandler();
		partial void OutXHnOFunctionHandler();
		partial void OutNGHnOFunctionHandler();
		partial void InitGenNOFunctionHandler();
		partial void InitRnOFunctionHandler();
		partial void OutTRnOFunctionHandler();
		partial void InitGnOFunctionHandler();
		partial void OutGNnOFunctionHandler();
		partial void InitHnUFunctionHandler();
		partial void InitGHnUFunctionHandler();
		partial void OutXHnUFunctionHandler();
		partial void OutNGHnUFunctionHandler();
		partial void InitGenNUFunctionHandler();
		partial void InitRnUFunctionHandler();
		partial void OutTRnUFunctionHandler();
		partial void InitGnUFunctionHandler();
		partial void OutGNnUFunctionHandler();

		partial void EndFunctionHandler();
		partial void NvYEndFunctionHandler();
		partial void OutAchFunctionHandler();
		partial void OutAnhFunctionHandler();
		partial void OutGFunctionHandler();
		partial void OutGHFunctionHandler();
		partial void OutGHnIFunctionHandler();
		partial void OutGHnOFunctionHandler();
		partial void OutGHnUFunctionHandler();
		partial void OutGIFunctionHandler();
		partial void OutHFunctionHandler();
		partial void OutHnIFunctionHandler();
		partial void OutHnOFunctionHandler();
		partial void OutHnUFunctionHandler();
		partial void OutOFunctionHandler();
		partial void OutRFunctionHandler();
		partial void OutRnIFunctionHandler();
		partial void OutRnOFunctionHandler();
		partial void OutRnUFunctionHandler();
		partial void PretonaleEndFunctionHandler();
	
}
}