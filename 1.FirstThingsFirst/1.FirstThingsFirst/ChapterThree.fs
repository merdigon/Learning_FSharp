module ChapterThree

///why doing everything in function is better
let imperativeSum number =
    let mutable total = number
    total <- total + 2
    total

let functionalSum number =
    number
    |> (+) 2

///mapping for specified list type with lambda function
let mapping (x:list<int>) =
    List.map (fun x -> x + 1) x



[<EntryPoint>]
let main (args : string[]) =    
    0

