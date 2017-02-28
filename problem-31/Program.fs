[<EntryPoint>]
let main argv = 
    let mutable count = 0
    let target = 200
    let currency = List.rev [ 1; 2; 5; 10; 20; 50; 100; 200 ]
    let rec search sum current =
        if sum = target then
            count <- count + 1
        elif sum > target then
            ()
        else
            for c in currency do
                if c > current then ()
                else search (sum + c) c
    search 0 200
    printfn "%d" count
    System.Console.ReadKey() |> ignore
    0
