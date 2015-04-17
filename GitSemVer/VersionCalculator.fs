module VersionCalculator

open System.IO

let CalculateVersion(path:string) =
    let repo = new LibGit2Sharp.Repository(path)