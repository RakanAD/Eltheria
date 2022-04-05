using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouge : MonoBehaviour
{
    public float panSpeed = 2f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("d"))
        {
            pos.x -= panSpeed * Time.deltaTime;
            pos.z -= panSpeed * Time.deltaTime;
        }

        transform.position = pos;
        
    }
}
