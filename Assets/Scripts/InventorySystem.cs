using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public Dictionary<int, Item> Inventory = new Dictionary<int, Item>();

    public void AddItem(Item item)
    {
        //checks if a preexisting item exists in the inventory
        if (Inventory.ContainsKey(item.itemId))
        {

        }
        else
        {
            Inventory.Add(item.itemId, item);
        }
    }

    public bool RemoveItem(int itemId)
    {
        bool removed = Inventory.Remove(itemId);
        if(removed)
        {
        }
        return removed; 
    }
    public bool CheckItem(int itemId)
    {
        return Inventory.ContainsKey(itemId);
    }
}
