using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoBase : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        gameObject.tag = "Player";
        Rombomove.Vulnerable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
