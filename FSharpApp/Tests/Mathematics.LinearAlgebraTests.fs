namespace Mathematics

module LinearAlgebraTests =
    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit

    open Mathematics.LinearAlgebra

    [<Theory>]
    [<InlineData(0., 0., 0.)>]
    [<InlineData(1., 0., 1.)>]
    [<InlineData(6., 0., 6.)>]
    [<InlineData(-7., 0., 7.)>]
    [<InlineData(-8., 0., 8.)>]
    [<InlineData(0., 8., 8.)>]
    [<InlineData(0., 2., 2.)>]
    [<InlineData(0., 7., 7.)>]
    [<InlineData(0., -9., 9.)>]
    [<InlineData(0., -3., 3.)>]
    [<InlineData(0., -4., 4.)>]
    [<InlineData(3., 4., 5.)>]
    [<InlineData(-3., 4., 5.)>]
    [<InlineData(3., -4., 5.)>]
    [<InlineData(-3., -4., 5.)>]
    [<InlineData(4., 3., 5.)>]
    [<InlineData(-4., 3., 5.)>]
    [<InlineData(4., -3., 5.)>]
    [<InlineData(-4., -3., 5.)>]
    [<InlineData(30., 40., 50.)>]
    [<InlineData(-30., 40., 50.)>]
    [<InlineData(30., -40., 50.)>]
    [<InlineData(-30., -40., 50.)>]
    [<InlineData(40., 30., 50.)>]
    [<InlineData(-40., 30., 50.)>]
    [<InlineData(40., -30., 50.)>]
    [<InlineData(-40., -30., 50.)>]
    let ``Vector length`` x y length =
        let v = Vec2 (x, y)
        Assert.Equal(length, v.length)

    [<Theory>]
    [<InlineData(0., 0., 0., 0., 0., 0.)>]
    [<InlineData(1., 0., 0., 0., 1., 0.)>]
    [<InlineData(0., 1., 0., 0., 0., 1.)>]
    [<InlineData(6., 7., 2., 8., 8., 15.)>]
    [<InlineData(8., -7., -4., 5., 4., -2.)>]
    let ``Vector addition`` x0 y0 x1 y1 x2 y2 =
        let v0 = Vec2 (x0, y0)
        let v1 = Vec2 (x1, y1)
        let v2 = Vec2 (x2, y2)
        Assert.Equal(v2, v0 + v1)

    [<Theory>]
    [<InlineData(0., 0., 0., 0., 0., 0.)>]
    [<InlineData(1., 0., 0., 0., 1., 0.)>]
    [<InlineData(0., 1., 0., 0., 0., 1.)>]
    [<InlineData(6., 7., 2., 8., 4., -1.)>]
    [<InlineData(8., -7., -4., 5., 12., -12.)>]
    let ``Vector subtraction`` x0 y0 x1 y1 x2 y2 =
        let v0 = Vec2 (x0, y0)
        let v1 = Vec2 (x1, y1)
        let v2 = Vec2 (x2, y2)
        Assert.Equal(v2, v0 - v1)

    [<Theory>]
    [<InlineData(0., 0., 0., 0., 0.)>]
    [<InlineData(0., 0., 5., 0., 0.)>]
    [<InlineData(0., 0., 6., 0., 0.)>]
    [<InlineData(0., 0., -2., 0., 0.)>]
    [<InlineData(0., 0., -6., 0., 0.)>]
    [<InlineData(0., 0., -4., 0., 0.)>]
    [<InlineData(0., 0., 3., 0., 0.)>]
    [<InlineData(4., 7., 3., 12., 21.)>]
    [<InlineData(8., -3., 4., 32., -12.)>]
    [<InlineData(-5., -5., 2., -10., -10.)>]
    [<InlineData(-5., -5., -2., 10., 10.)>]
    let ``Vector-scalar product`` x0 y0 c x1 y1 =
        let v0 = Vec2 (x0, y0)
        let v1 = Vec2 (x1, y1)
        Assert.Equal(v1, c * v0)
        Assert.Equal(v1, v0 * c)

    [<Theory>]
    [<InlineData(0., 0., 0., 0., 0.)>]
    [<InlineData(0., 0., 2., -4., 0.)>]
    [<InlineData(2., -4., 0., 0., 0.)>]
    [<InlineData(4., -6., 2., 9., -46)>]
    [<InlineData(4., 9., 2., -6., -46)>]
    [<InlineData(2., -6., 4., 9., -46)>]
    [<InlineData(2., 9., 4., -6., -46)>]
    let ``Vector dot product`` x0 y0 x1 y1 result =
        let v0 = Vec2 (x0, y0)
        let v1 = Vec2 (x1, y1)
        Assert.Equal(result, v0 * v1)
