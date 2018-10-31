using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueKeyScript : MonoBehaviour {


    static int Current_nb_Bkey = 0;
    
    Text instruction;


    static public void AddPoint()
    {

        Current_nb_Bkey++;

     
    }

    static public void RemovePoint()
    {

        Current_nb_Bkey--;


    }



    void Start()
    {


        instruction = GetComponent<Text>();

        Current_nb_Bkey = 0;
       
    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("CurrentBkeys", 0);
    
       
    }

    void Update()
    {
        PlayerPrefs.SetInt("CurrentBkeys", Current_nb_Bkey);
       
        instruction.text = Current_nb_Bkey + " /1";


        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {

            PlayerPrefs.SetInt("CurrentBkeys", Current_nb_Bkey);

            instruction.text = Current_nb_Bkey + " /2";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {

            PlayerPrefs.SetInt("CurrentBkeys", Current_nb_Bkey);

            instruction.text = Current_nb_Bkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {

            PlayerPrefs.SetInt("CurrentBkeys", Current_nb_Bkey);

            instruction.text = Current_nb_Bkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {

            PlayerPrefs.SetInt("CurrentBkeys", Current_nb_Bkey);

            instruction.text = Current_nb_Bkey + " /2";


        }
    }
}
