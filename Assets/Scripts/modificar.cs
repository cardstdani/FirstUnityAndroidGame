using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class modificar : MonoBehaviour {

    public spawnerModoLibre scriptSpawner;
    public TextMeshProUGUI textoSpawner;
    public float tiempoSpawnModificar;
    public PhysicsMaterial2D objetosMaterial;
    public TextMeshProUGUI textoMaterial;

    void Start ()
    {
        textoMaterial.text = objetosMaterial.bounciness.ToString("f0");
        tiempoSpawnModificar = scriptSpawner.tiempoSpawn;
        textoSpawner.text = scriptSpawner.tiempoSpawn.ToString("f0");
	}

    public void aumentar()
    {
       if (tiempoSpawnModificar < 1f)
        {
            tiempoSpawnModificar += 0.1f;
            textoSpawner.text = tiempoSpawnModificar.ToString("f1");
            scriptSpawner.tiempoSpawn = tiempoSpawnModificar;
        }

        if (tiempoSpawnModificar >= 1f)
        {
            tiempoSpawnModificar += 1f;
            textoSpawner.text = tiempoSpawnModificar.ToString("f0");
            scriptSpawner.tiempoSpawn = tiempoSpawnModificar;
        }        
    }

    public void disminuir()
    {
        if (tiempoSpawnModificar > 0f)
        {
            if (tiempoSpawnModificar <= 1f)
            {
                tiempoSpawnModificar -= 0.1f;
                textoSpawner.text = tiempoSpawnModificar.ToString("f1");
                scriptSpawner.tiempoSpawn = tiempoSpawnModificar;
            }

            if (tiempoSpawnModificar > 1f)
            {
                tiempoSpawnModificar -= 1f;
                textoSpawner.text = tiempoSpawnModificar.ToString("f0");
                scriptSpawner.tiempoSpawn = tiempoSpawnModificar;
            }
        }
    }

    public void aumentarMaterial()
    {
        objetosMaterial.bounciness += 1f;
        textoMaterial.text = objetosMaterial.bounciness.ToString("f0");
    }

    public void disminuirMaterial()
    {
        if (objetosMaterial.bounciness >= 1f)
        {
            objetosMaterial.bounciness -= 1f;
        }

        textoMaterial.text = objetosMaterial.bounciness.ToString("f0");
    }
}
