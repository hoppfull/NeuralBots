namespace Algorithms

module SearchTreeTests =
    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit

    open Algorithms.SearchTree

    [<Property>]
    let ``createTree with no data returns an empty node`` maxDepth maxChildren =
        Assert.Equal(createTree maxDepth maxChildren [], Empty)
