module IntExtensions

let Between min max number =
    min <= number && number <= max

type DigitPlaces =
    | None
    | Ones
    | Tens

let GetDigit digitPlace number =

    let MapDigitPlaces digit = 
        match digit with
        | 0 -> Ones
        | 1 -> Tens
        | _ -> None
    
    let IntToDict (number: int) =     
        (number |> string).ToCharArray()
        |> Array.map (fun x -> x |> string |> int)
        |> Array.rev
        |> Array.indexed
        |> Array.map (fun (index, digit) -> (index |> MapDigitPlaces, digit))
        |> dict

    number
    |> IntToDict
    |> (fun x -> x.[digitPlace])