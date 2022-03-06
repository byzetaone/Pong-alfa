using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryPlayer : MonoBehaviour
{
    
    public void LoadMainMenu ()
    {
        
        SceneManager.LoadScene("Main_menu");
    }

    

    public void Reloadlastgame()
    {
        Scene actual = SceneManager.GetActiveScene();

        if (actual.name == "Victory_player1")
        {
            SceneManager.LoadScene("Player_vs_player");
        }

        if (actual.name == "Victory_player2")
        {
            SceneManager.LoadScene("Player_vs_player");
        }

        if (actual.name == "Victory_ia")
        {
            SceneManager.LoadScene("Player_vs_ia");
        }

        if (actual.name == "Victory_me")
        {
            SceneManager.LoadScene("Player_vs_me");
        }

    }

    public GameObject record;
    public int Player_record;
    public Text Player_record_text;

    public void mostrar ()
    {
        Player_record=record.GetComponent<Game_Manager>().scoreplayer_record;
        Player_record_text.text = Player_record.ToString();

    }


    public void Update()
    {
        Scene actual = SceneManager.GetActiveScene();
        if (actual.name == "Player_vs_me")
        {
            mostrar();
        }
        
    }
}
