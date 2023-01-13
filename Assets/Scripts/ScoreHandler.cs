 using UnityEngine;
 using UnityEngine.UI;
 using System;
 using System.Collections.Generic;
 using System.Collections;
 using TMPro;
public class ScoreHandler : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;
    
    void Start()
    {
        score = 0;
    } 

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
