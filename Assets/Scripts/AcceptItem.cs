using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptItem : MonoBehaviour
{
    public static int itemCounter;
    public int totalItems;
    RectTransform rectTransform;

    void Start()
    {
        itemCounter = 0;
        
        //Fetch the RectTransform from the GameObject
        rectTransform = GetComponent<RectTransform>();
    }

    // Checks if the solution is correct or not
    public void Check()
    {
        bool isSolutionCorrect = (itemCounter == totalItems); 
        if(isSolutionCorrect)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }
}
