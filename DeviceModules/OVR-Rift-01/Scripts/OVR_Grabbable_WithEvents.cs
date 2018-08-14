using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OVR_Grabbable_WithEvents : OVRGrabbable {

    public UnityEvent OnTouch;
    public UnityEvent OnUnTouch;
    public UnityEvent OnSelect;
    public UnityEvent OnUnSelect;

    void OnTriggerEnter(Collider otherCollider)
    {
        OnTouch.Invoke();
    }

    void OnTriggerExit(Collider otherCollider)
    {
        OnUnTouch.Invoke();
    }

    override public void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        OnSelect.Invoke();
    }

    override public void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        OnUnSelect.Invoke();
        OnUnTouch.Invoke();
    }

}
