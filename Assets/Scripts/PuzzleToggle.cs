using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PuzzleToggle : MonoBehaviour
{
    public GameObject puzzle;

    void Start()
    {
        puzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if(puzzle.activeSelf)
                puzzle.SetActive(false);
            else
                puzzle.SetActive(true);
        }        
    }
}
