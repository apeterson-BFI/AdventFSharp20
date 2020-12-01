namespace AdventFSharp20

module InputHandler =
    open System
    
    let readLines fn =
        System.IO.File.ReadAllLines(fn)
        |> List.ofArray

    let readCSV (line : string) = 
        line.Split(',')
        |> List.ofArray

    let readLongLine line = 
        line 

    let readLongCSV fn =
        fn
        |> readLines
        |> List.map (fun x -> x |> readCSV |> List.map Int64.Parse)

    let getDayFn dayn test = 
        match test with
        | true -> sprintf "day%isample.txt" dayn
        | false -> sprintf "day%iinput.txt" dayn