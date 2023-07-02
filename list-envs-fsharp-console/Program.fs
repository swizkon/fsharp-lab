open System

let printSomeText() =
    let text = "Hello" + ", World"
    printfn $"{text}"

let showCommandLineArgs() =
    for arg in Environment.GetCommandLineArgs() do
        printfn $"arg = {arg}"

printSomeText()
showCommandLineArgs()
exit 0