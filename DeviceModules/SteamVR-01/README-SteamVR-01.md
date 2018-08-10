# SteamVR device module for BridgeXR


Author: Parkerhill Reality Labs

## Description

Example device module. For projects targeting SteamVR runtime and OpenVR SDK. Uses elements of SteamVR/Interaction System. 

## SDK Dependencies

* SteamVR Plugin from Valve https://assetstore.unity.com/packages/templates/systems/steamvr-plugin-32647

## Unity Settings

* Build Target: Standalone
* XR SDK: OpenVR

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

Based on SteamVR Interaction System components. Player rig and component refabs derived from Samples/Scenes/Interactions_Example

Example script SteamVRInputEvents maps steamVR Hand events to Unity Events.