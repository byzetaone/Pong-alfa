using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptME : MonoBehaviour
{
    public bool player1;
    public bool player2;
    public bool transpaso;

    public float speed;
    public Rigidbody2D rb; //referencia de la fisica del objeto
    public Rigidbody2D otro_yo;

    private float move; //lo usaremos para mover al jugador
    private Vector2 StartPos; //para reiniciar posiciones tras marcar tanto


    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        player1 = true;
        player2 = false;
        transpaso = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transpaso = true;
        }

        if (player1 == true && player2 == false)
        {

            move = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, move * speed);
            if (Input.GetKeyDown(KeyCode.Space) && transpaso == true)
            {
                player1 = false;
                player2 = true;
                transpaso = false;

            }


        }

        else if (player2 == true && player1 == false)
        {

            move = Input.GetAxisRaw("Vertical");
            otro_yo.velocity = new Vector2(rb.velocity.x, move * speed);
            if (Input.GetKeyDown(KeyCode.Space) && transpaso == true)
            {
                player1 = true;
                player2 = false;
                transpaso = false;
            }


        }

        //rb.velocity = new Vector2(rb.velocity.x, move * speed);
        //Vector2 almacena dos coordenadas entre corchetes
        //rb.velocity.x al ppo estará a cero y no podremos movernos en el eje X
        //move*speed nos calcula lo que subiremos hacia el eje Y
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero; //tip para poner a cero el movimiento
        transform.position = StartPos;
    }
}
