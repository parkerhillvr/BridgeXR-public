# BridgeXR-public

This repository contains example device modules and scenes for the Parkerhill BridgeXR SDK manager and utilities for Unity.

## Device Modules

The DeviceModules/ folder contains example bridges for a growing list of VR and AR devices and SDKs. See the respective README files for additional dependencies. We recommend you clone this repository and then copy just the device module folder(s) you want into your Unity Assets/ folder.

We welcome contributions to this repository. 

* Add a different device/SDK, please be sure to support the core bridges and input ids used in the example scenes. 
* Offer an alternative implementation for a device or SDK, you can add a device module with an incremented postfix. For example, a Daydream implementation using different arm models could be named Daydream-02.
* Extend and build upon the features of a device, please include a new example scene along with the device component refabs, prefabs, scenes.

Please clone the repository, make changes in a branch, and submit a pull request.

## Examples

The example scenes demonstrate use of BridgeXR bridges for "Create Once, Build Many" to target different VR and VR devices using various SDKs, specifically using the bridges in the example DeviceModules.

### Bridge Interactable Example scene

This example scene includes objects:

* PlayerRigLoader - uses Bxr Scene Bridge Loader to load the player rig and camera
* GrabCube - uses Bxr Component Bridge Loader to make the cube grabbable and throwable. Highlights when touched. Activates the splotlight to follow it when grabbed.
* PushButton - uses Bxr Component Bridge Load to make a button. Highlights a child object when touched. Displayed a pressed button when selected, and toggles off the spotlight
* Teleports - depending on the SDK, uses teleport points to move the player between locations in the scene 

Component bridges:

* Throwable Bridge Example - uses a bridge asset (scriptable object)
* Clickable Bridge Example - uses local references

Input Identifiers:

* Touch-xr
* UnTouch-xr
* Select-xr
* UnSelect-xr


## For information on Parkerhill BridgeXR

* Web: http://www.parkerhill.com/bridgexr/
* Unity Asset Store: https://assetstore.unity.com/packages/tools/utilities/bridgexr-116811

Join the conversation and get support: 

* Slack: https://goo.gl/forms/Y1AHSFG3ayETJMFV2
* Github Issues (for the Parkerhill BridgeXR package, Refabs package, and or the public repo examples): https://github.com/parkerhillvr/BridgeXR-public/issues
