using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Clock : MonoBehaviour
{

    private static float Seconds = 300;
    [SerializeField] Camera mainCamera;
    [SerializeField] TextMeshPro SecondsText;


    void Update()
    {
        if (Seconds >= 0)
        {
            Seconds -= Time.deltaTime;
            SecondsText.text = Seconds.ToString() + " sec";
        }
        else
        {
            mainCamera.clearFlags = CameraClearFlags.SolidColor;
            mainCamera.DOColor(Color.red, 3);
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
