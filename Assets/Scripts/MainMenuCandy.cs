using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuCandy : MonoBehaviour {
    static int Total_nb_candy = 0;
    Text instruction;
	// Use this for initialization
	void Start () {
        instruction = GetComponent<Text>();

        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        instruction.text = "x " + Total_nb_candy;
	}
	
	// Update is called once per frame
	void Update () {
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        instruction.text = "x " + Total_nb_candy;
	}
}
