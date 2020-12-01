namespace AdventFSharp20

module DayMain =
    open System
    open InputHandler

    let day2019_1 d b= 
        let data = 
            getDayFn d b
            |> readLongCSV

        

