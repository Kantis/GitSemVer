module VersionCalculator

open System.Text.RegularExpressions
open System.IO
open LibGit2Sharp

let releaseBranchRegex =
    "^release-(?<version>\d\.\d\.\d)$"

let CurrentBranchIsReleaseBranch(repo:Repository) =
    let matches = Regex.Match(repo.Head.Name, releaseBranchRegex)
    matches.Groups.Item("version")

let GetLatestTag(repo:Repository) =
    let tags = seq { for i in repo.Tags do yield i }
    seq { for i in tags do yield i.Name}

let CalculateVersion(path:string) =
    let repo = new Repository(path)
    CurrentBranchIsReleaseBranch repo
    