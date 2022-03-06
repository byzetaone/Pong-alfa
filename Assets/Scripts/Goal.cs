using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    
public GameObject Gamemanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene actual = SceneManager.GetActiveScene();


        //Cuando colisiona con un objeto lo almacena en collision y de ahi podemos sacar infomracion
        if (collision.CompareTag("Ball"))
        {
          
            if (CompareTag("Goal_Player1"))
            {
                
                if (actual.name == "Player_vs_me")
                {
                    SceneManager.LoadScene("Victory_me");
                }
                Gamemanager.GetComponent<Game_Manager>().ScorePlayer2();
            }
            else if (CompareTag("Goal_Player2"))
            {
                
                if (actual.name == "Player_vs_me")
                {
                    SceneManager.LoadScene("Victory_me");
                }
                Gamemanager.GetComponent<Game_Manager>().ScorePlayer1();
            }

       
        }


    }


}
