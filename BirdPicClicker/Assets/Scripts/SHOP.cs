using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SHOP : MonoBehaviour
{
    public string itemName = "@@@";
    public float numberOwned, baseCost, purchaseCost;
    public float multiplier = 1.15f;
    public TMP_Text costText, nameText, numberText;
    public ResourceTracker myResources;
    public float autoClickIncrease = 0.1f;
    public bool flash, tripod, hdlens, viewfinder, procam, birdfeed, flowers, birdbath, birdbath2, pond, pond2, birdhouse, birdhouse2, fatball, fatball2, mixedseed, mixedseed2, safflower, safflower2, meatworm, meatworm2, sunflower, sunflower2;

    public Button safflowerbutton, meatbutton, sunflowerbutton, robinbutton, dovebutton, goldbutton, swanbutton, bluetitbutton;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
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
            if (flash)
            {
                gameObject.SetActive(true); 
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (tripod)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (hdlens)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (viewfinder)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (procam)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }


            if (birdfeed)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (flowers)
            {
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (birdbath)
            {
                safflowerbutton.interactable = true;
                gameObject.SetActive(true);
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (birdbath2)
            {
                gameObject.SetActive(false);
            }

            if (pond)
            {
                ChangeSprite();
                meatbutton.interactable = true;
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }

            if (birdhouse)
            {
                gameObject.SetActive(true);
                bluetitbutton.interactable = true;
                myResources.RemoveResources(purchaseCost);
                myResources.autoClicks += autoClickIncrease;
                numberOwned++;
                SetUI();
            }
        }

    void ChangeSprite() 
    {
        spriteRenderer.sprite = newSprite;
    }


    }
}