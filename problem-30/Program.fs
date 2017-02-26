let sumOfPowers ns p =
    ns |> List.map (fun n -> pown n p) |> List.sum

let rec numberAsDigits n digits =
    if n = 0 then
        digits
    else
        n % 10 :: numberAsDigits (n / 10) digits

[<EntryPoint>]
let main argv = 
    let candidates = [ 2 .. 1000000 ]
    let sumOfFifthPowers = fun n -> sumOfPowers (numberAsDigits n []) 5
    let list = candidates |> List.filter (fun n -> sumOfFifthPowers n = n)
    let sum = list |> List.sum
    printfn "%d" sum
    System.Console.ReadKey() |> ignore
    0
