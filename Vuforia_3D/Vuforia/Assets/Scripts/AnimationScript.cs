using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    [SerializeField] private Animator mainAnim;
    [SerializeField] private Animator changeAnim;
    public void CallDance()
    {
        mainAnim.SetBool("isDancing", true);
        changeAnim.SetBool("isDancing", true);
        if (mainAnim.GetBool("isDancing") == true || changeAnim.GetBool("isDancing") == true)
        {
            StartCoroutine(WaitDance());
        }
    }
    public void CallBackflip()
    {
        mainAnim.SetBool("isBackflip", true);
        changeAnim.SetBool("isBackflip", true);
        if(mainAnim.GetBool("isBackflip") == true || changeAnim.GetBool("isBackflip") == true)
        {
            StartCoroutine(WaitBackflip());
        }
    }

    IEnumerator WaitDance()
    {
        yield return new WaitForSeconds(2f);
        mainAnim.SetBool("isDancing", false);
        changeAnim.SetBool("isDancing", false);
    }
    IEnumerator WaitBackflip()
    {
        yield return new WaitForSeconds(2f);
        mainAnim.SetBool("isBackflip", false);
        changeAnim.SetBool("isBackflip", false);
    }
}
