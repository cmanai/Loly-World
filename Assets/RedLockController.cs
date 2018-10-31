using UnityEngine;
using System.Collections;

public class RedLockController : MonoBehaviour
{
    public GameObject animation;
    Animator anim;

    void Start()
    {

        anim = animation.GetComponent<Animator>();
        anim.speed = 0;
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Finish")
        {

            if (!playerController.Dead)
            {



                if (PlayerPrefs.GetInt("CurrentRkeys", 0) > 0)
                {


                    Invoke("startanimation", 0.1f);



                }
            }


        }
    }

    public void startanimation()
    {


        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("LockSound").GetComponent<AudioSource>().Play();

        }
        animation.SetActive(true);
        anim.speed = 1;

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
       
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else   if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {
            anim.Play("explosion5");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {
            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
        else
        {
            anim.Play("explosion3");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
    }
    public void stopanim()
    {

       
        animation.SetActive(false);
        anim.speed = 0;
    }



}
