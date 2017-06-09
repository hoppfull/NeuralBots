namespace Mathematics

module LinearAlgebra =
    type Vec2 = Vec2 of float * float with
        member length : float

        static member (+) : Vec2 * Vec2 -> Vec2

        static member (-) : Vec2 * Vec2 -> Vec2

        static member (*) : Vec2 * float -> Vec2

        static member (*) : float * Vec2 -> Vec2

        static member (*) : Vec2 * Vec2 -> float
