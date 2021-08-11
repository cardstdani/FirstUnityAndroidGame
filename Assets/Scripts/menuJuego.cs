using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuJuego : MonoBehaviour {


    public static bool pausado = false;
    public GameObject objetosMenu;
    public GameObject botonPausa;

    public void Start()
    {
        seguirJugando();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                seguirJugando();
            }
            else
            {
                pause();
            }
        }
    }

    public void seguirJugando()
    {
        objetosMenu.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
        botonPausa.SetActive(true);
    }

    public void pause()
    {
        objetosMenu.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
        botonPausa.SetActive(false);
    }

    public void salir()
    {
        SceneManager.LoadScene("Principal");
    }
}
