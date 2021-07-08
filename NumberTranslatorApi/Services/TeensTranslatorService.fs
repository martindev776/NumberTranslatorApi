module TeensTranslatorService

open IntExtensions

let TranslateTeens getPrefix number =
    match number with    
    | n when n |> Between 13 19 -> (n |> getPrefix) + "teen"
    | _ -> $"(TranslateTeens) Can't translate the number: {number}"