// For more information see https://aka.ms/fsharp-console-apps

open System

//let (name, age) = (
//    InputHelper.read "name",
//    InputHelper.read "age" |> int
//    )

// printfn "Hi there %A you are %A" name age


// let (name, age) = (name, 43)
 


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Hello")
    
    let (name, age) = (
        InputHelper.read "name",
        InputHelper.read "age" |> int
        )

    printfn "Hi there %A you are %A" name age
    
    Console.WriteLine("Good bye!")
    0

