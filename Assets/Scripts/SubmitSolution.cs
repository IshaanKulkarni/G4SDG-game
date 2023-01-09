using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitSolution : MonoBehaviour
{
    public GameObject[] placeholders;
    public GameObject[] greenBinItems;
    public GameObject[] redBinItems;
    public GameObject[] blueBinItems;
    public GameObject[] blackBinItems;

    // Checks if the solution is correct or not
    public void Check()
    {
        bool isSolutionCorrect = true; 
        for (int i = 0; i < greenBinItems.Length; i++)
        {
            if(placeholders[0].GetComponent<RectTransform>().anchoredPosition != greenBinItems[i].GetComponent<RectTransform>().anchoredPosition)
            {
                isSolutionCorrect = false;
            }
        }
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
