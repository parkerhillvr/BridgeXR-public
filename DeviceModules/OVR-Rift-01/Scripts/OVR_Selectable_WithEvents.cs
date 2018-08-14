using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OVR_Selectable_WithEvents : MonoBehaviour
{

    public UnityEvent OnTouch;
    public UnityEvent OnUnTouch;
    public UnityEvent OnSelect;
    public UnityEvent OnUnSelect;

    private bool _touched;
    private bool _pressed;

    void OnTriggerEnter(Collider otherCollider)
    {
        _touched = true;
        OnTouch.Invoke();
    }

    void OnTriggerExit(Collider otherCollider)
    {
        _touched = false;
        OnUnTouch.Invoke();
        _pressed = false;
        OnUnSelect.Invoke();
    }

    private void Update()
    {
        if (_touched)
        {
            // (todo: determine which hand was touching)
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) > 0.5f
                || OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) > 0.5f)
            {
                if (!_pressed)
                {
                    _pressed = true;
                    OnSelect.Invoke();
                }
            }
            else if (_pressed)
            {
                _pressed = false;
                OnUnSelect.Invoke();
            }
        }
    }

}
