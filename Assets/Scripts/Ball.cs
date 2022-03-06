using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Vector2 StartPos;

    public Rigidbody2D rb;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        Posicion_inicial();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Posicion_inicial()
    {
        StartPos = rb.transform.position; //al ser un vector guarda las dos coordenadas
    }

    public void Launch ()
    {
        float x = Random.RandomRange(0, 2) == 0 ? -1 : 1; // devuelve 1 0 -1
        float y = Random.RandomRange(0, 2) == 0 ? -1 : 1; // devuelve 1 0 -1
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        transform.position = StartPos;
        rb.velocity = Vector2.zero;
    }

}
