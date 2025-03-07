using System;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class ResourceTracker : MonoBehaviour
{
    public float resourcesAvailable;
    public float autoClicks, autoClickPool, photoClicks;
    public TMP_Text resourceCounter, clickCounter, clickerCounter;
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
            photoClicks = (float)1;
            resourcesAvailable += amountToAdd;
            UpdateUI();
        }

        if (robin) 
        {
            photoClicks = (float)1.5;
            resourcesAvailable += (float)(amountToAdd + 0.5);
            UpdateUI();
        }
        
        if (collareddove)
        {
            photoClicks = (float)1.75;
            resourcesAvailable += (float)(amountToAdd + 0.75);
            UpdateUI();
        }

        if (goldfinch)
        {
            photoClicks = (float)(2);
            resourcesAvailable += (float)(amountToAdd + 1);
            UpdateUI();
        }

        if (swan)
        {
            photoClicks = (float)(2.5);
            resourcesAvailable += (float)(amountToAdd + 1.5);
            UpdateUI();
        }
        
        if (bluetit)
        {
            photoClicks = (float)(3);
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
        clickerCounter.text = photoClicks.ToString() + " c/s";
    }

    public void autoClickerAutoResource(float amountToAdd)
    {
        resourcesAvailable += amountToAdd;
        UpdateUI();
    }


}
