# NeuralBots
The idea is to create a simulation environment to study artificial intelligence and emergence.

## Goal
To create a toy universe with "intelligent" life.

## What will I need?
* Graphics
    * OpenGL
* Physics
    * Simple 2D physics with collisions
    * Low level programming
* Organisms
    * Neural Networks
    * Evolution
    * Sight
    * Smell

## Language choice
* **F#**
    * Strong tool support
    * Balance between high level and mid-low level constructs
    * Easy interop with **C++**
* **Haskell**
    * Decent tool support
    * **Liquid Haskell** provides strong safety
    * Decent interop with **C/C++**
* **Rust**
    * Weak tool support
    * Balance between high level and low level constructs
    * Memory safety without GC => performance
* **TypeScript**
    * Strong tool support
    * No low level constructs
    * No **C/C++** interop
    * Very good type system
    * Can run examples in the browser

I choose **F#** for now.

## Physics
The physics engine will maintain a list of physical objects and mutate them as well as a search tree for optimization.

Each physical object is called a "particle" and will have following physical properties:
* Position
* Velocity
* Mass
* Radius

Optional extra properties like stickiness, charge and gravity can be added later

Additionally each physical object much carry an ID for identification during the rendering process in order to render various objects with unique graphics.
## Graphics
* 2D world
* Camera navigation
* Physical objects

