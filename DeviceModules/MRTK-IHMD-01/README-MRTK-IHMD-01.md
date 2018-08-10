# Windows Mixed Reality IHMD (VR) device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects targeting Windows MR immersive VR (IHMD) headsets, using the MRTK for Unity SDK.  

## SDK Dependencies

* Mixed Reality Tookit for Unity (MRTK) from Microsoft 2017.4.10 https://github.com/Microsoft/MixedRealityToolkit-Unity

## Unity Settings

* Build Target: UWP (.NET)
* XR SDK: MixedReality

We recommend you use the shortcut menu Mixed Reality Toolkit > Configure > Apply Mixed Reality Project Settings
Check "Target Occluded Devices" for IHMD (VR)

To build, we recommend you use Mixed Reality Toolkit > Build Window. Quick Options: PC, Un-check "Unity C# Projects" and press "Build Unity Project"

## BridgeXR example conventions supported

### Component bridges

* Selectable
* Throwable

### Scene bridges

* PlayerRig

### Input events

* Touch, UnTouch
* Select, UnSelect

## Notes

Grab interactions are based on the Grabbable scripts (HoloToolkit-Examples/MotionControllers-GrabMechanics/Scenes/GrabMechanics scene) and its an implementation specifically for the hand controller input and not HoloLens. (See HoloLens device module for generic version).
