using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGameOver : MonoBehaviour
{

     int score = 0;

    Text instruction;





    void Update()
    {


        instruction = GetComponent<Text>();

        score = PlayerPrefs.GetInt("Score", 0);
        instruction.text = "x   " + score;
    }

}
