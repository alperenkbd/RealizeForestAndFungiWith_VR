using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketIncreaser : MonoBehaviour
{
    public static int FinishValue = 0;


    public void IncreaseValue()
    {
        FinishValue++;
        Debug.Log(FinishValue);
    }

    public void DecreaseValue()
    {
        FinishValue--;
        Debug.Log(FinishValue);
    }
}
