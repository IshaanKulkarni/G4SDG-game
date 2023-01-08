using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventoryToggle : MonoBehaviour
{
    public GameObject inventory;

    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if(inventory.activeSelf)
                inventory.SetActive(false);
            else
                inventory.SetActive(true);
        }        
    }
}
