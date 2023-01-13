 using UnityEngine;
 using UnityEngine.UI;
 using System;
 using System.Collections.Generic;
 using System.Collections;
 using TMPro;
public class ScoreHandler : MonoBehaviour
{
    public ScoreSO score;
    public TMP_Text scoreText;
    
    void Update()
    {
        scoreText.text = score.curScore.ToString();
    }
}
