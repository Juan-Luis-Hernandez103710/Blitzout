using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMasPuntos : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntos puntaje;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            puntaje.SumaDePuntos(cantidadPuntos);
            Destroy(gameObject);
        }
        
    }
}
