using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;
    public PHOTOCLICK clicker;
    public bool bird1, bird2, bird3, bird4, bird5;

    private bool insideTrigger;

    void Update()
    {
        if (insideTrigger && Input.GetMouseButtonDown((int)MouseButton.Left))
        {
            interacted.Invoke();
            if (bird1) 
            {
                clicker.rook = true;
            }
        }

    }


    private void OnMouseEnter()
    {
        enteredTrigger.Invoke();
        insideTrigger = true;
    }

    private void OnMouseExit()
    {
        exitedTrigger.Invoke();
        insideTrigger = false;
    }
}