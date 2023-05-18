using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMasTiempo : MonoBehaviour
{
    Timer temporizador;
    void Start()
    {
        temporizador = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            temporizador.timerTime = temporizador.timerTime + 10;
        
            Destroy(gameObject);
        }
        
    }
}
