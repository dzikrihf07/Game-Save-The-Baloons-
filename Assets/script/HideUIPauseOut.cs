using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUIPauseOut : MonoBehaviour
{
    public GameObject UIPause;
 
    public void Sembunyikan() {
        StartCoroutine(TemporarilyDeactivate(1));
    }
 
    private IEnumerator TemporarilyDeactivate(float duration) {
        UIPause.SetActive(true);
        yield return new WaitForSeconds(duration);
        UIPause.SetActive(false);
    }
}
