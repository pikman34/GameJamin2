using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;
    

    private void OnMouseEnter()
    {
        enteredTrigger.Invoke();
    }

    private void OnMouseExit()
    {
        exitedTrigger.Invoke();
    }
}