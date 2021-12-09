using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class SocketControl : MonoBehaviour, IFinishControl
{

    private int waitingTime=3;
    
    private void OnTriggerEnter(Collider other)
    {
        IsFinished();
        
    }


    public bool IsFinished()
    {
        if (SocketIncreaser.FinishValue == 6)
        {
            StartCoroutine(IsFinishedIE());
            return true;
        }
        return false;
    }


    IEnumerator IsFinishedIE()
    {
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Tween CameraTween = Camera.main.DOColor(Color.green, waitingTime);
        yield return CameraTween.WaitForCompletion();
        SceneManager.LoadScene(1);

    }
}
