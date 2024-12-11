using UnityEngine;
using System;
using System.Collections.Generic;

public class ItemSelector : MonoBehaviour
{
    public ItemSelector itemSelector;
    public GameObject itemPrefab;
    private LinkedList<GameObject> products = new LinkedList<GameObject>();
    private LinkedList<GameObject> tools = new LinkedList<GameObject>();

    public void Start() {
        if(itemSelector == null) {
            itemSelector = this;
            Debug.Log("new selector");
        }
        if(itemPrefab != null) itemSelector.selectedItem(itemPrefab);
    }
    public void selectedItem(GameObject itemPrefab)
    {
        if(itemPrefab.tag == "Products") {
            products.AddLast(itemPrefab);
            Debug.Log("selected Product: "+ itemPrefab.name);
        }
        else {
            tools.AddLast(itemPrefab);
        }
    }

    public LinkedList<GameObject> getTools() {
        return itemSelector.tools;
    }

    public LinkedList<GameObject> getProducts() {
        return itemSelector.products;
    }

    public void cleanProducts(){
        itemSelector.products.Clear();
    }
}
