using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class perdidoContrareloj : MonoBehaviour {

    public contrarelojManager scriptContrareloj;
    public TextMeshProUGUI textoRecord;

    public int golpes2;

	void Update ()
    {
        golpes2 = scriptContrareloj.golpes;
        textoRecord.text = "Puntuacion " + golpes2.ToString() + " golpes";

        if(PlayerPrefs.GetInt("RecordGolpes") < golpes2)
        PlayerPrefs.SetInt("RecordGolpes", golpes2);
	}


    public void menu()
    {
        SceneManager.LoadScene("Principal");
    }
}
