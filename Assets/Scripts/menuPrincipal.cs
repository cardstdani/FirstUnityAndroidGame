using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class menuPrincipal : MonoBehaviour {

    public string youtube;
    public string insta;
    public string twiter;
    public string web;
    public string valorar;
    public int nivel = 1;
    public TextMeshProUGUI textoNivel;
    public TextMeshProUGUI textoRecord;
    public GameObject recordIcono;

    public void Update()
    {
        if (nivel == 1)
        {
            textoNivel.text = "RETENCION";
            textoRecord.text = PlayerPrefs.GetInt("RecordObjetos").ToString();
            recordIcono.SetActive(true);
        }

        if (nivel == 2)
        {
            textoNivel.text = "CONTRARRELOJ";
            textoRecord.text = PlayerPrefs.GetInt("RecordGolpes").ToString();
            recordIcono.SetActive(true);
        }

        if (nivel == 3)
        {
            textoNivel.text = "MODO LIBRE";
            textoRecord.text = "No hay records";
            recordIcono.SetActive(false);
        }
    }

    public void yt()
    {
        Application.OpenURL(youtube);
    }

    public void instagram()
    {
        Application.OpenURL(insta);
    }

    public void twitter()
    {
        Application.OpenURL(twiter);
    }

    public void zenterGames()
    {
        Application.OpenURL(web);
    }

    public void googlePlay()
    {
        Application.OpenURL(valorar);
    }

    public void aumentar()
    {
        if (nivel < 3)
        {
            nivel++;
        }
    }

    public void disminuir()
    {
        if (nivel > 1)
        {
            nivel--;
        }
    }

    public void Jugar()
    {
        if (nivel == 1)
        {
            SceneManager.LoadScene("Juego");
        }

        if (nivel == 2)
        {
            SceneManager.LoadScene("Contrareloj");
        }

        if (nivel == 3)
        {
            SceneManager.LoadScene("Modo Libre");
        }
    }

    public void salir()
    {
        Application.Quit();
    }
}
