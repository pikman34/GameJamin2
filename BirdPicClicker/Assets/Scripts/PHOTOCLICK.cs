using System;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;
using UnityEngine.Windows;

public class PHOTOCLICK : MonoBehaviour
{
    public float resourcesAvailable;
    public float autoClicks, autoClickPool, photoClicks, photoClickPool;
    public TMP_Text resourceCounter, clickCounter;
    public bool rook, bluetit, swan, goldfinch, robin, collareddove;

    private void Start()
    {
        UpdateUI();
    }

    // Add resources to the available pool
    public void AddResources(float amountToAdd)
    {
        if (!rook && !bluetit && !swan && !goldfinch && !robin && !collareddove)
        {
            resourcesAvailable += amountToAdd;
            UpdateUI();
        }

        if (rook) 
        {
            resourcesAvailable += (float)(amountToAdd + 0.5);
            
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