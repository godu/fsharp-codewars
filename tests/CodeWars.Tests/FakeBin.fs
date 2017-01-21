module CodeWars.Tests.FakeBin

open CodeWars
open System
open Xunit


[<Theory>]
[<InlineData("45385593107843568", "01011110001100111")>]
[<InlineData("509321967506747", "101000111101101")>]
[<InlineData("366058562030849490134388085", "011011110000101010000011011")>]
let ``Should `` (input, output) =
    Assert.Equal(FakeBin.fakeBin input, output)
