using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RedKeyScript : MonoBehaviour
{


    static int Current_nb_Rkey = 0;

    Text instruction;


    static public void AddPoint()
    {

        Current_nb_Rkey++;


    }

    static public void RemovePoint()
    {

        Current_nb_Rkey--;


    }



    void Start()
    {


        instruction = GetComponent<Text>();

        Current_nb_Rkey = 0;

    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("CurrentRkeys", 0);


    }

    void Update()
    {
        PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

        instruction.text = Current_nb_Rkey + " /1";


        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /2";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
     
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /2";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
     
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
        {

            PlayerPrefs.SetInt("CurrentRkeys", Current_nb_Rkey);

            instruction.text = Current_nb_Rkey + " /1";


        }

    }
}
