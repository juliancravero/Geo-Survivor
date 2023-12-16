using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoFantasma : MonoBehaviour
{
    
    float timer = 5f, currentTime;
    private MaquinaEstadoRombo maquina;
    void OnEnable()
    {
        gameObject.tag = "Untagged";
        currentTime = 0f;
        maquina = GetComponent<MaquinaEstadoRombo>();
    }
    void Update()
    {
         if(currentTime >= timer)
        {
            currentTime = 0f;
            maquina.ActivarEstado(maquina.EstadoBase);
        }else
        {
            currentTime += Time.deltaTime;
        }
    }
}
