namespace Mathematics

module LinearAlgebra =
    type Vec2 = Vec2 of float * float with
        member this.length = let (Vec2 (x, y)) = this in sqrt (x*x + y*y)

        static member (+) ((Vec2 (x0, y0)), (Vec2 (x1, y1))): Vec2 = Vec2 (x0 + x1, y0 + y1)

        static member (-) ((Vec2 (x0, y0)), (Vec2 (x1, y1))): Vec2 = Vec2 (x0 - x1, y0 - y1)

        static member (*) ((Vec2 (x, y)), c: float): Vec2 = Vec2 (x * c, y * c)

        static member (*) (c: float, v: Vec2): Vec2 = v * c

        static member (*) ((Vec2 (x0, y0)), (Vec2 (x1, y1))): float = x0 * x1 + y0 * y1
