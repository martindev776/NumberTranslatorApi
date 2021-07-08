module NumberTranslatorService

open TeensTranslatorService
open TensTranslatorService
open IntExtensions

let Translate translateUniqueNumbersWithRepo getPrefixWithRepo number =
    match number with    
    | n when n |> Between 0 12 -> n |> translateUniqueNumbersWithRepo    
    | n when n |> Between 13 19 -> n |> TranslateTeens getPrefixWithRepo    
    | n when n |> Between 20 99 -> n |> TranslateTens getPrefixWithRepo translateUniqueNumbersWithRepo
    | _ -> $"(Translate) Can't translate the number: {number}"    