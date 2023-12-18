// Takes two arguments, path and pattern
// Deleted any file in the path including sub folders that matches the pattern

open System
open System.IO

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("dmf (Delete mathcing files")

    
    let path = @"Path/to/files"
    let pattern = "*.cs"

    let files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories)

    let count = files |> Array.length

    let path = @"Path/to/files"
    let pattern = "HasUserRolesFilterAttribute.*"

    Directory.GetFiles(path, pattern, SearchOption.AllDirectories)
    |> Array.iter(fun f ->
        printfn "Delete %A" f
        File.Delete(f)
    )
    
    let hi = 45.0
    
    let temperature = 40.0

    let near x y = (x |> abs) - (y |> abs) |> abs < 5.0

    let it = if temperature |> near hi then "warm" else "cold"

    Console.WriteLine("Good bye!")
    0

