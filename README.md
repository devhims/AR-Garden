# AR-Garden
Demonstrate the use of AR raycasting against detected planes and object pooling to create a virtual garden (Unity AR Foundation).

## Other Concepts Used:
1. Physics Check Sphere API to prevent flower pots from overlapping. 
2. Mesh optimisation for trading flower mesh quality with improved performance for the AR experience. 

## Demo:
[YouTube Link](https://youtu.be/TimhZEBx0bc)

## How To Build?
0. Make sure you've got an ARCore/ARKit enabled device.
1. `ARFlowers` is the desired scene inside `Scenes` folder. 
2. Switch platform to Android/iOS and build. (Not tested on iOS, but should work fine. Check the platform settings required for ARF applications before building for iOS. For Android, settings come saved with the project) 

## External Assets Used:
1. Hibiscus Free 3D model from Turbosquid: https://www.turbosquid.com/3d-models/hibiscus-chinese-rose-model-1294095
2. Mesh Optimizer Free Asset from Unity's Asset Store: https://assetstore.unity.com/packages/tools/modeling/mesh-optimizer-154517
3. FPS Counter and Graph by Nicholas (@nvjob): https://github.com/nvjob/Unity-FPS-Counter
4. Easy Object Pooling by myself: https://github.com/creativehims/Easy-Object-Pooling

## Optimise Mesh Asset Bug Fix:
1. While working in the editor and regerating meshes, keep the OptimizeMesh.cs and MeshSaveEditor.cs scripts in the "AddtionalScripts" folder. 
2. Once ready to build to your target platform, move the 2 scipts to the "Editor" folder. If not, you'll be greeted with a bunch of build errors. :)

<img src="Images/error.png" width="750">
<img src="Images/editor.png" width="500">





