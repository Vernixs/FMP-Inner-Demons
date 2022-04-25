using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemList;

    [SerializeField] private MaterialTntColour materialTntColour;
    [SerializeField] private UI_Inventory uiInventry;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Milk, amount = 1 });

        Debug.Log(itemList.Count);
    }

    public void AddItem( Item item)
    {
        itemList.Add(item);
    }
}
