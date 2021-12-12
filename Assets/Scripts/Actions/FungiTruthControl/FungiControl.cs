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
    private static bool controlFlag = false;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AmanitaMuscariaFungi"
            || collision.gameObject.tag == "AmanitaPhalloidesFungi")
        {
            mainCamera.clearFlags = CameraClearFlags.SolidColor;
            mainCamera.DOColor(Color.red, 3);
            UnityEditor.EditorApplication.isPlaying = false;
        }

        if (collision.gameObject.tag == "CantharellusCibariusFungi")
        {
            point += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "LeccinumScabrumFungi")
        {
            point += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "LeccinumVersipelleFungi")
        {
            point += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "MacrolepiotaProceraFungi")
        {
            point += 10;
            Destroy(collision.gameObject);
        }



    }


    private void Update()
    {
        if (point == 40 && controlFlag == false)
        {
            StartCoroutine(IsFinishedIE());
            controlFlag = true;
        }
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
