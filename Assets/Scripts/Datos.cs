using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Datos : MonoBehaviour
{

    private string record_actual_texto = "myInt";
    

    private int record_actual;
    private int record_anterior;
    private int defaultIntValue = -1;

    public Text previousSessionIntText;
 
    private string noDataFoundMessage = "Sin datos guardados";
    private string sceneName = "PersistentDataWithPlayerPrefs";


    void Start()
    {

        Cargar_datos();


        Guardar_datos();

    }



    private void Guardar_datos()
    {
        PlayerPrefs.SetInt(record_actual_texto, record_actual);


    }

    private void Cargar_datos()
    {
        //Load Integer
        bool result = PlayerPrefs.HasKey(record_actual_texto);
        if (result)
        {
            record_anterior = PlayerPrefs.GetInt(record_actual_texto);
            previousSessionIntText.text = record_anterior.ToString();
        }
        else
        {
            previousSessionIntText.text = noDataFoundMessage;
        }


    }


    public void RestartButton()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Borrar_datos()
    {
        //PlayerPrefs.DeleteAll();

        if (PlayerPrefs.HasKey(record_actual_texto))
        {
            PlayerPrefs.DeleteKey(record_actual_texto);
        }


    }


}
