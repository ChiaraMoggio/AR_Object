using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public GameObject canva;

    public void ShowText(bool state)
    {
        canva.SetActive(state);

        if (state)
        {
            
            CancelInvoke(); 
            Invoke("hide", 3f);
        }
    }

    public void hide()
    {
        canva.SetActive(false);
        Debug.Log("hide");
    }
}
