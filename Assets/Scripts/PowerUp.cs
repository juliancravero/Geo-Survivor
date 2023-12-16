using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<MaquinaEstadoRombo>().ActivarEstado(other.gameObject.GetComponent<MaquinaEstadoRombo>().EstadoInvulnerabilidad);
            Destroy(gameObject);
        }
    }

}
