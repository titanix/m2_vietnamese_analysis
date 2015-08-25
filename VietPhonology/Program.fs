open System
open System.IO
open VietSyllableTransducer
open MCPhon

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


let analyseSyllable (str:string) : Syllable =
    let analyzer = new VietSyllableTransducer()
    analyzer.AnalyzeSyllable(str)


let (mc_dict:McDictionary) = new McDictionary()

let getReconstructionVietDex (hanzi:char) : string =
    mc_dict.[hanzi].McDex()

[<EntryPoint>]
let main argv = 
    let seqNom = readNomFile("Data/nom_level_1+2.txt")
    let listNom = seqNom |> Seq.toList
    use outfile = new StreamWriter("output.html")
    outfile.WriteLine("<html><body><table><tr><th>Nôm</th><th>Quốc ngữ </th><th>Quoc ngu</th><th>analyse syllabique</th><th>VietDex</th><th>McDex</th><th>MC</th><th>BMP ?</th></tr>");

    listNom 
    |> List.map (fun (n, p) -> 
                (n, p, 
                    applyReplaceFunctions p, 
                    analyseSyllable (applyReplaceFunctions p), 
                    getReconstructionVietDex (n.[0]),
                    (match mc_dict.[n.[0]] with null -> "" | r -> r.FullForm),
                    (if Lecailliez.Japanese.Helpers.Utils.IsKanji(n.[0]) then "<span style='color:green;'>Oui</span>" else "<span style='color:red;'>Non</span>")
                    ))
    |> List.sortBy (fun (_, _, _, _, _, _, g) -> g)
    |> List.map (fun (a, b, c, d, e, f, g) -> 
                outfile.WriteLine(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td></tr>", 
                    a, b, c, (d.ToString()), (d.VietDex()), e, f, g)))
    |> ignore

    outfile.WriteLine("</table></body></html>");

    0 // return an integer exit code