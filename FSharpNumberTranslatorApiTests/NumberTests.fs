module FSharpNumberTranslatorApiTests

open NUnit.Framework
open IntExtensions
open UniqueNumberTranslatorService
open TeensTranslatorService
open TensTranslatorService

[<Test>]
let TestGetDigit() =
    let expected = [|3; 1|]
    let actual = [|(31 |> GetDigit DigitPlaces.Tens);
                   (31 |> GetDigit DigitPlaces.Ones)|]

    Assert.AreEqual(expected, actual)

[<Test>]
let TestUniqueNumbers() =    
    let TranslateUniqueNumbersWithRepo =
        TranslateUniqueNumbers (fun _ -> "zero")

    let expected = "zero"
    let actual = 0 |> TranslateUniqueNumbersWithRepo
    
    Assert.AreEqual(expected, actual)

[<Test>]
let TestTeens() =
    let expected = "thirteen"
    let actual = 13 |> TranslateTeens (fun _ -> "thir")

    Assert.AreEqual(expected, actual)

[<Test>]
let TestTranslateTensWithZeroAtEnd() =
    let expected = "twenty"
    let translateUniqueNumbers = (fun _ -> "")
    let getPrefixService = (fun _ -> "twen")
    let actual = 20 |> TranslateTens getPrefixService translateUniqueNumbers

    Assert.AreEqual(expected, actual)

[<Test>]
let TestTranslateTensWithNonZeroAtEnd() =
    let expected = "twenty-two"
    let translateUniqueNumbers = (fun _ -> "two")
    let getPrefix = (fun _ -> "twen")
    let actual = 22 |> TranslateTens getPrefix translateUniqueNumbers

    Assert.AreEqual(expected, actual)