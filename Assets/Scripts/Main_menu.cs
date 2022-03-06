using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Run_player_vs_player()
    {
        SceneManager.LoadScene("Player_vs_player");
    }

    public void Run_player_vs_ia()
    {
        SceneManager.LoadScene("Player_vs_ia");
    }

    public void Run_player_vs_me()
    {
        SceneManager.LoadScene("Player_vs_me");
    }

    public void Run_custom_game()
    {
        SceneManager.LoadScene("Custom_game");
    }

    public void Run_exit_game()
    {
        Application.Quit();
    }
}

