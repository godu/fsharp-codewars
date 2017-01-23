module CodeWars.Tests.StringRepeat

open CodeWars
open System
open Xunit

[<Theory>]
[<InlineData(6, "I", "IIIIII")>]
[<InlineData(5, "Hello", "HelloHelloHelloHelloHello")>]
let ``Should repeat string`` times pattern output =
    Assert.Equal(StringRepeat.stringRepeat times pattern, output)
