using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{

    public GameObject ball;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Datos;
   
    public GameObject IA;

    public GameObject Goal_Player1;
    public GameObject Goal_Player2;

    public Text Player1Text;
    public Text Player2Text;
    public Text Player_record_ext;

    private string record_actual_texto = "Pref_record";



    private int scoreplayer1;
    private int scoreplayer2;
    public  int scoreplayer_record;

    public int maxScore=2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ScorePlayer1()
    {
       
        scoreplayer1++;
        Player1Text.text = scoreplayer1.ToString();
        Scene actual = SceneManager.GetActiveScene();
        if (actual.name == "Player_vs_me")
        {
            Score_Record();
        }
        //Score_Record();

        ResetPosition();
        checkvictory();

    }

    public void ScorePlayer2()
    {
        scoreplayer2++;
        Player2Text.text = scoreplayer2.ToString();
        Scene actual = SceneManager.GetActiveScene();
        if (actual.name == "Player_vs_me")
        {
            Score_Record();
        }
        //Score_Record();
       
        ResetPosition();
        checkvictory();

    }

    public void Score_Record()
    {
        
        scoreplayer_record++;
        Player_record_ext.text = scoreplayer_record.ToString();
        PlayerPrefs.SetInt(record_actual_texto, scoreplayer_record);



    }
    public void checkvictory()
    {

        if (scoreplayer1 >= maxScore)
        {
            SceneManager.LoadScene("Victory_player1");

        }

        if (scoreplayer2 >= maxScore)
        {
            if (IA.GetComponent<Players>().IA == true)
            {
                SceneManager.LoadScene("Victory_ia");
            }
            else
            SceneManager.LoadScene("Victory_player2");
        }
    }

    public void ResetPosition ()
    {
        ball.GetComponent<Ball>().Reset();
        ball.GetComponent<Ball>().Launch();
        Player1.GetComponent<Players>().Reset();
        Player2.GetComponent<Players>().Reset();
        IA.GetComponent<Players>().Reset();

       
    }


    

}
