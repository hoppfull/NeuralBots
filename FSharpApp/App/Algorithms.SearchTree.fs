namespace Algorithms

module SearchTree =
    open Mathematics.LinearAlgebra

    type Rectangle = { T: float; B: float; L: float; R: float }

    type Children<'T> = (Vec2 * 'T) list

    type Node<'T> = Branch of Rectangle * 'T Node * 'T Node
                  | Leaf   of Rectangle * 'T Children
                  | Empty

    let ``is point inside border?`` { T=t; B=b; L=l; R=r } (Vec2 (x, y), _): bool =
        x >= l && x <= r && y >= b && y <= t

    let ``are borders intersecting`` { T=t0; B=b0; L=l0; R=r0 } { T=t1; B=b1; L=l1; R=r1 }: bool =
        t0 >= b1 && b0 <= t1 && r0 >= l1 && l0 <= r1

    let rec search<'T> (node: 'T Node) (area: Rectangle): 'T Children =
        match node with
        | Empty                        -> []
        | Leaf (border, children)      -> List.filter (``is point inside border?`` border) children
        | Branch (border, left, right) -> if ``are borders intersecting`` border area
                                          then List.append (search left area) (search right area)
                                          else []

    let ``create bounding rectangle`` (points: Children<_>): Rectangle =
        let f { T=t; B=b; L=l; R=r } (Vec2 (x, y), _) = { T=max t y; B=min b y; L=min l x; R=max r x }
        match points with
        | []               -> { T=0.; B=0.; L=0.; R=0. }
        | ((Vec2 (x, y), _)::_) -> { T=y; B=y; L=x; R=x }
        |> List.fold f <| points

    let ``is point in left or top half area?`` { T=t; B=b; L=l; R=r } (Vec2 (x, y), _): bool =
        let halfHeight = (t - b) / 2.
        let halfWidth = (r - l) / 2.
        if halfHeight > halfWidth then y > b + halfHeight else x > l + halfWidth

    let ``is point in right or bottom half area?`` (area: Rectangle): Vec2 * _ -> bool =
        not << ``is point in left or top half area?`` area

    type MaxTreeDepth    = int
    type MaxLeafChildren = int

    let rec ``generate searchtree``<'T> (depth: int) (maxDepth: MaxTreeDepth) (maxChildren: MaxLeafChildren) (items: 'T Children): 'T Node =
        let border = ``create bounding rectangle`` items
        match items with
        | [] -> Empty
        | xs when xs.Length > maxChildren && depth < maxDepth -> let genNextBranch = ``generate searchtree`` (depth + 1) maxDepth maxChildren
                                                                 let leftOrTopBranch = genNextBranch (List.filter (``is point in left or top half area?`` border) items)
                                                                 let rightOrBottomBranch = genNextBranch (List.filter (``is point in right or bottom half area?`` border) items)
                                                                 Branch (border, leftOrTopBranch, rightOrBottomBranch)
        | _ -> Leaf (border, items)

    let createTree<'T> (maxDepth: MaxTreeDepth) (maxChildren: MaxLeafChildren) (items: 'T Children): 'T Node =
        ``generate searchtree`` 0 maxDepth maxChildren items
