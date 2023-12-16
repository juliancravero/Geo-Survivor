using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoInvulnerabilidad : MonoBehaviour
{
    float timer = 5f, currentTime;
    private MaquinaEstadoRombo maquina;
    
    void OnEnable()
    {
        Rombomove.Vulnerable = false;
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
