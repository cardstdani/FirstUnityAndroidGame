using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linea : MonoBehaviour {

    public retencionManager scriptManager;
    public GameObject corazon1;
    public GameObject corazon2;
    public GameObject corazon3;
    public int vidas = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Objeto"))
        {
            restarVidas();
        }
    }

    public void restarVidas()
    {
        vidas--;
        scriptManager.restarObjetos();

        if (vidas == 3)
        {
            corazon1.SetActive(true);
            corazon2.SetActive(true);
            corazon3.SetActive(true);
        }

        if (vidas == 2)
        {
            corazon1.SetActive(false);
            corazon2.SetActive(true);
            corazon3.SetActive(true);
        }

        if (vidas == 1)
        {
            corazon1.SetActive(false);
            corazon2.SetActive(false);
            corazon3.SetActive(true);
        }


        if (vidas == 0)
        {
            corazon1.SetActive(false);
            corazon2.SetActive(false);
            corazon3.SetActive(false);
        }

        if (vidas < 0)
        {
            scriptManager.perder();
        }
    }
}
