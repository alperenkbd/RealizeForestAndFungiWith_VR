using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Shaker : MonoBehaviour
{
    [SerializeField]
    private Camera MainCamera;


    private void Start()
    {
        MainCamera = Camera.main;
    }

    public void ShakeCamera()
    {
        MainCamera.DOShakePosition(1, 1, 10, 10, true);
        MainCamera.DOShakeRotation(1, 1, 10, 10, true);
    }

}
