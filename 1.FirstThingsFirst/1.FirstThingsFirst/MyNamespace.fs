namespace MyNamespace

type Color =
    | Red
    | Green
    | Blue
    | Yellow

type Thing =
    | Ball
    | Car
    | House

///just mix words from Thing with "er"
type Things = 
    | Baller of Color
    | Carer of Color

    member this.Shape = 
        match this with
        | Baller(_) -> "Square"
        | Carer(_) -> "I dont know"

type Nullable = HasValue of int | Null

///recursive types
type Statement = 
    | Get of Expresion
    | Set of Statement

and Expresion = 
    | Print of Statement
    | Save of Expresion

///records
type Person = {First : string; Surname : string; Age : int}

namespace MyNameSpace.Organized

type Orginize = { color : MyNamespace.Color; thing : MyNamespace.Thing }
