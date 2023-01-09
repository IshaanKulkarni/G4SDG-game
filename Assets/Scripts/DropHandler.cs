using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour,IDropHandler
{
    public GameObject[] binItems;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            GameObject obj = eventData.pointerDrag.gameObject;
            // Debug.Log(obj.name);
            if(Check(obj))
            {
                AcceptItem.itemCounter++;
                obj.SetActive(false);
            }
        }
    }

    private bool Check(GameObject item)
    {
        for(int i=0;i<binItems.Length;i++)
        {
            Debug.Log(binItems[i].name);
            if(binItems[i].name.Equals(item.name))
            {
                // Debug.Log("found!");
                return true;
            }
        }
        // Debug.Log("Not found!");
        return false;
    }
}
