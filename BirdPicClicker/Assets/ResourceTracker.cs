using System;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class ResourceTracker : MonoBehaviour
{
    public float resourcesAvailable;
    public float autoClicks, autoClickPool;
    public TMP_Text resourceCounter, clickCounter;
    public bool rook, bluetit, swan, goldfinch, robin, collareddove;

    private void Start()
    {
        UpdateUI();
    }

    // Add resources to the available pool
    public void AddResources(float amountToAdd)
    {
        if (rook)
        {
            resourcesAvailable += amountToAdd;
            UpdateUI();
        }

        if (bluetit) 
        {
            resourcesAvailable += (float)(amountToAdd + 0.5);

            UpdateUI();
        }
        
        if (robin)
        {
            resourcesAvailable += (float)(amountToAdd + 0.75);

            UpdateUI();
        }

        if (goldfinch)
        {
            resourcesAvailable += (float)(amountToAdd + 1);

            UpdateUI();
        }

        if (swan)
        {
            resourcesAvailable += (float)(amountToAdd + 1.5);

            UpdateUI();
        }
        
        if (collareddove)
        {
            resourcesAvailable += (float)(amountToAdd + 2);

            UpdateUI();
        }
    }

    public void RemoveResources(float amountToRemove)
    {
        resourcesAvailable -= amountToRemove;
        UpdateUI();
    }

    public bool CheckResources(float checkAmount)
    {
        if (checkAmount <= resourcesAvailable)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Update()
    {
        autoClickPool += autoClicks * Time.deltaTime;
        if (autoClickPool >= 1f)
        {
            autoClickPool -= 1f;
            autoClickerAutoResource(1);
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        var textDisplay = resourcesAvailable.ToString();
        int index = textDisplay.IndexOf(".");
        if (index >= 0)
        {
            textDisplay = textDisplay.Substring(0, index);
        }
        resourceCounter.text = "Photos: " + textDisplay;
        clickCounter.text = "Photos per second: " + (Mathf.Round(autoClicks * 10) / 10).ToString();
    }

    public void autoClickerAutoResource(float amountToAdd)
    {
        resourcesAvailable += amountToAdd;
        UpdateUI();
    }


}
