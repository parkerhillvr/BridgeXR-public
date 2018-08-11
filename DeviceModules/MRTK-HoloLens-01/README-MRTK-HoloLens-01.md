# Windows Mixed Reality HoloLens device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects targeting Microsoft HoloLens headsets, using the MRTK for Unity SDK.  

## SDK Dependencies

* Mixed Reality Tookit for Unity (MRTK) from Microsoft 2017.4.10 https://github.com/Microsoft/MixedRealityToolkit-Unity

## Unity Settings

* Build Target: UWP (.NET)
* XR SDK: MixedReality

We recommend you use the shortcut menu Mixed Reality Toolkit > Configure > Apply Mixed Reality Project Settings
Uncheck "Target Occluded Devices" for HoloLens

To build, we recommend you use Mixed Reality Toolkit > Build Window. Quick Options: HoloLens, check "Unity C# Projects" and press "Build Unity Project"

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

PlayerRig positioned at ( ) and scene table remains at default position rather than letting user holographically place the scene
Grab interaction uses the HandGrabbable component. 
Ground plane uses a transparent ground plane at (0,0,0) rather than spatial map.

