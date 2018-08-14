using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHighlighter : MonoBehaviour
{
    public GameObject Model;
    public Color HighlightColor;
    private Material _material;
    private Color _saveColor;
    private bool _highlighted;

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
        if (!_highlighted)
        {
            _saveColor = _material.color;
            _material.color = HighlightColor;
            _highlighted = true;
        }
    }

    public void UnHighlight()
    {
        if (_highlighted)
        {
            _material.color = _saveColor;
            _highlighted = false;
        }
    }
}
