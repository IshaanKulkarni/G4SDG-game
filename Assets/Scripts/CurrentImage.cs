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
    public ScoreSO score;
    public bool flag;
    public void Check()
    {
        if(curObject.name == curImage)
        {
            inventoryObject.SetActive(false);
            curObject.SetActive(false);
            if(flag)
                targetObject.SetActive(true);
            score.curScore+=500;
        }
        else
        {
            if(score.curScore >= 50)
            score.curScore-=50;
            else
            score.curScore=0;
        }
    }   
}
