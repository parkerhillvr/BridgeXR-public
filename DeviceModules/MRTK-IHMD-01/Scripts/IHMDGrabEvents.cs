using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.InputModule.Examples.Grabbables;
using UnityEngine;
using UnityEngine.Events;

public class IHMDGrabEvents : MonoBehaviour {

    public UnityEvent OnTouch;
    public UnityEvent OnUnTouch;
    public UnityEvent OnGrab;
    public UnityEvent OnUnGrab;

    private BaseGrabbable grabbable;

    private void Awake()
    {
        if (grabbable == null)
        {
            grabbable = GetComponent<BaseGrabbable>();
        }

        grabbable.OnContactStateChange += InvokeTouchEvent;
        grabbable.OnGrabStateChange += InvokeGrabEvent;
    }

    private void InvokeTouchEvent(BaseGrabbable baseGrab)
    {
        if (baseGrab.ContactState == GrabStateEnum.Inactive)
        {
            OnUnTouch.Invoke();
        }
        else
        {
            OnTouch.Invoke();
        }
    }

    private void InvokeGrabEvent(BaseGrabbable baseGrab)
    {
        if (baseGrab.ContactState == GrabStateEnum.Inactive)
        {
            OnUnGrab.Invoke();
        }
        else
        {
            OnGrab.Invoke();
        }
    }
}
