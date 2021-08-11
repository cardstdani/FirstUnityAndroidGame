using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mano : MonoBehaviour {

    public float distancia = 10f;

    public void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public void OnMouseDrag()
    {
        Vector3 posicionMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distancia);
        Vector3 posicion = Camera.main.ScreenToWorldPoint(posicionMouse);

        transform.position = posicion;
    }
}
