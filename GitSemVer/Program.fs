// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open VersionCalculator;
open System.IO;

[<EntryPoint>]
let main argv = 
    let argumentCount = argv.Length
    if argumentCount > 1 then
        printfn "Invalid amount of arguments."
    elif argumentCount = 1 then
        CalculateVersion argv.[0] 
        |> printfn "%A"
    else 
        Directory.GetCurrentDirectory()
        |> CalculateVersion 
        |> printfn "%A"
    0 // return an integer exit code
