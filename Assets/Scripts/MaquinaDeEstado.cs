using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstado : MonoBehaviour
{
    public MonoBehaviour EstadoNormal;
    public MonoBehaviour EstadoLoco;
    public MonoBehaviour EstadoEnojado;
    public int startingHealth;
    public int currentHealth;

  

 
    [HideInInspector] public MonoBehaviour estadoActual;


    void Start()
    {
        ActivarEstado(EstadoNormal);
        currentHealth = startingHealth;
    }

    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual != null) estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;

    }

    public void TakeDamage (int amount)
    {
    
        
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            
            Destroy(gameObject);

        }else if(currentHealth <= 40){
            
            ActivarEstado(EstadoLoco);

        }else if(currentHealth <= 80)
        {
            ActivarEstado(EstadoEnojado);
        }
    }
}
