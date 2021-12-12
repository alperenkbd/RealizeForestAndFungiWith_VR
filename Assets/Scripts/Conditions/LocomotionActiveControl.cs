using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionActiveControl : MonoBehaviour
{
    [Header("XR")]
    public XRController rightHandTeleportRay;
    public InputHelpers.Button TeleportActivationButton;

    private static float activationThreshold = 0.1f;


    void Update()
    {
        if (rightHandTeleportRay)
        {
            rightHandTeleportRay.gameObject.SetActive(IsActivated(rightHandTeleportRay));
        }   
    }

    public bool IsActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, TeleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
