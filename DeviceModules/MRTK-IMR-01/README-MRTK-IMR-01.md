# Windows Mixed Reality IMR (VR) device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects targeting Windows MR immersive VR (IMR) headsets, using the MRTK for Unity SDK.  

## SDK Dependencies

* Mixed Reality Tookit for Unity (MRTK) from Microsoft 2017.4.10 https://github.com/Microsoft/MixedRealityToolkit-Unity

## Unity Settings

* Build Target: UWP (.NET)
* XR SDK: MixedReality

We recommend you use the shortcut menu Mixed Reality Toolkit > Configure > Apply Mixed Reality Project Settings
Check "Target Occluded Devices" for IMR (VR)

To build, we recommend you use Mixed Reality Toolkit > Build Window. Quick Options: HoloLens, check "Unity C# Projects" and press "Build Unity Project"

 ## BridgeXR standard conventions supported

 ### Component bridges
 * Touchable
 * Throwable

 ### Scene bridges
 * Player loader

 ### Input events
 * Touch, Untouch
 * Grab, Ungrab
 * Throw

