using System.Collections;
using System.Collections.Generic;
using DaydreamElements.ObjectManipulation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class DaydreamTouchableEvents : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    public UnityEvent OnHover;

    public UnityEvent OnUnhover;

    public UnityEvent OnClick;

    public UnityEvent OnUnclick;

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="eventData">Current event data.</param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHover.Invoke();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="eventData">Current event data.</param>
    public void OnPointerExit(PointerEventData eventData)
    {
        OnUnhover.Invoke();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="eventData">Current event data.</param>
    public void OnPointerUp(PointerEventData eventData)
    {
        OnClick.Invoke();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="eventData">Current event data.</param>
    public void OnPointerDown(PointerEventData eventData)
    {
        OnUnclick.Invoke();
    }
}
