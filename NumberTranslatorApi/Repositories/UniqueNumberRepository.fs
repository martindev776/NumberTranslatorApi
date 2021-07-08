module UniqueNumberRepository

open UniqueNumbersTable

let Get number =
    table 
    |> Array.find (fun x -> x.Number = number)
    |> (fun x -> x.Text)