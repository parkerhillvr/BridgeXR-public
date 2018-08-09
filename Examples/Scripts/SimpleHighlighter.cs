using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHighlighter : MonoBehaviour
{
    public GameObject Model;
    public Color HighlightColor;
    private Material _material;
    private Color _saveColor;

    void OnValidate()
    {
        if (Model == null)
            Model = gameObject;
    }

    void Start()
    {
        _material = Model.GetComponent<Renderer>().material;
    }

    public void Highlight()
    {
        _saveColor = _material.color;
        _material.color = HighlightColor;
    }

    public void UnHighlight()
    {
        _material.color = _saveColor;
    }
}
