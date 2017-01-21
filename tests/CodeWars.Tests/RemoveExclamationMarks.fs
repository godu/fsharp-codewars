module CodeWars.Tests.RemoveExclamationMarks

open CodeWars
open System
open Xunit


[<Theory>]
[<InlineData("Hello World!", "Hello World")>]
let ``Should remove exclamation marks`` (input, output) =
    Assert.Equal(RemoveExclamationMarks.removeExclamationMarks input, output)
