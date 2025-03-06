using System;
using UnityEngine;
using TMPro;

public class SHOP : MonoBehaviour
{
    public string itemName = "@@@";
    public float numberOwned, baseCost, purchaseCost;
    public float multiplier = 1.15f;
    public TMP_Text costText, nameText, numberText;
    public ResourceTracker myResources;
    public float autoClickIncrease = 0.1f;


    private void Start()
    {
        SetUI();
    }

    private void SetUI()
    {
        CalculateCost();
        nameText.text = itemName;
        costText.text = purchaseCost.ToString();
        numberText.text = numberOwned.ToString();
    }

    private void CalculateCost()
    {
        purchaseCost = Mathf.CeilToInt(baseCost * Mathf.Pow(multiplier, numberOwned));
    }

    public void PurchaseItem()
    {
        if (myResources.CheckResources(purchaseCost))
        {
            myResources.RemoveResources(purchaseCost);
            myResources.autoClicks += autoClickIncrease;
            numberOwned++;
            SetUI();
        }
    }
}