namespace FSharp.FizzBuzz

module FizzBuzzGenerator =
    let gen (x:int) = 
        seq {
          yield (if x % 3 = 0 then "Fizz" else "")
          yield (if x % 5 = 0 then "Buzz" else "")
        }
        |> Seq.reduce ( + )
        |> function
            | "" -> sprintf "%d" x
            | __ -> __

    let genSimplified (x:int) =
        let seqString = seq {
                yield (if x % 3 = 0 then "Fizz" else "")
                yield (if x % 5 = 0 then "Buzz" else "")
            }
        let seqReduced = Seq.reduce (fun acc item -> acc + item) seqString
        match seqReduced with
        | "" -> sprintf "%d" x
        | __ -> __