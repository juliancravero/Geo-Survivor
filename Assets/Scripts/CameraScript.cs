using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Rombo;

    void Update()
    {
        if(!Rombo) return;
        Vector3 position = transform.position;
        position.x = Rombo.transform.position.x;
        position.y = Rombo.transform.position.y;
        transform.position = position;
    }
}
