namespace FSharp.FizzBuzz.Tests

open FSharp.FizzBuzz
open NUnit.Framework

type FizzBuzzGeneratorTests () =

    [<Test>]
    member this.TestOne () =
        Assert.AreEqual(FizzBuzzGenerator.gen 1, 1)
