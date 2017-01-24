module CodeWars.Tests.HowMuchILoveYou

open CodeWars
open System
open Xunit

[<Theory>]
[<InlineData(7, "I love you")>]
[<InlineData(3, "a lot")>]
[<InlineData(6, "not at all")>]
let ``Should return how much i love you`` (petals, expected) =
    Assert.Equal(HowMuchILoveYou.howMuchILoveYou petals, expected)
