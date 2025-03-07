using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;
    public ResourceTracker clicker;
    public bool bird1, bird2, bird3, bird4, bird5, bird6;

    private bool insideTrigger;

    void Update()
    {
        if (insideTrigger && Input.GetMouseButtonDown((int)MouseButton.Left))
        {
            interacted.Invoke();
           
            if (bird1) 
            {
                clicker.rook = true;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.collareddove = false;
            }

            if (bird2)
            {
                clicker.rook = false;
                clicker.robin = true;
                clicker.collareddove = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.bluetit = false;
            }

            if (bird3)
            {
                clicker.rook = false;
                clicker.robin = false;
                clicker.collareddove = true;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.bluetit = false;
            }

            if (bird4)
            {
                clicker.rook = false;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = true;
                clicker.swan = false;
                clicker.collareddove = false;
            }

            if (bird5)
            {
                clicker.rook = false;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = true;
                clicker.collareddove = false;
            }

            if (bird6)
            {
                clicker.rook = false;
                clicker.collareddove = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.collareddove = true;
                clicker.bluetit = true;
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