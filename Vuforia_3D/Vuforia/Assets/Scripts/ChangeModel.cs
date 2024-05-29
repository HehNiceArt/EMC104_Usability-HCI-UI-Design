using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField] GameObject mainModel;
    [SerializeField] GameObject changeModel;

    private void Awake()
    {
        changeModel.SetActive(false);
    }
    public void ModelChange()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        mainModel.active = !mainModel.active;

        changeModel.active = !changeModel.active;
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
