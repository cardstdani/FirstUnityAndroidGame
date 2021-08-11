using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class contrarelojManager : MonoBehaviour {

    public GameObject Guante;
    public GameObject Spawner;
    public int golpes = 0;
    public Text textoTiempo;
    public Text textoGolpes;
    public TextMeshProUGUI golpesNecesariosText;
    public float timer;
    public int golpesNecesarios;
    public int nivel = 1;
    public GameObject perdido;

    public void Start()
    {
        golpesNecesariosText.text = "NIVEL " + nivel + "" + "Golpes Necesarios " + "" + golpesNecesarios;
        StartCoroutine(DesactivarTexto());
    }

    IEnumerator DesactivarTexto()
    {
        yield return new WaitForSeconds(2f);
        golpesNecesariosText.text = null;
    }

	void Update ()
    {
        timer -= Time.deltaTime;

        textoTiempo.text = timer.ToString("f0");

        textoGolpes.text = "Golpes  " + "" + golpes;

        if (timer <= 0 && golpes > golpesNecesarios)
        {
            seguir();
        }

        if (timer <= 0 && golpes < golpesNecesarios)
        {
            perder();
        }
	}

    public void perder()
    {
        Guante.SetActive(false);
        Spawner.SetActive(false);
        perdido.SetActive(true);
    }

    public void Golpe()
    {
        golpes++;
    }

    public void seguir()
    {
        nivel++;
        timer = 30f;
        golpesNecesarios *= 2;
        golpesNecesariosText.text = "NIVEL " + nivel.ToString() + " " + "Golpes Necesarios " + "" + golpesNecesarios;
        StartCoroutine(DesactivarTexto());
    }
}
