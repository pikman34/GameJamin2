using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted, purchase;
    public ResourceTracker clicker;
    public SHOP buy;
    public bool bird1, bird2, bird3, bird4, bird5, bird6;

    private bool insideTrigger;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    

    void Update()
    {
        if (Input.GetMouseButtonDown((int)MouseButton.Left) && clicker.CheckResources(buy.purchaseCost))
        {
            Debug.Log(insideTrigger);
            purchase.Invoke();
        }


        if (insideTrigger && Input.GetMouseButtonDown((int)MouseButton.Left))
        {
            interacted.Invoke();
           
            if (bird1) 
            {
                audioManager.PLAYSFX(audioManager.rookNoise);
                clicker.rook = true;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.collareddove = false;
            }

            if (bird2)
            {
                audioManager.PLAYSFX(audioManager.robinNoise);
                clicker.rook = false;
                clicker.robin = true;
                clicker.collareddove = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.bluetit = false;
            }

            if (bird3)
            {
                audioManager.PLAYSFX(audioManager.doveNoise);
                clicker.rook = false;
                clicker.robin = false;
                clicker.collareddove = true;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.bluetit = false;
            }

            if (bird4)
            {
                audioManager.PLAYSFX(audioManager.goldfinchNoise);
                clicker.rook = false;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = true;
                clicker.swan = false;
                clicker.collareddove = false;
            }

            if (bird5)
            {
                audioManager.PLAYSFX(audioManager.swanNoise);
                clicker.rook = false;
                clicker.bluetit = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = true;
                clicker.collareddove = false;
            }

            if (bird6)
            {
                audioManager.PLAYSFX(audioManager.bluetitNoise);
                clicker.rook = false;
                clicker.collareddove = false;
                clicker.robin = false;
                clicker.goldfinch = false;
                clicker.swan = false;
                clicker.collareddove = true;
                clicker.bluetit = true;
            }

            if (clicker.CheckResources(buy.purchaseCost) == true)
            {
                interacted.Invoke();
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