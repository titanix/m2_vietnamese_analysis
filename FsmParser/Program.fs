// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
(*
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
*)

(*
open System
open TestLexer
open Microsoft.FSharp.Text
open Microsoft.FSharp.Text.Lexing
  
let x = "(and DEBUG (or WINDOWS_PHONE XAMARIN))"   

let lexbuf = Lexing.LexBuffer<_>.FromString x
while not lexbuf.IsPastEndOfStream do  
    printfn "%A" (TestLexer.tokenize lexbuf)

Console.WriteLine("(press any key)")   
Console.ReadKey(true) |> ignore
*)

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


 // temp à refactorer pour ne pas faire doublon avec la précédente
let tokenize_from_string (content:string) =
    printf "Start Lexing...\n"
    let lexbuf = Lexing.LexBuffer<_>.FromString (content)
    let mutable loop = true
    while loop do
        try
            printf "%A\n" (GraphLexer.tokenize lexbuf)
        with
            | ex -> loop <- false ; ()

let string_test = "strict digraph { //lol \n Finale0_2 -> Finale2[label=\"c,h\"]; Begin -> Finale0_2[label=\"h\"]; }"
let parse_test x  = 
    printf "Start Parsing...\n"
    let lexbuf = Lexing.LexBuffer<_>.FromString x
    GraphParser.start GraphLexer.tokenize lexbuf

[<EntryPoint>]
let main argv = 
    let lol = parse "/Users/Louis/Code/VietPhon/graph.dot"
    tokenize_from_string string_test
    let result = parse_test string_test
    0

