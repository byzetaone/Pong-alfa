using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Players : MonoBehaviour
{

    public bool player1;
    public bool player2;
    public bool IA;
    public bool ME;
    public bool transpaso;

    public float speed;
    public Rigidbody2D rb;
    public Rigidbody2D otro_yo;

    public float move;
    private Vector2 StartPos; //para reiniciar a la posicion inicial tras marcar tanto


    void Start()

    {

        Posicion_inicial();
        Scene actual = SceneManager.GetActiveScene();
        if (actual.name == "Player_vs_ia")
        {
            IA = true;
        }
        else IA = false;

        if (actual.name == "Player_vs_me")
        {
            ME = true;
        }
        else ME = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        Who_controls();
        rb.velocity = new Vector2(rb.velocity.x, move * speed);
        //Vector2 almacena dos coordenadas entre corchetes
        //rb.velocity.x al ppo estará a cero y no podremos movernos en el eje X
        //move*speed nos calcula lo que subiremos hacia el eje Y
    }

    private void Posicion_inicial ()
    {
        StartPos = rb.transform.position; //al ser un vector guarda las dos coordenadas
    }

    private void Who_controls()
    {
        
        if (player1 == true)
        {
            move = Input.GetAxis("Vertical");
        }

        if (player2 == true)
        {
            move = Input.GetAxis("Player2");
        }

        
}

    public void Reset()
    {
        rb.velocity = Vector2.zero; //tip para poner a cero el movimiento
        transform.position = StartPos;
    }
}
