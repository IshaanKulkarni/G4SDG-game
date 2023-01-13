using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CurrentImage : MonoBehaviour
{
    public static string curImage;
    public GameObject curObject;
    public GameObject inventoryObject;
    public GameObject targetObject;
    public bool flag;
    public void Check()
    {
        if(curObject.name == curImage)
        {
            inventoryObject.SetActive(false);
            curObject.SetActive(false);
            if(flag)
                targetObject.SetActive(true);
            ScoreHandler.score+=500;
        }
        else
        {
            if(ScoreHandler.score >= 50)
            ScoreHandler.score-=50;
            else
            ScoreHandler.score=0;
        }
    }   
}
