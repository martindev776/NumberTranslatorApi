module TensTranslatorService

open IntExtensions

let TranslateTens getPrefix translateUniqueNumbers number =
    let prefix = number |> getPrefix
    let onesDigit = number |> GetDigit Ones
    let onesNumber = match onesDigit with
                     | 0 -> ""
                     | _ -> "-" + (onesDigit |> translateUniqueNumbers)

    prefix + "ty" + onesNumber