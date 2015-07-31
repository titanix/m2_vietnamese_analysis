// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
(*
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
*)

open System
open TestLexer
open Microsoft.FSharp.Text
open Microsoft.FSharp.Text.Lexing
  
let x = "(and DEBUG (or WINDOWS_PHONE XAMARIN))"   

let lexbuf =  Lexing.LexBuffer<_>.FromString x
while not lexbuf.IsPastEndOfStream do  
    printfn "%A" (TestLexer.tokenize lexbuf)

Console.WriteLine("(press any key)")   
Console.ReadKey(true) |> ignore