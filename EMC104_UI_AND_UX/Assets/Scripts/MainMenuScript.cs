using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MainMenuScript : MonoBehaviour
{
    public RectTransform mainMenu, playMenu, signUpMenu;
    public float uiTransitionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPlayMenu()
    {
        playMenu.DOAnchorPos(Vector2.zero, uiTransitionSpeed, true).SetEase(Ease.Linear);
        mainMenu.DOAnchorPos(new Vector2(-1100,0), uiTransitionSpeed, true).SetEase(Ease.Linear);
    }

    public void ShowPopUp()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(signUpMenu.DOAnchorPos(Vector2.zero, 0, true));
        sequence.Append(signUpMenu.DOScale (Vector2.zero, 0));
        sequence.AppendInterval(0.5f);
        sequence.Append(signUpMenu.DOScale (0.7f, 0.5f)).SetEase(Ease.Linear);
    }

    public void HidePopUp()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(signUpMenu.DOScale(Vector2.zero, 0.2f));
        sequence.AppendInterval(0.75f);
        sequence.Append(signUpMenu.DOAnchorPos(new Vector2(-1200, 0), 0, true));
        sequence.Append(signUpMenu.DOScale(Vector2.one,0));
    }
}
