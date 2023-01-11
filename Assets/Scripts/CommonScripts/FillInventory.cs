using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillInventory : MonoBehaviour
{
    public GameObject[] InventoryItems;
    public InventorySO RemainingInventoryItems;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i=0;i<InventoryItems.Length;i++)
        {
            
            InventoryItems[i].SetActive(false);
            for(int j=0;j<RemainingInventoryItems.index;j++)
            {
                if(InventoryItems[i].name == RemainingInventoryItems.obj[j])
                {
                    Debug.Log("YES");
                    InventoryItems[i].SetActive(true);
                }
            }
        }      
    }
}
