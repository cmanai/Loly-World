using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverCandys : MonoBehaviour {


  
    Text instruction;






    void Update()
    {
        instruction = GetComponent<Text>();


        var Current_nb_candy = PlayerPrefs.GetInt("CurrentCandy", 0);
       
    
        instruction.text = "x   " + Current_nb_candy;


    }
}
