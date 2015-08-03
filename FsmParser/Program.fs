open System
open System.IO
open Microsoft.FSharp.Text
open Microsoft.FSharp.Text.Lexing
open GraphLexer

let tokenize (path:string) =
    use stream_reader = new StreamReader (path)
    let lexbuf = Lexing.LexBuffer<_>.FromTextReader (stream_reader)
    let mutable loop = true
    while loop do
        try
            printf "%A\n" (GraphLexer.tokenize lexbuf)
        with
            | ex -> loop <- false ; ()

let parse (path:string) =
    use stream_reader = new StreamReader (path)
    let lexbuf = Lexing.LexBuffer<_>.FromTextReader (stream_reader)
    printf "Start Parsing...\n"
    GraphParser.start GraphLexer.tokenize lexbuf

let print_result (table: (string * string * char) list) = 
    List.map (fun (n1, n2, t) -> Console.WriteLine("transition :" + n1 + " " + n2 + " " + t.ToString())) table

let rec indent (str, depth) = if depth <= 0 then str else indent("\t" + str, depth - 1)

let create_fsm_file (table: (string * string * char) list) =
    // génération du contenu de la méthode VietSyllableTransducer.WalkStates
    let method_content = 
        table 
        |> Seq.groupBy (fun (a, _, _) -> a)
        |> Seq.map (fun (key,value) -> String.Concat (indent(key, 2), ":\n",
            indent(key, 3) + "FunctionHandler();\n",
            indent("yield return null;\n", 3), 
            String.Concat(Seq.map (fun (_, n, t) -> String.Format(indent("if(actionParameter == '{0}') goto {1};\n", 3), t, n)) value), 
            indent("goto End;\n", 3)))
        |> String.Concat
    // liste des états finaux
    let empty_states =
        Set.difference (Set.ofSeq (Seq.map (fun (_, n, _) -> n) table)) (Set.ofSeq (Seq.map (fun (n, _, _) -> n) table))
        |> Set.toList
        |> List.map (fun a -> String.Format(indent("{0}:\n", 2), a))
        |> String.Concat
    // génération des méthodes partielles
    let partial_methods = 
        table 
        |> Seq.distinctBy (fun (n, _, _) -> n)
        |> Seq.map (fun (n:string, _, _) -> n)
        |> Seq.map (fun a -> indent(String.Format("partial void {0}FunctionHandler();\n", a), 2)) 
        |> String.Concat
    // écriture du contenu final du fichier
    let file_content = 
        String.Concat(
            "using System.Collections;\n\n",
            "namespace VietSyllableTransducer\n{\n", indent("partial class VietSyllableTransducer\n\t{\n", 1),
            indent("protected override IEnumerable WalkStates ()\n\t\t{\n", 2), 
            method_content,
            empty_states,
            indent(";", 2),
            indent("\n}\n", 2),
            partial_methods,
            indent("\n}", 1),
            indent("\n}", 0))

    use output_file = new StreamWriter("../../../VietSyllableTransducer/VstPartial.cs", false, System.Text.Encoding.UTF8)
    output_file.Write(file_content)
    0


[<EntryPoint>]
let main argv = 
    //let pwet = tokenize "/Users/Louis/Code/VietPhon/graph.dot"
    parse "/Users/Louis/Code/VietPhon/graph.dot" |> ignore
    create_fsm_file (GraphParser.tr_table |> List.ofSeq) |> ignore
    0
