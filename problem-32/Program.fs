[<EntryPoint>]
let main argv = 
    let mutable candidates = []
    let isPandigital (a:int[]) =
        let n1 = a.[0] * 10 + a.[1]
        let n2 = a.[2] * 100 + a.[3] * 10 + a.[4]
        let n3 = a.[5] * 1000 + a.[6] * 100 + a.[7] * 10 + a.[8] 
        let res = (n1 * n2) = n3
        let distincts seq = Seq.length (Seq.distinct seq) = 9
        if res && n3 > 1000 && n3 < 10000 && distincts a
            then
                printfn "%dx%d=%d" n1 n2 n3
                candidates <- n3 :: candidates
            else
                ()
    let isPandigital2 (a:int[]) =
        let n1 = a.[0] 
        let n2 = a.[1] * 1000 + a.[2] * 100 + a.[3] * 10 + a.[4]
        let n3 = a.[5] * 1000 + a.[6] * 100 + a.[7] * 10 + a.[8] 
        let res = (n1 * n2) = n3
        let distincts seq = Seq.length (Seq.distinct seq) = 9
        if res && n3 > 1000 && n3 < 10000 && distincts a
            then
                printfn "%dx%d=%d" n1 n2 n3
                candidates <- n3 :: candidates
            else
                ()

    for i1 in 1..9 do
        for i2 in 1..9 do
            for i3 in 1..9 do
                for i4 in 1..9 do
                    for i5 in 1..9 do
                        for i6 in 1..9 do
                            for i7 in 1..9 do
                                for i8 in 1..9 do
                                    for i9 in 1..9 do
                                        let candidate = [| i1; i2; i3; i4; i5; i6; i7; i8; i9 |]
                                        isPandigital candidate
                                        isPandigital2 candidate
    
    let x = Seq.distinct candidates
    x |> Seq.iter (printf "%d ")
    printfn "\n%d" (Seq.sum x)
    System.Console.ReadKey() |> ignore
    0
