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
    override x.ToString() = sprintf "%A" x

[<EntryPoint>]
let main argv = 
    //tokenize @"I:\Code Projects\Git\Automaton\OcrOutputParser\ocr1.txt"
    let res = cb_helpers @"I:\Code Projects\Git\Automaton\OcrOutputParser\ocr1.txt"
    let block_str = List.map (fun x -> x |> List.map (fun a -> a.ToString()) |> String.Concat) res
    let block_list = List.map (fun x -> (x, UNKNOW)) block_str
    let modified_list = 
        block_list 
        |> List.map (fun (a:string, b:block) -> if a.Contains("O") && b = UNKNOW then (a, COMPOUND_LIST) else (a, b))
        |> List.map (fun (a:string, b:block) -> if a.Contains("星") && b = UNKNOW then (a, MAIN_ENTRY) else (a, b))

    0 // return an integer exit code
