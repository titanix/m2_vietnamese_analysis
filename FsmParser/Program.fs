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

let create_fsm_file (table: (string * string * char) list, outfile_path:string, generate_warnings:bool) =
    let final_state_name = "__END"
    let method_suffix_name = "FunctionHandler"
    let alphabet = ['a'; 'b'; 'c'; 'd'; 'e' ; 'g'; 'h'; 'i'; 'k'; 'l'; 'm'; 'n'; 'o'; 'p'; 'q'; 'r'; 's'; 't'; 'u';
    'v'; 'x'; 'y'; 'z'; 'đ'; 'ơ'; 'ư'; 'ø'; 'ê'] |> Set.ofList
    // génération du contenu de la méthode VietSyllableTransducer.WalkStates (états non finaux)
    let method_content = 
        table 
        |> Seq.groupBy (fun (a, _, _) -> a)
        |> Seq.map (fun (key,value) -> String.Concat (indent(key, 2), ":\n",
            indent(String.Format("{0}{1}();\n", key, method_suffix_name), 3),
            indent("yield return null;\n", 3), 
            String.Concat(Seq.map (fun (_, n, t) -> String.Format(indent("if(actionParameter == '{0}') goto {1};\n", 3), t, n)) value),
            (if generate_warnings then 
                String.Concat(Set.map (fun x -> indent(String.Format("#warning missing transition for symbol {0}\n", x), 3)) 
                  (Set.difference alphabet (Set.ofSeq (Seq.map (fun (_, _, t) -> t) value)))) 
            else String.Empty),
            indent(String.Format("defaultTransitionReached = \"{0}\";\n", key), 3),
            indent(String.Format("goto {0};\n", final_state_name), 3)))
        |> String.Concat

    // liste des états finaux
    let final_states = 
        Set.difference (Set.ofSeq (Seq.map (fun (_, n, _) -> n) table)) (Set.ofSeq (Seq.map (fun (n, _, _) -> n) table)) 
        |> Set.toList
    // génération des labels et des appels de méthode des états finaux
    let empty_states =
        final_states
        |> List.map (fun a -> 
            String.Concat(String.Format(indent("{0}:\n", 2), a),
                indent(String.Format("{0}{1}();\n", a, method_suffix_name), 3),
                indent(String.Format("goto {0};\n", final_state_name), 3)))
        |> String.Concat

    // génération des méthodes partielles des états finaux
    let partial_methods_2 =
        final_states
        |> Seq.map (fun a -> indent(String.Format("partial void {0}{1}();\n", a, method_suffix_name), 2)) 
        |> String.Concat
    // génération des méthodes partielles des états non finaux
    let partial_methods_1 = 
        table 
        |> Seq.distinctBy (fun (n, _, _) -> n)
        |> Seq.map (fun (n:string, _, _) -> n)
        |> Seq.map (fun a -> indent(String.Format("partial void {0}{1}();\n", a, method_suffix_name), 2)) 
        |> String.Concat

    // écriture du contenu final du fichier
    let file_content = 
        String.Concat(
            "using System.Collections;\n\n",
            "namespace VietSyllableTransducer\n{\n", indent("partial class VietSyllableTransducer\n\t{\n", 1),
            indent("protected override IEnumerable WalkStates ()\n\t\t{\n", 2), 
            method_content,
            empty_states,
            indent(final_state_name + ":\n", 2), 
            indent(";", 2),
            indent("\n}\n", 2),
            partial_methods_1,
            "\n",
            partial_methods_2,
            indent("\n}", 1),
            indent("\n}", 0))

    use output_file = new StreamWriter(outfile_path, false, System.Text.Encoding.UTF8)
    output_file.Write(file_content)
    0


[<EntryPoint>]
let main argv =
    match argv with
    | [| graph_path ; out_path |] -> parse graph_path |> ignore
                                     let tr_table = GraphParser.tr_table |> List.ofSeq
                                     create_fsm_file (tr_table, out_path, false) |> ignore
                                     0
    | _ -> 1
