use std;
#[derive(Clone, Copy, PartialEq, Debug)]
pub struct Vec2 {
    pub x: f32,
    pub y: f32,
}

impl std::ops::Add<Vec2> for Vec2 {
    type Output = Vec2;
    fn add(self, _rhs: Vec2) -> Vec2 {
        Vec2 {
            x: self.x + _rhs.x,
            y: self.y + _rhs.y,
        }
    }
}

impl std::ops::Mul<Vec2> for f32 {
    type Output = Vec2;
    fn mul(self, _rhs: Vec2) -> Vec2 {
        Vec2 {
            x: _rhs.x * self,
            y: _rhs.y * self,
        }
    }
}

impl std::ops::Mul<f32> for Vec2 {
    type Output = Vec2;
    fn mul(self, _rhs: f32) -> Vec2 {
        Vec2 {
            x: self.x * _rhs,
            y: self.y * _rhs,
        }
    }
}

impl std::ops::Mul<Vec2> for Vec2 {
    type Output = f32;
    fn mul(self, _rhs: Vec2) -> f32 {
        self.x * _rhs.x + self.y * _rhs.y
    }
}
