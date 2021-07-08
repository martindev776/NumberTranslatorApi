module UniqueNumberTranslatorService

open IntExtensions

let TranslateUniqueNumbers repo number =
    match number with    
    | n when n |> Between 0 12 -> n |> repo
    | _ -> $"(TranslateOnes) Can't translate the number: {number}"