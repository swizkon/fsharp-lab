# f# - fsi
## Interactive

https://learn.microsoft.com/en-us/dotnet/fsharp/tools/fsharp-interactive/


---
Launch interactive cli
```
$ fsi
> #help;;
```

---
Run a F#-script and exit
```
$ dotnet fsi .\printfn.fsx
$ Hello, F#
```

---
Load and exec a F#-script inside fsi
```
# Start the fsi
$ dotnet fsi
> #load "printfn.fsx";;
[Loading C:\path\to\printfn.fsx]
Hello, F#
module FSI_0001.Printfn
```