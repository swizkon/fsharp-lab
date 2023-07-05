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
    
    //let (name, age) = (
    //    InputHelper.read "name",
    //    InputHelper.read "age" |> int
    //    )

    //printfn "Hi there %A you are %A" name age

    // let ages =
    [8;14;43;43]
    |> List.map (fun a -> a * a)
    |> List.iter (fun v -> printfn "Square %A" v)

    let numbers = [0 .. 10]
        
    let hihi = List.map (fun x -> x * x) numbers

    hihi |> List.iter (fun y -> printfn "Iter %A" y) // hihi


    let sum = List.sum numbers
    printfn "Sum is %A" sum
    
    let sum = numbers |> List.sum
    printfn "Sum is %A" sum
    
    Console.WriteLine("Good bye!")
    0

