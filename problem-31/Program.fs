[<EntryPoint>]
let main argv = 
    let mutable count = 0;
    let currency = List.rev [ 1; 2; 5; 10; 20; 50; 100; 200 ]
    let rec matching (coins:List<int>) (current:int) (target:int) = 
        match (current + coins.Head) with
        | x when x = target -> (count <- count + 1; search coins.Tail 0 target)
        | x when x > target -> search coins.Tail x target
        | x when x < target -> search coins x target
        | _ -> ()
    and search (coins:List<int>) (current:int) (target:int) =
        if coins = []
        then ()
        else matching coins current target
    search currency 0 200
    printfn "%d" count
    System.Console.ReadKey() |> ignore
    0
