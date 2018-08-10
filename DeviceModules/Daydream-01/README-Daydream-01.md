# Daydream device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects targeting Daydream devices and SDK. Uses elements of Daydream Elements example package.

## SDK Dependencies

* Daydream Elements v1.12 https://github.com/googlevr/daydream-elements/releases
* GVR SDK for Unity v1.150.11 https://github.com/googlevr/gvr-unity-sdk/releases

Note: Install Daydream Elements first, then let GVR SDK overwrite newer files.

## Unity Settings

* Build Target: Android
* XR SDK: Daydream

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

Includes a DaydreamInputEvents script that maps hover/unhover and click/unclick to Unity Events. This component implements click to grab, unclick to release (differs from Daydream Elements click to grab, click again to release).

 