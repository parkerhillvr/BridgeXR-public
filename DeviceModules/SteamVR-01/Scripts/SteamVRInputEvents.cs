using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

/// <summary>
/// Based off of InteractableExample.cs , calls a unity event when the object was touched or triggered
/// </summary>
[RequireComponent(typeof(Interactable))]
public class SteamVRInputEvents : MonoBehaviour
{
    public UnityEvent OnHover;
    public UnityEvent OnUnhover;
    public UnityEvent OnSelect;
    public UnityEvent OnUnSelect;

    private bool _selected;

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
        if (_selected)
        {
            if (hand.GetStandardInteractionButtonUp())
            {
                _selected = false;
                OnUnSelect.Invoke();
            }
        }
        else
        {
            if (hand.GetStandardInteractionButtonDown())
            {
                _selected = true;
                OnSelect.Invoke();
            }
        }

    }

}
