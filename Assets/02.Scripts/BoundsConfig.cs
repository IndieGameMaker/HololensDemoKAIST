using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI.BoundsControlTypes;

public class BoundsConfig : MonoBehaviour
{
    public BoundsControlActivationType activationType = BoundsControlActivationType.ActivateOnStart;

    [Range(0.01f, 0.1f)]
    public float rotateHandleSize = 0.016f;
    [Range(0.01f, 0.1f)]
    public float scaleHandleSize = 0.016f;

    private BoundsControl boundsControl;

    // Start is called before the first frame update
    void Start()
    {
        //컴포넌트 생성
        boundsControl = this.gameObject.AddComponent<BoundsControl>();

        //컴포넌트의 속성 설정
        boundsControl.BoundsControlActivation = activationType;
        boundsControl.RotationHandlesConfig.HandleSize = rotateHandleSize;
        boundsControl.ScaleHandlesConfig.HandleSize    = scaleHandleSize;
    }
}