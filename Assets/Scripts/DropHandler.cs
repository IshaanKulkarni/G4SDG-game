using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour,IDropHandler
{
    // public GameObject[] insertedItems = new GameObject[30];
    // int idx = 0;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        // insertedItems[idx++] =
        // Debug.Log(eventData) ;
    }
}
