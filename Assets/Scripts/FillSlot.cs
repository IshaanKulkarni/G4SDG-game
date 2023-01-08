using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class FillSlot : MonoBehaviour
{
    public GameObject icon;

    void Start()
    {
        icon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        //        if(player.gameObject.tag == "Player")
        icon.SetActive(true);
    }
}
