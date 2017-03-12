[<EntryPoint>]
let main argv = 

    let extractFrac n m =
        [
            if n/10 = m/10 then yield (n%10, m%10)
            if n/10 = m%10 then yield (n%10, m/10)
            if n%10 = m%10 then yield (n/10, m/10)
            if n%10 = m/10 then yield (n/10, m%10)
        ]

    let fracString n m = (string n) + "/" + (string m)

    let fracValue t = decimal (fst t) / decimal (snd t)

    let fracListString l =
        l 
        |> Seq.map (fun x -> (fracString (fst x) (snd x)) + " ")
        |> Seq.reduce (fun a x -> a + x)

    let cancellingFrac i j = 
        extractFrac i j
        |> Seq.filter (fun x -> snd x > 0)
        |> Seq.map (fun x -> fracValue x)
        |> Seq.filter (fun x -> x = fracValue (i,j))

    let isCancelling i j = Seq.isEmpty (cancellingFrac i j) = false

    let candidates = 
        [
            for i in [10..99] do
                for j in [10..99] do
                    if i <> j && j % 10 <> 0 && i < j then yield (i,j)
        ]

    let res = candidates |> Seq.filter (fun x -> isCancelling (fst x) (snd x))
    printfn "%A" res

    let frac = res |> Seq.reduce (fun a x -> ((fst a) * (fst x),(snd a) * (snd x)))
    printfn "%d %d" (fst frac) (snd frac)

    System.Console.ReadKey() |> ignore
    0
