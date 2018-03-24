open System


let square n = n * n;


let sumOfSquaresOf10FirstIntegers = 
    [1..10]
    |> List.map square
    |> List.sum


[<EntryPoint>]
let main argv =
    printfn "Knowledge-FunctionalProgramming-Example02"
    printfn "-----------------------------------------\n"

    printfn "Sum of squares of the first ten integer numbers = %i" 
            sumOfSquaresOf10FirstIntegers

    printfn "\nPress any key to quit this program..."
    Console.ReadKey() |> ignore

    0 // return an integer exit code
