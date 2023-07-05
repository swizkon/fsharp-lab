// Takes two arguments, path and pattern
// Check for file ratios

open System
open System.IO


let file_line_count file = 
    // printfn "Read lines in %A" file
    File.ReadAllLines file |> Array.length

// type 

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("gfr (Generated Files Ratio")

    let path = @"C:\dev\azuredevops\volvogroup\Penta-ECOM2.0-ms"
    let pattern = "*.cs"
    
    let all_code_files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
    
    all_code_files
        |> Array.length 
        |> printfn "Number of *.cs files %A"

    let significant_files = all_code_files |> Array.filter (fun f -> f.Contains(".g.cs") = false)

    significant_files
        |> Array.length 
        |> printfn "Number of significant files %A"

    let generated_files = all_code_files |> Array.filter (fun f -> f.Contains(".g.cs"))

    generated_files
        |> Array.length
        |> printfn "Number of generated   files %A"

    //generated_files
    //    |> Array.map(fun f -> file_line_count(f))
    //    |> Array.sum        
    //    |> printfn "Number of generated lines %A"
        
    //all_code_files
    //    |> Array.map(fun f -> file_line_count(f))
    //    |> Array.sum        
    //    |> printfn "Number of all lines %A"

    // Generated lines of code: 41928
    // All lines of code: 403183

    // generated_files_total_lines.Sum
    // To some SLOC stats...

    // let totalLinesOfCode = 




    // |> Array.count

    //|> Array.iter(fun f ->
    //    printfn "Delete %A" f
    //    File.Delete(f)
    //)
    
    0
