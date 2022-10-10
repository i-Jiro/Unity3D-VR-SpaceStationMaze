# Unity3D-VR-SpaceStationMaze
A VR maze that takes place inside a space station using XR Interaction Toolkit.
An assignment project for NYU's AR/VR program.

[Watch Demo](https://streamable.com/lek8rq)

### Design Process
The overall process of building out the layout of the maze was great. Initially took some time to align the set pieces within ProGrid's grids.
But I once figured out how to align the pivots, prototyping an environment was stupidly easy and efficient.

To make navigation a litte easier, I changed the XR ray type to a projectile. This gives the raycast a bend that makes it more comfortable to select where you want to go.

A challenge that came up was performance.
Before, I was using realtime lighting to light up all the corridors and had severe frame drops. This was solved with by using baked lightmaps instead.
By having lights and shadows baked into the texture; A lot of processing power was saved while still maintaining beautiful lighting of the environment.

## Acknowledgments For Assets Used
- [Universe Free Sound Pack](https://assetstore.unity.com/packages/audio/ambient/sci-fi/universe-sounds-free-pack-118865)
- [Starfield Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/starfield-skybox-92717)
- [Modular Sci-Fi Corridor](https://assetstore.unity.com/packages/3d/environments/sci-fi/modular-sci-fi-corridor-142811)
- [Keycard Model](https://sketchfab.com/3d-models/keycard-model-78e47fd0e12c4401aede24e4f70853f7)


