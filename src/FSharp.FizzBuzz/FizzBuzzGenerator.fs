namespace FSharp.FizzBuzz

module FizzBuzzGenerator =
    let gen (x:int) = 
        if x % 3 = 0 then "Fizz"
        elif x % 5 = 0 then "Buzz"
        else sprintf "%d" x
