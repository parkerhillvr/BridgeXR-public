using System.Collections;
using System.Collections.Generic;
using DaydreamElements.ObjectManipulation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// implements unity events for hover/unhover. Click to select, unclick to unselect
// (differs from Daydream demo which is click once to select, click again to release)
public class DaydreamInputEvents : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    public UnityEvent OnHover;
    public UnityEvent OnUnhover;
    public UnityEvent OnClick;
    public UnityEvent OnUnclick;

    private BaseInteractiveObject interactive;

    void Start()
    {
        interactive = GetComponent<BaseInteractiveObject>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHover.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnUnhover.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnClick.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (interactive)
        {
            interactive.OnPointerDown(null);
        }
        OnUnclick.Invoke();
    }
}
