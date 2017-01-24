module CodeWars.Tests.SumWithoutHighestAndLowest

open CodeWars
open System
open Xunit

type MyFixtures() = 
    inherit Fixtures(
        [ 
            [| Some [6;2;1;8;10]; 16 |];
            [| Some [1;1;11;2;3]; 6 |];
            [| Some [1;2]; 0 |];
            [| Some List.empty<int>; 0 |];
            [| None; 0 |]
        ]
    )

[<Theory>]
[<ClassData(typeof<MyFixtures>)>]
let ``Should sum without highest and lowest number`` (input:int list option, output) =
    Assert.Equal(SumWithoutHighestAndLowest.sumWithoutHighestAndLowest input, output)