module NumberPrefixRepository

open NumberPrefixTable

let Get number =
    table
    |> Array.find (fun x -> x.Number = number)
    |> (fun x -> x.Text)