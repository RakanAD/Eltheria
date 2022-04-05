using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (panel.activeInHierarchy == true)
            panel.SetActive(false);
        else
            panel.SetActive(true);
    }
}
