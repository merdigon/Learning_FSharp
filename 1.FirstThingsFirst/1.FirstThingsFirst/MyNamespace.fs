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

namespace MyNameSpace.Organized

type Orginize = { color : MyNamespace.Color; thing : MyNamespace.Thing }
