namespace CodeWars

open System

module SumWithoutHighestAndLowest =
    let getTail list =
        match list with
        | head :: tail -> tail
        | _ -> list

    let sumWithoutHighestAndLowest =
        function
        | Some [] | Some [_] -> 0
        | Some list -> List.sum list - List.max list - List.min list
        | _ -> 0