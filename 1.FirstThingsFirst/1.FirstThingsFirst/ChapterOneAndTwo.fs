
module ChapterOneAndTwo

open System
open MyNamespace


///return int
let sum x y =
    x + y

let square x = x * x

//return float
let sum2 (x:float) (y:float) =
    x + y

///return generic
let ret x = x

///returns unit (nothing)
let returnNothing = ()

///turple
let turple = (1, 2)

let firstValue = fst turple

let secondValue = snd turple

///list
let list = [1; 2; 3]

let extendedList = 2 :: list

let list2 = [4; 5; 6]

let listConcat = list @ list2

let listRange = [1 .. 5 .. 50]

///list comprehansion
let listComp x = [ yield x-1; yield x; yield x + 1]

///negative every second item in list
let negList x = 
    [
        let negate y = -y
        for i in 1..x do
            if i%2 = 0 then
                yield negate i
            else
                yield i
    ]

let newList = List.map square [1; 2; 3]

///options
let returnigOption a = 
    if a = 1 then
        Some(a)
    else
        None

///simplified list comprehension
let multiList x = [for i in 1..10 -> x*i ]

//[<EntryPoint>]
let main (args : string[]) =
    let a = sum 5 4
    //when want to ignore return value (return nothing-unit)
    ignore (ret "Siemka")
    0 
    