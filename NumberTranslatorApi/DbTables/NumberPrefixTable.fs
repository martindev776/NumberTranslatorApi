module NumberPrefixTable

type NumberPrefix = {
    Number: int
    Text: string
}

let table = 
    [|  
        {Number = 2; Text = "twen"}
        {Number = 3; Text = "thir"}
        {Number = 4; Text = "for"}
        {Number = 5; Text = "fif"}
        {Number = 8; Text = "eigh"}
    |]