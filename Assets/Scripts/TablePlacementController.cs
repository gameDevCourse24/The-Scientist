using System;
using System.Collections.Generic;
using UnityEngine;

public class TablePlacementController : MonoBehaviour
{
    public ItemSelector itemSelector;
    public GameObject showOutcome;

    public void Start()
    {
        Outcome outcome = new Outcome();
        outcome.Start();
        if (itemSelector != null)
        {
            if(itemSelector.getProducts() == null)  Debug.Log("No products");
            foreach (GameObject product in itemSelector.getProducts())
            {
                Debug.Log("Placed: " + product.name);
            }
            if(outcome.MixProducts(itemSelector.getProducts()) != "Unknown Reaction")
            {
                if(showOutcome != null) {
                    showOutcome.SetActive(true);
                }
            }
        }
    }
}
