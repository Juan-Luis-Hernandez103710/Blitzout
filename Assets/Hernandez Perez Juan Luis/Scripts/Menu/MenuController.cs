using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Paneles de UI")]
    public GameObject MainMenu;
    public GameObject SelectPista;
    public GameObject SelectNave;
    public GameObject SeleccionDeModo;

    [Header("Objetos que aparecen")]
    public GameObject ViewPista1;
    public GameObject ViewPista2;
    public GameObject ViewPista3;
    public GameObject ViewPista4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        MainMenu.SetActive(false);

        SeleccionDeModo.SetActive(true);
    }

    public void PistaSelect()
    {
        SeleccionDeModo.SetActive(false);

        SelectPista.SetActive(true);
    }

    public void NaveSelect()
    {
        SelectPista.SetActive(false);

        SelectNave.SetActive(true);

        ViewPista1.SetActive(false);
        ViewPista2.SetActive(false);
        ViewPista3.SetActive(false);
        ViewPista4.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void BackMenu()
    {
        SeleccionDeModo.SetActive(false);

        MainMenu.SetActive(true);
    }

    public void BackSelectPista()
    {
        SelectPista.SetActive(false);

        SeleccionDeModo.SetActive(true);

        ViewPista1.SetActive(false);
        ViewPista2.SetActive(false);
        ViewPista3.SetActive(false);
        ViewPista4.SetActive(false);
    }

    public void BackSelectNave()
    {
        SelectNave.SetActive(false);

        SelectPista.SetActive(true);
    }

    public void VerPista1()
    {
        ViewPista1.SetActive(true);
        ViewPista2.SetActive(false);
        ViewPista3.SetActive(false);
        ViewPista4.SetActive(false);
    }

    public void VerPista2()
    {
        ViewPista2.SetActive(true);
        ViewPista1.SetActive(false);
        ViewPista3.SetActive(false);
        ViewPista4.SetActive(false);
    }

    public void VerPista3()
    {
        ViewPista3.SetActive(false);
        ViewPista1.SetActive(false);
        ViewPista2.SetActive(false);
        ViewPista4.SetActive(true);
    }

    public void VerPista4()
    {
        ViewPista4.SetActive(false);
        ViewPista1.SetActive(false);
        ViewPista2.SetActive(false);
        ViewPista3.SetActive(true);
    }
}
