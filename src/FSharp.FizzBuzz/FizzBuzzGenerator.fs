namespace FSharp.FizzBuzz

module FizzBuzzGenerator =
    let gen (x:int) = if x % 3 = 0 then "Fizz" else sprintf "%d" x
