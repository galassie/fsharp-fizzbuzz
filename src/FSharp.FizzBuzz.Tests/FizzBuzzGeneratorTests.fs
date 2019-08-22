namespace FSharp.FizzBuzz.Tests

open FSharp.FizzBuzz
open NUnit.Framework

type FizzBuzzGeneratorTests () =

    [<Test>]
    member __.TestOneReturnOne () =
        Assert.AreEqual("1", FizzBuzzGenerator.gen 1)

    [<Test>]
    member __.TestTwoReturnTwo () =
        Assert.AreEqual("2", FizzBuzzGenerator.gen 2)

    [<Test>]
    member __.TestThreeReturnFizz () =
        Assert.AreEqual("Fizz", FizzBuzzGenerator.gen 3)

    [<Test>]
    member __.TestFourReturnFour () =
        Assert.AreEqual("4", FizzBuzzGenerator.gen 4)

    [<Test>]
    member __.TestFiveReturnBuzz () =
        Assert.AreEqual("Buzz", FizzBuzzGenerator.gen 5)