using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isPressed = false;
    [Range(0, 1)]
    private float targetScale;
    [Range(0, 1)]
    public float duration;
    private readonly float zeroVal = 0;
    private Vector3 rotate;
    private Vector3 inverse;
    private Vector3 targetPos;
    private Vector3 originalPos;
    private float horizontalAxis = 720;

    public void Start()
    {
        //reads and inputs the original position of the image
        originalPos = imageToScale.rectTransform.localPosition;
        rotate = new Vector3(0, 180, 0);
        targetPos = new Vector3(0, 360, 0);
    }
    //scale
    public void Scale()
    {
        imageToScale.DOFade(0, duration);
        targetScale = isPressed ? 2.0f : zeroVal;
        TargetScale();
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.DOFade(1, duration);
        }
    }

    //zoom
    public void Zoom()
    {
        //(condition) = someBooleanExpression ? true path : false path
        targetScale = isPressed ? 2.0f : zeroVal;
        TargetScale();
        isPressed = !isPressed;
    }

    //fade
    public void Fade()
    {
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.DOFade(0, duration);
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.DOFade(1, duration);
        }
    }

    //flip
    public void Flip()
    {
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.transform.DORotate(rotate, duration);
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.transform.DORotate(inverse, duration);
        }
    }
    //drop
    public void Drop()
    {

        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.DOFade(0, duration);
        TargetScale();
        imageToScale.transform.DOLocalMove(targetPos, duration).SetEase(Ease.Linear);
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.DOFade(1, duration);
            TargetScale();
            OriginalPosition();
        }
    }
    //fly
    public void Fly()
    {
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.transform.DOMoveX(horizontalAxis, duration);
        isPressed = !isPressed;
        if (!isPressed)
        {
            OriginalPosition();
        }
    }

    public void OriginalPosition()
    {
        imageToScale.transform.DOLocalMove(originalPos, duration).SetEase(Ease.OutBack);
    }
    public void TargetScale()
    {
        imageToScale.transform.DOScale(targetScale, duration).SetEase(Ease.Linear);
    }

}
