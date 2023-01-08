using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler 
{
    private RectTransform item;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        item = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Handling the beginning of Drag
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    } 

    //Ongoing Drag
    public void OnDrag(PointerEventData eventData)
    {
        item.anchoredPosition += eventData.delta/canvas.scaleFactor;
    } 

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    } 

}
