using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeSolution : MonoBehaviour
{
    public static int itemCounter;
    public int totalItems;
    public Canvas cDialog;
    public Canvas wDialog;
    public ScoreSO score;
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
            
            wDialog.enabled = false;
            cDialog.enabled = true;
            score.curScore += 10000;
            Debug.Log("Correct!");
        }
        else
        {
            cDialog.enabled = false;
            wDialog.enabled = true;
            Debug.Log("Incorrect!");
        }
    }
}
