using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunction : MonoBehaviour
{
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private GameObject transformCanvas;
    [SerializeField] private GameObject customizeCanvas;
    [SerializeField] private GameObject animationCanvas;
    [SerializeField] private GameObject changeModelCanvas;
    void Start()
    {
        Time.timeScale = 0;
        transformCanvas.gameObject.SetActive(false);
        animationCanvas.gameObject.SetActive(false);
        customizeCanvas.gameObject.SetActive(false);
        changeModelCanvas.gameObject.SetActive(false);
    }
    public void MainActive() { mainCanvas.gameObject.SetActive(true); Time.timeScale = 0; }
    public void MainInactive() { mainCanvas.gameObject.SetActive(false); Time.timeScale = 1; }
    public void AnimationActive() { animationCanvas.gameObject.SetActive(true); Time.timeScale = 1; }
    public void AnimationInactive() { animationCanvas.gameObject.SetActive(false); Time.timeScale = 0; }
    public void TransformActive() { transformCanvas.gameObject.SetActive(true); Time.timeScale = 1; }
    public void TransformInactive() { transformCanvas.gameObject.SetActive(false); Time.timeScale = 0; }
    public void CustomizeActive() {  customizeCanvas.gameObject.SetActive(true); Time.timeScale = 1; }
    public void CustomizeInactive() {  customizeCanvas.gameObject.SetActive(false); Time.timeScale = 0; }
    public void ChangeModelActive() { changeModelCanvas.gameObject.SetActive(true); Time.timeScale = 1; }
    public void ChangeModelInactive() {  changeModelCanvas.gameObject.SetActive(false); Time.timeScale = 0; }
}
