using System;
using System.Collections.Generic;
using UnityEngine;

public class Outcome : MonoBehaviour
{
    private Dictionary<List<string>, string> mixOutcomes;

    public void Start()
    {
        // Initialize the dictionary with product combinations and outcomes
        mixOutcomes = new Dictionary<List<string>, string>
        {
            { new List<string> {"Vinegar", "Baking Soda"}, "Gas" },
            { new List<string> {"Water", "Oil"}, "No Reaction" },
            { new List<string> {"Salt", "Water"}, "Salt Solution" }
        };
    }

    public string MixProducts(LinkedList<GameObject> products)
    {
        if(products.Count == 0 || products.Count == 1) return "Unknown Reaction";
        // Check if the combination exists
        ICollection<List<string>> keys = mixOutcomes.Keys;
        foreach (List<string> key in keys)
        {
            bool contains = true;
            foreach(GameObject product in products)
            {
                if (!key.Contains(product.name))
                {
                    contains = false;
                    break;
                }
            }
            if(contains == true) return mixOutcomes[key]; // Return the outcome
        }

        return "Unknown Reaction"; // Default if no outcome is found
    }
}
