using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Datos : MonoBehaviour
{

    private string record_actual_texto = "Pref_record";
    

    public int record_actual;
    public int record_anterior;
    private int defaultIntValue = -1;

    public Text previousSessionIntText;
 
    private string noDataFoundMessage = "Sin datos guardados";



    void Start()
    {

        Cargar_datos();
   

    }


public void Cargar_datos()
    {
        //Load Integer
        bool result = PlayerPrefs.HasKey(record_actual_texto);
        if (result)
        {
            record_anterior = PlayerPrefs.GetInt(record_actual_texto)-1;
            previousSessionIntText.text = record_anterior.ToString();
        }
        else
        {
            previousSessionIntText.text = noDataFoundMessage;
        }


    }



}
