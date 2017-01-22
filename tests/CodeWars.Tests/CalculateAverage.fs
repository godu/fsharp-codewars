module CodeWars.Tests.CalculateAverage

open CodeWars
open System
open Xunit

[<Theory>]
[<InlineData(1.0, 1.0, 1.0, 1.0, 1.0)>]
[<InlineData(0.0, 1.0, 2.0, 3.0, 1.5)>]
[<InlineData(1.0, 2.0, 3.0, 4.0, 2.5)>]
let ``Should calculare average`` (a, b, c, d, output) =
    Assert.Equal(CalculateAverage.calculateAverage [|a;b;c;d|], output)