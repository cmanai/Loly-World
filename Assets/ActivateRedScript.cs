using UnityEngine;
using System.Collections;

public class ActivateRedScript : MonoBehaviour
{
    public Sprite ButtonOn;
    // Use this for initialization
    void Start()
    {

        Invoke("Activate", 0.1f);

    }

    public void Activate()
    {

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            if (PlayerPrefs.GetInt("floor", 1) == 2)
            {
                GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
            if (PlayerPrefs.GetInt("floor", 1) == 3)
            {
                GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            if (PlayerPrefs.GetInt("floor", 1) == 2)
            {
                GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
            if (PlayerPrefs.GetInt("floor", 1) == 3)
            {
                GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank2").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
            GameObject.Find("plank4").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
          
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank2>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank1").GetComponent<MovePlank1>().enabled = true;
     
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.06f, transform.position.z);

        if(PlayerPrefs.GetInt("floor", 1) == 4){

            gameObject.GetComponent<SpriteRenderer>().sprite = ButtonOn;
            gameObject.GetComponent<Collider2D>().enabled = false;
            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("ButtonSound").GetComponent<AudioSource>().Play();

            }
            GameObject.Find("plank3").GetComponent<MovePlank1>().enabled = true;

            transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            }
        }
    }

}
