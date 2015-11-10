open System
open System.IO
open Microsoft.FSharp.Text
open Microsoft.FSharp.Text.Lexing
open Phase10

let tokenize (path:string) =
    use stream_reader = new StreamReader (path)
    let lexbuf = LexBuffer<_>.FromTextReader (stream_reader)
    let mutable loop = true
    let mutable count = 0
    while loop do
        try
            count <- count + 1
            printf "%A\n" (Phase10.tokenize lexbuf)
        with
            | ex -> loop <- false ; ()

let rec create_blocks (lexbuf:LexBuffer<char>) (result:token list list) =
    match (Phase10.tokenize lexbuf) with
        | EOF   -> result
        | NL    -> (handle_nl lexbuf result)
        | t     -> match result with 
                    | []            -> create_blocks lexbuf [[t]]
                    | head :: tail  -> create_blocks lexbuf ((head @ [t]) :: tail)

and handle_nl (lexbuf:LexBuffer<char>) (result:token list list) =
    match (Phase10.tokenize lexbuf) with
        | NL    -> match result with 
                    | []            -> create_blocks lexbuf [[NL]]
                    | head :: tail  -> create_blocks lexbuf ((head @ [NL]) :: tail)
        | t     -> create_blocks lexbuf ([t] :: result)

// englobe un appel à create_blocks avec les arguments qui vont bien
let cb_helpers (path:string) =
    use stream_reader = new StreamReader (path)
    let lexbuf = LexBuffer<_>.FromTextReader (stream_reader)
    List.rev (create_blocks lexbuf [])

type block =
    | MAIN_ENTRY
    | COMPOUND_LIST
    | UNKNOW
    | JUNK
    override x.ToString() = sprintf "%A" x

// fusionne les blocs COMPOUND_LIST successifs en un seul COMPOUND_LIST
let rec merge_comp_block block_list = 
    match block_list with
        | []             -> []
        | a :: b :: tail -> let (lt1, str1, b1) = a
                            let (lt2, str2, b2) = b
                            if b1 = COMPOUND_LIST && b2 = COMPOUND_LIST
                            then
                                let new_elem = (lt1 @ lt2, str1 + str2, COMPOUND_LIST)
                                (merge_comp_block (new_elem :: tail))
                            else 
                                a :: (merge_comp_block (b :: tail))
        | head :: tail   -> head :: (merge_comp_block tail)

[<EntryPoint>]
let main argv = 
    //tokenize @"I:\Code Projects\Git\Automaton\OcrOutputParser\ocr1.txt"
    let result = cb_helpers @"ocr1.txt"
    let block_list = List.map (fun x -> (x, (x |> List.map (fun a -> a.ToString()) |> String.Concat), UNKNOW)) result
    let modified_list = 
        block_list 
        |> List.map (fun (lt, a:string, b:block) -> if a.Contains("O") && b = UNKNOW then (lt, a, COMPOUND_LIST) else (lt, a, b))
        |> List.map (fun (lt, a:string, b:block) -> if a.Contains("星") && b = UNKNOW then (lt, a, MAIN_ENTRY) else (lt, a, b))
        // ces règles doivent être appliquées après les deux premières, car sont moins précises
        |> List.map (fun (lt, a:string, b:block) -> if a.Contains("CC") && b = UNKNOW then (lt, a, MAIN_ENTRY) else (lt, a, b))
        |> List.map (fun (lt, a:string, b:block) -> if a.Contains("假C") && b = UNKNOW then (lt, a, MAIN_ENTRY) else (lt, a, b))
        |> List.map (fun (lt, a:string, b:block) -> if a.Contains("開閉") && b = UNKNOW then (lt, a, JUNK) else (lt, a, b))

        |> merge_comp_block
    0 // return an integer exit code

    // (MAIN_ENTRY+COMPOUND_LIST)+