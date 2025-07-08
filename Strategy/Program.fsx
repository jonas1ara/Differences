open System

type Shape = 
    | Circle of radius: float
    | Rectangle of width: float * height: float
    | Triangle of baseline: float * height: float
    | Polygon of apothem: float * perimeter: float

let area shape =
    match shape with
    | Circle radius -> Math.PI * radius * radius
    | Rectangle (width, height) -> width * height
    | Triangle (baseline, height) -> 0.5 * baseline * height
    | Polygon (apothem, perimeter) -> (apothem * perimeter) / 2.0

let circle = Circle 10.0
let rectangle = Rectangle (4.0, 2.0)
let triangle = Triangle (5.0, 4.0)

let shape = [circle; rectangle; triangle; Rectangle(10,20); Polygon(10,15)]
let results = shape |> List.map area

printfn "%A" results

