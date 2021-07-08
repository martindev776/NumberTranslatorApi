module NumberTranslatorComposer

open NumberTranslatorService
open UniqueNumberTranslatorService
open PrefixService

let TranslateUniqueNumbersWithRepo =
    TranslateUniqueNumbers UniqueNumberRepository.Get

let GetPrefixWithRepo =
    GetPrefix NumberPrefixRepository.Get TranslateUniqueNumbersWithRepo

let Translate number =
    number |> Translate TranslateUniqueNumbersWithRepo GetPrefixWithRepo