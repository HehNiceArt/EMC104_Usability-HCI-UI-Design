using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private GameObject modelParent;
    [SerializeField] private GameObject changeModel;
    [SerializeField] private float scale;
    bool isZoomIn;
    bool isZoomOut;
    void Update()
    {
     if(isZoomIn) 
     { 
        modelParent.transform.localScale += new Vector3(scale, scale, scale); 
        changeModel.transform.localScale += new Vector3(scale, scale, scale); 
     }
     if (isZoomOut)
     {
        modelParent.transform.localScale -= new Vector3(scale, scale, scale);
        changeModel.transform.localScale -= new Vector3(scale, scale, scale);
     }
    }
    public void ZoomInHold() { isZoomIn = true; }
    public void ZoomInRelease() { isZoomIn = false; }
    public void ZoomOutHold() {  isZoomOut = true; }
    public void ZoomOutRelease() {  isZoomOut = false; }
}
