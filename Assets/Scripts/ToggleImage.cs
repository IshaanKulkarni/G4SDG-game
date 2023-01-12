 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;

public class ToggleImage : MonoBehaviour
{
    public Image img ;
    public int index;
    public Button[] btns;
    
    public void Toggle()
    {
        if(img.isActiveAndEnabled)
        {
            img.enabled = false;
            btns[index].interactable = true;
            for(int i=0;i<btns.Length;i++)
            {
                if(i!=index)
                    btns[i].interactable = false;
            }
            CurrentImage.curImage = index.ToString();
        }
        else
        {
            img.enabled = true;
            btns[index].interactable = true;
            for(int i=0;i<btns.Length;i++)
            {
                if(i!=index)
                    btns[i].interactable = true;
            }
        }
    } 
}
