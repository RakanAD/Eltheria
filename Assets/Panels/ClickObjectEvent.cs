using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObjectEvent : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("GameObject Clicked");
        if (panel.activeInHierarchy == true)
            panel.SetActive(false);
        else
            panel.SetActive(true);
    }
}
