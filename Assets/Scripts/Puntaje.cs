using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    [HideInInspector]public float puntos;

    private TextMeshProUGUI textMesh;

    private void Start(){
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update(){
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }
    //  GameObject.Find("Rombo").GetComponent<Rombomove>().firerate -= 0.01f;
    public void SumarPuntos(float puntosEntrada){
        puntos += puntosEntrada;
        if(puntos > 10){
            GameObject.Find("Rombo").GetComponent<Rombomove>().firerate -= 0.40f;
        }
    }

}
