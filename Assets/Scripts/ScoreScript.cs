using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour
{

    static int score = 0;
    static int highScore = 0;
    Text instruction;
  

    static public void AddPoint()
    {

        score++;

        if (score > highScore)
        {
            highScore = score;
        }
    }



    void Start()
    {

       

        instruction = GetComponent<Text>();

        score = 0;
       // PlayerPrefs.SetInt("highScore", 0);
        highScore = PlayerPrefs.GetInt("highScore", 0);
     /*   if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("HighScore").GetComponent<AudioSource>().Play();

        }*/
     
    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("highScore", highScore);
        PlayerPrefs.SetInt("Score", score);
       
    }

    void Update()
    {
      
      
        PlayerPrefs.SetInt("Score", score);
        instruction.text = ""+ score;


    }
}
