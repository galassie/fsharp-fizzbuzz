open FSharp.FizzBuzz

[<EntryPoint>]
let main argv =
    printfn "Generate first 100 numbers:" 
    seq { 1..100 }
    |> Seq.map FizzBuzzGenerator.gen
    |> Seq.iter (printfn "%s")
    0 // return an integer exit code

