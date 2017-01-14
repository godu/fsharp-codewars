module CodeWars.Tests.Multiply

open CodeWars
open System
open Xunit

[<Theory>]
[<InlineData(1, 1, 1)>]
[<InlineData(0, 1, 0)>]
[<InlineData(3, 4, 12)>]
let ``Should Multiply`` (a, b, c) =
    Assert.Equal(Multiply.multiply a b, c)
