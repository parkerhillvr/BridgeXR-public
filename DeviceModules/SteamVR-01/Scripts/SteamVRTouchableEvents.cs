using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

/// <summary>
/// Based off of InteractableExample.cs , calls a unity event when the object was touched or triggered
/// </summary>
[RequireComponent(typeof(Interactable))]
public class SteamVRTouchableEvents : MonoBehaviour
{
    public UnityEvent OnHover;

    public UnityEvent OnUnhover;

    public UnityEvent OnClick;

    public UnityEvent OnUnclick;

    //-------------------------------------------------
    // Called when a Hand starts hovering over this object
    //-------------------------------------------------
    private void OnHandHoverBegin(Hand hand)
    {
        OnHover.Invoke();
    }


    //-------------------------------------------------
    // Called when a Hand stops hovering over this object
    //-------------------------------------------------
    private void OnHandHoverEnd(Hand hand)
    {
        OnUnhover.Invoke();
    }


    //-------------------------------------------------
    // Called every Update() while a Hand is hovering over this object
    //-------------------------------------------------
    private void HandHoverUpdate(Hand hand)
    {
        if (hand.GetStandardInteractionButtonDown() || ((hand.controller != null) && hand.controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_Grip)))
        {
            if (hand.currentAttachedObject != gameObject)
            {
                OnClick.Invoke();
            }
            else
            {
                OnUnclick.Invoke();
            }
        }
    }
    
}

