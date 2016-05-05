module ChapterThree

let justGiveMe x =
    x

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

///recursive functions
let rec factorial x =
    if x = 1 then
        1
    else
        x * factorial (x-1)

///mutual recursion
let rec left x =
    right x
and right x =
    left x

///operator functions
let (===) (str : string) (secstr : string) =
    str.Equals(secstr)

let count x y =
    y x

///pipe
let sup = factorial 2 |> functionalSum

///composition
let adding =
    (+) >> count 5

///pattern matching
let onlyEven x =
    match (justGiveMe x) % 2 = 0 with
    | true -> Some(x)
    | false -> None

let myOwnAnd x y =
    match x, y with
    | true, true -> true
    | _, _ -> false

///named pattern
let sayHello x =
    match x with
    | "Szymon" -> printfn "Hello my dear friend"
    | x -> printfn "I don't know you, %s" x

///match against existing value
[<Literal>]
let MagicValue = 2

let checkIfMagic x =
    match x with
    | MagicValue -> printfn "Yes, magic!!"
    | x -> printfn "%d is not magic!" x

///guards
let lessOrGreaterThanTwo x =
    match x with
    | _ when x > 2 -> "Greater"
    | _ when x < 2 -> "Less"
    | _ -> "Equals"


[<EntryPoint>]
let main (args : string[]) =    
    0

