module CodeWars.Tests.Hello

open CodeWars
open System
open Xunit

[<Fact>]
let ``Should Return Hello Foo`` () =
    Assert.Equal(Hello.hello "Foo", "Hello Foo")
