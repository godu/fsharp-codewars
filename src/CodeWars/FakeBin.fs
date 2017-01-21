namespace CodeWars

open System

module FakeBin =
    let fakeBin = String.map( function 
        | i when i < '5' -> '0'
        | _ -> '1'
    )
