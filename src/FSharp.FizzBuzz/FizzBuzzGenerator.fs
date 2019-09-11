namespace FSharp.FizzBuzz

module FizzBuzzGenerator =
    let gen x = 
        [|
          (if x % 3 = 0 then "Fizz" else "");
          (if x % 5 = 0 then "Buzz" else "")
        |]
        |> Array.reduce ( + )
        |> function
            | "" -> sprintf "%d" x
            | __ -> __

    let genSimplified x =
        let arrayStrings = [| (if x % 3 = 0 then "Fizz" else ""); (if x % 5 = 0 then "Buzz" else "") |]
        let arrayReduced = Array.reduce (fun acc item -> acc + item) arrayStrings
        match arrayReduced with
        | "" -> sprintf "%d" x
        | __ -> __