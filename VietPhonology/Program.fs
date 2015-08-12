open System
open System.IO

// lit un fichier formé de lignes:
// nôm
// prononciation
// et renvoie une séquence de paires (nôm, prononciation)
let readNomFile (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        let nôm = sr.ReadLine()
        let reading = sr.ReadLine().Replace(".", "") // on enlève les ... existent pour certaines entrées
        yield (nôm, reading)
}

// renvoie une fonction de remplacement d'une lettre vers une autre
let toFun (oldLetter:char, newLetter:char) = 
    (fun c -> if c = oldLetter then newLetter else c)

// crée une liste de fonction de remplacement de caractères diacritiés en non diacrité
let replaceFunctionList = [ 
    yield! "àáạãảăằắặẵẳâầấậẫẩ" |> Seq.map (fun c -> toFun(c, 'a')) ;
    yield! "èéẹẽẻ" |> Seq.map (fun c -> toFun(c, 'e')) ;
    yield! "ìíịĩỉ" |> Seq.map( fun c -> toFun(c, 'i')) ;
    yield! "òóọõỏôồốộỗổ" |> Seq.map (fun c -> toFun(c, 'o')) ;
    yield! "ùúụũủ" |> Seq.map(fun c -> toFun(c, 'u')) ;
    yield! "ỳýỵỹỷ" |> Seq.map (fun c -> toFun(c, 'y')) ;
    yield! "ơờớợỡở" |> Seq.map (fun c -> toFun(c, 'ơ')) ;
    yield! "ưừứựữử" |> Seq.map(fun c -> toFun(c, 'ư')) ;
    yield! "êềếệễể" |> Seq.map (fun c -> toFun(c, 'ê')) ;
]

// applique les fonctions de remplacement à une chaîne de caractère
let applyReplaceFunctions str:string = 
    str |> Seq.map (fun c -> List.fold (fun a b -> b a) c replaceFunctionList) |> String.Concat

[<EntryPoint>]
let main argv = 
    let seqNom = readNomFile("Data/nom_level_1+2.txt")
    let listNom = seqNom |> Seq.toList

    listNom 
    |> List.map (fun (n, p) -> (n, p, applyReplaceFunctions p))
    |> List.map (fun (a, b, c) -> printfn "%s %s %s" a b c) 
    |> ignore

    0 // return an integer exit code