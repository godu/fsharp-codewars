module CodeWars.Tests.CalculateAverage

open CodeWars
open System
open Xunit

type ClassDataBase(generator : obj [] seq) = 
    interface seq<obj []> with
        member this.GetEnumerator() = generator.GetEnumerator()
        member this.GetEnumerator() = 
            generator.GetEnumerator() :> System.Collections.IEnumerator

type Fixtures() = 
    inherit ClassDataBase(
        [ 
            [| [1.0;1.0;1.0]; 1.0 |];
            [| [1.0;2.0;3.0]; 2.0 |];
            [| [1.0;2.0;3.0;4.0]; 2.5 |]
            [| [1.0;2.0;3.0;4.0;5.0]; 3.0 |]
            [| [1.0;2.0;3.0;4.5;6.5]; 3.4 |]
            [| [1.5;2.5;3.5;4.5;5.5;6.5;7.5]; 4.5 |]
        ]
    )

[<Theory>]
[<ClassData(typeof<Fixtures>)>]
let ``Should calculare average`` (input, output) =
    Assert.Equal(CalculateAverage.calculateAverage input, output)