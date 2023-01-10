using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlots : MonoBehaviour
{
    public GameObject[] InventoryItems;
    public static int count;
    public InventorySO RemainingInventoryItems;

    public void Start()
    {
        count = 0;
    }
    
    public void SetInventory()
    {
        RemainingInventoryItems.index = 0;
        for(int i=0;i<InventoryItems.Length;i++)
        {
            if(InventoryItems[i].activeSelf)
            {
                RemainingInventoryItems.obj[RemainingInventoryItems.index] = InventoryItems[i].name;
                Debug.Log(RemainingInventoryItems.obj[RemainingInventoryItems.index]);
                RemainingInventoryItems.index++;
            }
        }
    }
}
