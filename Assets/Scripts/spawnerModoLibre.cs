using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerModoLibre : MonoBehaviour {

    public Vector3 posicion;
    public int decision = 0;
    public Transform position;
    public float timer = 0f;
    public float tiempoSpawn = 7.5f;
    public GameObject balonFutbol;
    public GameObject limon;
    public GameObject sombrero;
    public GameObject jamon;
    public GameObject carro;
    public GameObject bici;
    public GameObject vaca;

    void Start()
    {
        position = GetComponent<Transform>();
        spawn();
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > tiempoSpawn)
        {
            spawn();
        }
    }

    public void spawn()
    {
        posicion = new Vector3(Random.RandomRange(-2.8f, 2.8f), 10f, 0f);
        position.transform.position = posicion;
        decision = Random.Range(1, 8);

        if (decision == 1)
        {
            Instantiate(balonFutbol, position.position, position.rotation);
        }

        if (decision == 2)
        {
            Instantiate(limon, position.position, position.rotation);
        }

        if (decision == 3)
        {
            Instantiate(sombrero, position.position, position.rotation);
        }

        if (decision == 4)
        {
            Instantiate(jamon, position.position, position.rotation);
        }

        if (decision == 5)
        {
            Instantiate(carro, position.position, position.rotation);
        }

        if (decision == 6)
        {
            Instantiate(bici, position.position, position.rotation);
        }

        if (decision == 7)
        {
            Instantiate(vaca, position.position, position.rotation);
        }

        timer = 0f;
    }

}
