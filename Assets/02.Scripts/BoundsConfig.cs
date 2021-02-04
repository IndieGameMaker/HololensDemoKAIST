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

    //머티리얼 설정
    private readonly string boxMat      = "BoundingBox";
    private readonly string boxGrabMat  = "BoundingBoxGrabbed";
    private readonly string handleMat   = "BoundingBoxHandleBlue";

    // Start is called before the first frame update
    void Start()
    {
        //컴포넌트 생성
        boundsControl = this.gameObject.AddComponent<BoundsControl>();

        //컴포넌트의 속성 설정
        boundsControl.BoundsControlActivation = activationType;
        boundsControl.RotationHandlesConfig.HandleSize = rotateHandleSize;
        boundsControl.ScaleHandlesConfig.HandleSize    = scaleHandleSize;

        //머티리얼 속성 연결
        boundsControl.BoxDisplayConfig.BoxMaterial         = Resources.Load<Material>($"Materials/{boxMat}");
        boundsControl.BoxDisplayConfig.BoxGrabbedMaterial  = Resources.Load<Material>($"Materials/{boxGrabMat}");
        boundsControl.ScaleHandlesConfig.HandleMaterial    = Resources.Load<Material>($"Materials/{handleMat}");
        boundsControl.RotationHandlesConfig.HandleMaterial = Resources.Load<Material>($"Materials/{handleMat}");
    }
}