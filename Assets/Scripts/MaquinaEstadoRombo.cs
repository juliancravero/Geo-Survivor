using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaEstadoRombo : MonoBehaviour
{
    public MonoBehaviour EstadoBase;
    public MonoBehaviour EstadoInvulnerabilidad;

    public MonoBehaviour EstadoFantasma;


    [HideInInspector] public MonoBehaviour estadoActual;
    void Start()
    {
        ActivarEstado(EstadoBase);
    }
    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual != null) estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;

    }  
}
