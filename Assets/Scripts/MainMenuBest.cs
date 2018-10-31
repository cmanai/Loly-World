using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuBest : MonoBehaviour
{
    static int Best = 0;
    Text instruction;
    // Use this for initialization
    void Start()
    {
        instruction = GetComponent<Text>();

        Best = PlayerPrefs.GetInt("highScore", 0);
        instruction.text = "Best x " + Best;
    }

    // Update is called once per frame
    void Update()
    {
        instruction = GetComponent<Text>();

        Best = PlayerPrefs.GetInt("highScore", 0);
        instruction.text = "Best x " + Best;
    }
}
