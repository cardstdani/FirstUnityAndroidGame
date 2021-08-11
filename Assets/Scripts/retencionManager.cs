using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class retencionManager : MonoBehaviour {

    public GameObject Linea;
    public GameObject spawner;
    public int objetos = 0;
    public GameObject perdido;
    public TextMeshProUGUI textoObjetos;
    public TextMeshProUGUI textoPuntuacion;
    
    public void spawnear()
    {
        objetos++;
        textoObjetos.text = "Objetos" + objetos.ToString();
    }

    public void restarObjetos()
    {
        objetos--;
        textoObjetos.text = "Objetos" + objetos.ToString();
    }

    public void perder()
    {
        perdido.SetActive(true);
        spawner.SetActive(false);
        Linea.SetActive(false);
        textoObjetos.text = "";
        textoPuntuacion.text = "Puntuacion " + objetos.ToString();

        if(PlayerPrefs.GetInt("RecordObjetos") < objetos)
        PlayerPrefs.SetInt("RecordObjetos", objetos);
    }

    public void menu()
    {
        SceneManager.LoadScene("Principal");
    }
}
