# VRTK device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects using the VRTK (Virtual Reality Toolkit) SDK. 

## SDK Dependencies

* VRTK 3.2.1 https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131
* which references other device SDK, such as SteamVR Plugin from Valve https://assetstore.unity.com/packages/templates/systems/steamvr-plugin-32647

## Unity Settings

* Build Target: Standalone
* XR SDK: based on your configuration (eg. OpenVR)

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

Player rig and component refabs derived from demo scene Examples/005_Controller_BasicObjectGrabbing and 004_CameraRig_BasicTeleport

The controller objects (in player rig) have InteractTouch, InteractGrab and InteractUse to generate those events on the objects.