namespace Physics.Tests

module EngineTests =
    open Xunit
    open FsCheck
    open FsCheck.Xunit

    open Physics

    [<Fact>]
    let ``f 123 = 246`` () =
        Assert.True(Engine.f 123 = 246)

    [<Property>]
    let ``f x <> x except when f 0`` x =
        if x = 0
        then Engine.f x = x
        else Engine.f x <> x

    [<Property>]
    let ``f x is positive or negative when x is positive or negative`` = function
                      | x when x > 0 -> Engine.f x > x
                      | x when x < 0 -> Engine.f x < x
                      | x -> Engine.f x = x

    [<Theory>]
    [<InlineData (6, 12)>]
    [<InlineData (7, 14)>]
    [<InlineData (8, 16)>]
    [<InlineData (9, 18)>]
    let ``f x theory`` x y =
        Assert.Equal(y, Engine.f x)
