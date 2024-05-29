using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public List<Texture> mainModelHairTextureList;
    public List<Texture> changeModelJacketTextureList;
    public Material mainModelhHairMaterial;
    public Material changeModelJacketMaterial;

    public void ChangeHairColor()
    {
        int currentHairTextureIndex = mainModelHairTextureList.IndexOf(mainModelhHairMaterial.mainTexture);
        currentHairTextureIndex++;
        if (currentHairTextureIndex >= mainModelHairTextureList.Count)
        {
            currentHairTextureIndex = 0;
        }
        mainModelhHairMaterial.mainTexture = mainModelHairTextureList[currentHairTextureIndex];

        int changeHairTextureIndex = changeModelJacketTextureList.IndexOf(changeModelJacketMaterial.mainTexture);
        changeHairTextureIndex++;
        if(changeHairTextureIndex >= changeModelJacketTextureList.Count)
        {
            changeHairTextureIndex = 0;
        }
        changeModelJacketMaterial.mainTexture = changeModelJacketTextureList[changeHairTextureIndex];
    }
}
