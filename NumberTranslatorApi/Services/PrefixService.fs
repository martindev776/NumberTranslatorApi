module PrefixService

open IntExtensions

let GetPrefix numberPrefixRepo translateUniqueNumbers number =    
    let startNumber = 
        match number with        
        | n when n < 20 -> n |> GetDigit DigitPlaces.Ones        
        | _ -> number |> GetDigit DigitPlaces.Tens

    match startNumber with 
        | 4 when number > 14 -> startNumber |> numberPrefixRepo
        | 2 | 3 | 5 | 8 -> startNumber |> numberPrefixRepo
        | 4 | 6 | 7 | 9 -> startNumber |> translateUniqueNumbers        
        | _ -> $"(GetPrefixes) Can't find prefix for the number: {number}"