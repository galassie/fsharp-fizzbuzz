namespace FSharp.FizzBuzz.Tests

open FSharp.FizzBuzz
open NUnit.Framework

type FizzBuzzGeneratorTests () =

    [<Test>]
    member __.TestOneReturnOne () =
        Assert.AreEqual("1", FizzBuzzGenerator.gen 1)
        Assert.AreEqual("1", FizzBuzzGenerator.genSimplified 1)

    [<Test>]
    member __.TestTwoReturnTwo () =
        Assert.AreEqual("2", FizzBuzzGenerator.gen 2)
        Assert.AreEqual("2", FizzBuzzGenerator.genSimplified 2)

    [<Test>]
    member __.TestThreeReturnFizz () =
        Assert.AreEqual("Fizz", FizzBuzzGenerator.gen 3)
        Assert.AreEqual("Fizz", FizzBuzzGenerator.genSimplified 3)

    [<Test>]
    member __.TestFourReturnFour () =
        Assert.AreEqual("4", FizzBuzzGenerator.gen 4)
        Assert.AreEqual("4", FizzBuzzGenerator.genSimplified 4)

    [<Test>]
    member __.TestFiveReturnBuzz () =
        Assert.AreEqual("Buzz", FizzBuzzGenerator.gen 5)
        Assert.AreEqual("Buzz", FizzBuzzGenerator.genSimplified 5)

    [<Test>]
    member __.TestFifteenReturnFizzBuzz () =
        Assert.AreEqual("FizzBuzz", FizzBuzzGenerator.gen 15)
        Assert.AreEqual("FizzBuzz", FizzBuzzGenerator.genSimplified 15)