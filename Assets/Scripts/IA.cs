using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public GameObject ball;

    public float speed = 3;
    private Vector2 ballposition;



    private void Update()
    {
        move();
    }
    private void move()
    {
        ballposition = ball.transform.position;

        //comprobamos la posicion de la bola respecto a nuestro IA.

        if (ballposition.y > transform.position.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime); //Se multiplica por delta Time porque es independiente del frame rate y en negativo speed para que vaya al lado contrario
        }

        if (ballposition.y < transform.position.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime); //Se multiplica por delta Time porque es independiente del frame rate y en negativo speed para que vaya al lado contrario
        }
    }
}
