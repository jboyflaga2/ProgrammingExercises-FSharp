open System

//[<EntryPoint>]
let main argv = 
    printfn "Hello World" 
    Console.ReadLine() |> ignore
    0

main [|""|]

let returnString (str: string) = 
    str
    
    
// demonstrating function with explicit types for parameters
[<EntryPoint>]
let main2 (argv: string[]) =
    printfn "Hello"
    Console.ReadLine() |> ignore
    0


