using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FungiControl : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] private Vector3 cauldronTransform;
    [SerializeField] private GameObject Confetti;
    private int point = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "AmanitaMuscariaFungi" 
            || collision.gameObject.tag == "AmanitaPhalloidesFungi")
        {
            mainCamera.clearFlags = CameraClearFlags.SolidColor;
            mainCamera.DOColor(Color.black, 3);
            UnityEditor.EditorApplication.isPlaying = false;
        }

        if (collision.gameObject.tag == "CantharellusCibariusFungi"
            || collision.gameObject.tag == "LeccinumScabrumFungi"
            || collision.gameObject.tag == "LeccinumVersipelleFungi"
            || collision.gameObject.tag == "MacrolepiotaProceraFungi")
        {
            point += 10; 
        }
    }


    private void Update()
    {
        if (point == 40) StartCoroutine(IsFinishedIE());
    }

    IEnumerator IsFinishedIE()
    {
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
        Tween CameraTween = mainCamera.DOColor(Color.green, 10);
        Instantiate(Confetti, cauldronTransform, Quaternion.identity);
        yield return CameraTween.WaitForCompletion();
        UnityEditor.EditorApplication.isPlaying = false;

    }
            
            
            


}
