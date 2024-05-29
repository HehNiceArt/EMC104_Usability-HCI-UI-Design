using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private GameObject modelParent;
    [SerializeField] private GameObject changeModel;
    [SerializeField] private float rotateSpeed;
    bool isPressed = false;
    public void ModelRotation()
    {
        if(isPressed == false) { isPressed = true; }
        else { isPressed = false; }
    }
    private void Update()
    {
        if(isPressed == true) {
            changeModel.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            modelParent.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

}
