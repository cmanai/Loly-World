using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinScript : MonoBehaviour
{

    static int Current_nb_candy = 0;
    static int Total_nb_candy = 0;
    Text instruction;


    static public void AddPoint()
    {

        Current_nb_candy++;

     
    }



    void Start()
    {


        instruction = GetComponent<Text>();

        Current_nb_candy = 0;
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        Debug.Log(Total_nb_candy + " this is the total of candys");
        var Total_score = PlayerPrefs.GetInt("highScore", 0);
        Debug.Log(Total_score + " this is highscore");
    }

    void OnDestroy()
    {

       
    }

    void Update()
    {

        if (playerController.LevelFinished)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);
            PlayerPrefs.SetInt("Total_Candy", Current_nb_candy + Total_nb_candy);
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /20";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /25";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /27";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /40";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /45";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /35";
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /40";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /20";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /40";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /23";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /35";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /35";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /40";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /25";
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /26";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /25";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /28";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /23";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /20";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /30";
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
        {
            PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);


            instruction.text = Current_nb_candy + " /27";
        }

    }
}
