using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    private float puntos;

    public GameObject panelGanar;

    private TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        panelGanar.SetActive(false);

        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = puntos.ToString("0");

        if(puntos == 100)
        {
            panelGanar.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    public void SumaDePuntos(float puntosDeEntrada)
    {
        puntos += puntosDeEntrada;
    }
}
