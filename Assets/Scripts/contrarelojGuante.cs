using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrarelojGuante : MonoBehaviour {

    public contrarelojManager scriptContrareloj;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Objeto"))
        {
            scriptContrareloj.Golpe();
        }
    }

	void Start () {
		
	}
	
	void Update () {
		
	}
}
