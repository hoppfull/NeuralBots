namespace Algorithms

module SearchTree =
    open Mathematics.LinearAlgebra

    type Rectangle = { T: float; B: float; L: float; R: float }

    type Children<'T> = (Vec2 * 'T) list

    type Node<'T> = Branch of Rectangle * 'T Node * 'T Node
                  | Leaf   of Rectangle * 'T Children
                  | Empty

    val search<'T> : 'T Node -> Rectangle -> 'T Children

    type MaxTreeDepth    = int
    type MaxLeafChildren = int

    val createTree<'T> : MaxTreeDepth -> MaxLeafChildren -> 'T Children -> 'T Node
