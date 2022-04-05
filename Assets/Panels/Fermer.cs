using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fermer : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
