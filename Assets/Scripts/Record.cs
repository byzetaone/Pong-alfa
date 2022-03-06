using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Gamemanager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (CompareTag("Player_1"))
            {
                Gamemanager.GetComponent<Game_Manager>().ScorePlayer1();
                Gamemanager.GetComponent<Game_Manager>().Score_Record();
            }

            if (CompareTag("Player_2"))
            {
                Gamemanager.GetComponent<Game_Manager>().ScorePlayer2();
                Gamemanager.GetComponent<Game_Manager>().Score_Record();
            }
        }

    }





}
