using UnityEngine;
using System.Collections;

public class ActivateBlueScript : MonoBehaviour
{
    public Sprite ButtonOn;
    // Use this for initialization
    void Start()
    {

        Invoke("Activate", 0.1f);

    }

    public void Activate()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
        gameObject.GetComponent<Collider2D>().enabled = false;
        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
        {

            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        else  if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
        {

            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
        {

           
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
        {


            GameObject.Find("plank1").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
        {


            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {


            GameObject.Find("plank1").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {


            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank5").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {
            if (PlayerPrefs.GetInt("floor", 1) == 3)
            {

                GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
            if (PlayerPrefs.GetInt("floor", 1) == 2)
            {

                GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {
            if (PlayerPrefs.GetInt("floor", 1) == 3)
            {

                GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
            if (PlayerPrefs.GetInt("floor", 1) == 2)
            {

                GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {
         

                GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
                GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
          
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
          

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
        {


            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);


        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
        {
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
      
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
        {
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;

            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
        {
            GameObject.Find("plank1").GetComponent<MovePlank2>().enabled = true;

            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
        else {
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
      
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        }
    }

}
