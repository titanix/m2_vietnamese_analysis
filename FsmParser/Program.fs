﻿// Learn more about F# at http://fsharp.net
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

[<EntryPoint>]
let main argv = 
    let lol = tokenize "/Users/Louis/Code/VietPhon/graph.dot"
    0