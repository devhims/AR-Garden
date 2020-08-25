# AR-Garden
Use AR raycasting against detected planes and object pooling to create a virtual garden (Unity AR Foundation)

## Other Concepts Used:
1. Physics Check Sphere API to prevent flower pots from overlapping. 
2. Mesh optimisation for trading mesh quality with improved performance. 


## How To Build?
1. `AR Flowers` is the desired scene inside `Scenes` folder. 
2. Switch platform to Android/iOS. (Not tested on iOS, but should work fine. Check the platform settings required for ARF applications before building for iOS. For Android, settings come saved with the project) 

## Optimise Mesh Asset Bug Fix:
1. While working in the editor and regerating meshes, keep the OptimizeMesh.cs and MeshSaveEditor.cs scripts in the AddtionalScripts folder. 
2. Once ready to build to your target platform, move the 2 scipts in the Editor folder . 

