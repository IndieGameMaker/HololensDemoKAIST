using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class PointerManager : MonoBehaviour, IMixedRealityFocusHandler, IMixedRealityPointerHandler
{
    private bool isRotate = false;

    public void OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("OnFocusEnter");
        isRotate = true;
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        Debug.Log("OnFocusExit");
        isRotate = false;
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerClicked");
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerDragged");
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate)
        {
            transform.Rotate(Transform.up * Time.deltaTime * 50.0f);
        }
    }
}
