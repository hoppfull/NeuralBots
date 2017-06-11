#[cfg(test)]
mod vectortests {
    use linalg::vector::Vec2;
    #[test]
    fn vec2_vec2_addition_test() {
        let v0: Vec2 = Vec2 { x: 4., y: 3. };
        let v1: Vec2 = Vec2 { x: -3., y: 8. };
        let v2: Vec2 = v0 + v1;
        let expected: Vec2 = Vec2 {
            x: 4. + -3.,
            y: 3. + 8.,
        };
        assert_eq!(v2, expected);
    }

    #[test]
    fn vec2_scalar_multiplication_test() {
        let v0: Vec2 = Vec2 { x: -8., y: 14. };
        let v1: Vec2 = v0 * 3.;
        let expected: Vec2 = Vec2 {
            x: -8. * 3.,
            y: 14. * 3.,
        };
        assert_eq!(v1, expected);
    }

    #[test]
    fn scalar_vec2_multiplication_test() {
        let v0: Vec2 = Vec2 { x: 16., y: 24. };
        let v1: Vec2 = 2.5 * v0;
        let expected: Vec2 = Vec2 {
            x: 16. * 2.5,
            y: 24. * 2.5,
        };
        assert_eq!(v1, expected);
    }

    #[test]
    fn vec2_dot_product_test() {
        let v0: Vec2 = Vec2 { x: 17., y: 18. };
        let v1: Vec2 = Vec2 { x: 3., y: 9. };
        let v2: f32 = v0 * v1;
        let expected: f32 = 17. * 3. + 18. * 9.;
        assert_eq!(v2, expected);
    }
}
