using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDifusa : MonoBehaviour
{
    public Transform jugador;
    public Transform enemigo;
    public float distanciaDisparo = 30.0f;

    void Update()
    {
        float distanciaAlJugador = Vector2.Distance(enemigo.position, jugador.position);

        bool deberiaDisparar = VerificarDisparo(distanciaAlJugador);

        if (deberiaDisparar)
        {
            Disparar(); 
        }
    }
    bool VerificarDisparo(float distancia)
    {
        float umbralDisparo = distanciaDisparo;

        if (distancia > umbralDisparo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Disparar()
    {
        Debug.Log("Enemigo dispara");
    }
}
