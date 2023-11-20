using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public int price;
    public Sprite itemImage;

    public Item(string itemName, int price, Sprite itemImage)
    {
        this.itemImage = itemImage;
        this.itemName = itemName;
        this.price = price;
    }
}
