using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use animation tweening
using DG.Tweening;
using System;
using UnityEngine.UI;
public class Button_Manager : MonoBehaviour
{

    public GameObject Test_UI;
    public Vector3 targetPos;
    public Vector3 originalPos;

    [Range(0, 10)]
    public float duration;

    public Vector3 targetSize;
    public Vector3 rotation;

    [Range(0, 1)]
    public float fadeDuration;

    public Image targetImage;

    [Range(0, 5)]
    public float delay;
    public void SequenceTween()
    {
        Sequence sequence = DOTween.Sequence();
        //1st task
        sequence.Append(Test_UI.transform.DOLocalMove(targetPos, duration).SetEase(Ease.Linear));
        //2nd task
        sequence.AppendInterval(delay);
        sequence.Append(Test_UI.transform.DOLocalMove(originalPos, duration).SetEase(Ease.Linear));
        //3rd task
        sequence.AppendInterval(delay);
        sequence.Append(Test_UI.transform.DOScale(targetSize, duration).SetEase(Ease.Linear));
        //4th task
        sequence.AppendInterval(delay);
        sequence.Append(targetImage.DOFade(fadeDuration, duration));
        //5th task
        sequence.AppendInterval(delay);
        sequence.Append(Test_UI.transform.DORotate(rotation, duration).SetEase(Ease.Linear));
    }   
    public void ButtonMovement()
    {
        Test_UI.transform.DOLocalMove(targetPos, duration).SetEase(Ease.Linear);
            
            //.OnComplete(()=> ReturnPos());
    }

    public void ReturnPos()
    {
        Test_UI.transform.DOLocalMove(originalPos, duration).SetEase(Ease.Linear);
    }

    public void ScaleTween()
    {
        Test_UI.transform.DOScale(targetSize, duration).SetEase(Ease.Linear);
    }

    public void FadeTween()
    {
        targetImage.DOFade(fadeDuration, duration);
    }

    public void RotationTween()
    {
        //SetLoop (float, looptype)
        //-1 infinite loop
        Test_UI.transform.DORotate(rotation, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
