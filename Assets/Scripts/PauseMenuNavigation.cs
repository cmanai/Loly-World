using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;


public class PauseMenuNavigation : MonoBehaviour {
    public static bool mainmenu;
    public bool music = true;
    public GameObject Swipebutton;
    public static float time3 = 0.8f;
    public bool sound = true;
    public EMTransition transition1;
    public EMTransition transition2;
    public GameObject SoundButton;
    public GameObject MusicButton;
    public GameObject Music;
    public GameObject Sound;
    public Sprite SoundOffSprite;
    public Sprite SoundOnSprite;
    public Sprite MusicOffSprite;
    public Sprite MusicOnSprite;
    public GameObject AboutPanel;
    public GameObject AboutPanel2;
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject MainButton;
    public GameObject OkButton;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Message0;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject Message3;
    public GameObject Message4;
    public GameObject Message01;
    public GameObject Message11;
    public GameObject Message21;
    public GameObject Message31;
    public GameObject Message41;
    bool about;
    float fadetime;
   public static int SoundIndex = 1;
   public static int MusicIndex = 1;
  public  GameObject menu;
    public static bool paused =false;
    EventSystem eventSystem;
   public static bool swiped;
   
    public GameObject Plan1;
    public GameObject Plan2;
    public GameObject canvas;
    public GameObject player;
 private Vector2 touchCoordinates;
 public static bool swipedetected;
 bool isCloseScene = true;
 bool button = true;
 int score;
 public void OnTransitionStart()
 {
     if (!button) return;
     if (isCloseScene)
     {
         button = false;
     }
 }

 public void OnTransitionComplete()
 {
     if (!button) return;
     if (isCloseScene)
     {
         isCloseScene = false;
         Invoke("OnStartAnimation", 0.1f);
     }
     else
     {
         button = true;
         isCloseScene = true;
     }
 }
 public void OnStartAnimation()
 {
     transition1.Play();
     transition2.Play();

     swipedetected = false;
 }
 IEnumerator fadein()
 {

    
     if (SoundIndex == 1) { 
     GameObject.Find("SwipeSound").GetComponent<AudioSource>().Play();
    }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
               //  fadetime = GameObject.Find("GM").GetComponent<Fading>().BeginFade(-1);



             }
             else if (swiped == true)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
         }
     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(8.44f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(8.44f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(39.91f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(39.91f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(8.44f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);


                 GameObject.Find("Player").transform.position = new Vector3(8.44f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(39.91f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(39.91f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(10.54f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(12.07f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(26.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(26.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(10.54f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.07f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(26.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(26.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(9.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(9.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     


     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(9.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(9.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
         }



     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-32.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);


                 GameObject.Find("Player").transform.position = new Vector3(-32.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         //-10.01
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(11.3f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(11.3f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-32.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-32.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         //-10.01
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                   gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(11.3f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(11.3f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.81f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(0.81f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         //-10.01
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-10.26f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-10.22f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-9.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-10.72f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(0.81f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(0.81f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         //-10.01
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-10.26f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-10.22f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-9.27f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-10.72f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
     {
      

         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
             
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
               
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                 //canvas.SetActive(false);
                 //OnStartAnimation();
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                  
                 //fadetime = GameObject.Find("GM").GetComponent<Fading>().BeginFade(1);
               
               //  yield return new WaitForSeconds(fadetime);
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(3.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                  

                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.36f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

        
     }


     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(3.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.36f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(3.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.36f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(3.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.36f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }


     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(25.41f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(27.43f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
     {


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(25.41f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(27.43f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(8.109996f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         else    if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(4.2f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(4.2f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(6.697f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(10.02f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(19.94f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(19.94f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(4.2f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(4.2f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(6.697f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(10.02f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(19.94f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(19.94f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(33.435f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(30.089f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(33.435f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(30.089f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;   


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(2.74822f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }


     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6 )
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-2.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-2.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.51f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.51f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-2.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-2.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.93f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.93f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 fadetime = GameObject.Find("GM").GetComponent<Fading>().BeginFade(1);
                 yield return new WaitForSeconds(fadetime);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(35.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(35.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(66.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(64.88f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }

     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                  
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-0.6699582f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-1.04f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(35.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(35.63f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(66.38f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(64.88f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }


     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-19.30803f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
              
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-16.72f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;
             }
         }
     }
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
     {
         if (PlayerPrefs.GetInt("floor", 1) == 5)
         {


             if (swiped == false)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(22, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(20.7f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 4)
         {


             if (swiped == false)
             {

                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(12.83f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
              
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(14.8f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }


         if (PlayerPrefs.GetInt("floor", 1) == 0)
         {


             if (swiped == false)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 1)
         {


             if (swiped == false)
             {
             
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);

                 GameObject.Find("Player").transform.position = new Vector3(-19.30803f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);

                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;



             }
             else if (swiped == true)
             {
             
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 GameObject.Find("Player").transform.position = new Vector3(-16.72f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
         if (PlayerPrefs.GetInt("floor", 1) == 2)
         {


             if (swiped == false)
             {

                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
               
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }

         if (PlayerPrefs.GetInt("floor", 1) == 3)
         {


             if (swiped == false)
             {
                 
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 // GameObject.Find("Player").transform.position = new Vector3(-1.23f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(true);
                 Plan1.SetActive(false);

                 swiped = true;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;


             }
             else if (swiped == true)
             {
                
                 gameObject.GetComponent<Canvas>().sortingOrder = 1;
                 yield return new WaitForSeconds(0.45f);
                 //GameObject.Find("Player").transform.position = new Vector3(0.09f, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
                 Plan2.SetActive(false);
                 Plan1.SetActive(true);
                 swiped = false;
                 yield return new WaitForSeconds(0.5f);
                 gameObject.GetComponent<Canvas>().sortingOrder = -1;

             }
         }
     }
     yield return new WaitForSeconds(0.2f);
     Swipebutton.GetComponent<Button>().interactable = true;
 
 }
 void Update()
 {
     if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
     {
         if (PlayerPrefs.GetInt("FirstTime", 3) == 3)
         {
            
             if (playerController.tips1==true)
             {
                
                 displayabout();
                 playerController.tips1 = false;
             }
             else  if (playerController.tips2==true)
             {
                 displayabout1();
                 playerController.tips2 =false;
             }
             else  if (playerController.tips3==true)
             {
                 displayabout2();
                 playerController.tips3 = false;
             }
             else if (playerController.tips4==true)
             {
                 PlayerPrefs.SetInt("FirstTime", 4);
                 displayabout3();
                 playerController.tips4 = false;
                 
             }
         }
     }
    
        
     

     score=PlayerPrefs.GetInt("Score", 0);

  
  
     SoundIndex = PlayerPrefs.GetInt("Sound", 1);
     MusicIndex = PlayerPrefs.GetInt("Music", 1);
   


     if (!playerController.Dead)
     {
         if (paused)
         {
            
             if (MusicIndex == 1)
             {
                 Music.GetComponent<AudioSource>().volume = 0.3f;
             }
         }
         if (!paused)
         {
           
             if (MusicIndex == 1)
             {
                 Music.GetComponent<AudioSource>().volume = 0.6f;
             }
         }
         if (Input.GetKeyDown("escape"))
         {

             if (!playerController.Dead && !playerController.over && !playerController.LevelFinished)
             {

                 if (SoundIndex == 1)
                 {

                     Sound.GetComponent<AudioSource>().Play();

                 }
                 if (!paused&&!about)
                 {
                     menu.SetActive(true);
                     Time.timeScale = 0;
                     canvas.SetActive(false);
                     paused = true;

                 }
                 else if (paused&&!about)
                 {
                     menu.SetActive(false);
                     Time.timeScale = 1;
                     canvas.SetActive(true);
                     paused = false;


                 }
             }
         }
     }
 }


    public void PauseMenu(string buttonName)
    {

        switch (buttonName)
        {

                case "Aboutyes":
                Time.timeScale = 1;
                AboutPanel2.SetActive(false);
               // menu.SetActive(true);
                
                break;
          
            case "Rate":
             

                    //  Application.OpenURL("http://play.google.com/store/apps/details?id=droidboy.lolyjump.loly");
                    Application.OpenURL("market://details?id=droidboy.lolyjump.loly");
                
                break;
            case "JumpPlayer":
                if(playerController.isGrounded||playerController.isFlying)
                playerController.jumpinvoked =true;
                
                break;
            case "Stop":

                playerController.direction = "stop";



                break;
            case "LeftMove":

                playerController.direction = "left";

                playerController.movingleft = true;
                playerController.movingright = false;

                break;
            case "RightMove":
                playerController.direction = "right";
                    playerController.movingleft = false;
                playerController.movingright = true;
                break;

            case "Swipe":
                Swipebutton.GetComponent<Button>().interactable = false;
                 OnStartAnimation();
         button = !button;
               StartCoroutine(fadein());
                
                
            break;


            case "About":
         
                   about = true;
                //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
                menu.SetActive(false);
                AboutPanel.SetActive(true);
                RightButton.SetActive(true);
                Message0.SetActive(true);
                Message1.SetActive(false);
                Message2.SetActive(false);
                Message3.SetActive(false);
                Message4.SetActive(false);
                LeftButton.SetActive(false);
                MainButton.SetActive(true);
              

            
            break;
            case "Left":


            if (Message1.activeInHierarchy)
            {


                LeftButton.SetActive(false);
                Message1.SetActive(false);
                Message0.SetActive(true);
            }
            else if (Message2.activeInHierarchy)
            {


                Message2.SetActive(false);
                Message1.SetActive(true);
            }
            else if (Message3.activeInHierarchy)
            {



                Message3.SetActive(false);
                Message2.SetActive(true);
            }
            else if (Message4.activeInHierarchy)
            {


                RightButton.SetActive(true);
                Message4.SetActive(false);
                Message3.SetActive(true);
            }


            
            break;
            case "Right":

            if (Message0.activeInHierarchy)
            {


                LeftButton.SetActive(true);
                Message0.SetActive(false);
                Message1.SetActive(true);
            }
            else if (Message1.activeInHierarchy)
            {



                Message1.SetActive(false);
                Message2.SetActive(true);
            }
            else if (Message2.activeInHierarchy)
            {



                Message2.SetActive(false);
                Message3.SetActive(true);
            }
            else if (Message3.activeInHierarchy)
            {


                RightButton.SetActive(false);
                Message3.SetActive(false);
                Message4.SetActive(true);
            }

            break;

            case "MainAbout":
           

                AboutPanel.SetActive(false);
                menu.SetActive(true);
               
                MainButton.SetActive(false);
               
                RightButton.SetActive(true);
                LeftButton.SetActive(false);

                Message1.SetActive(true);

                Message2.SetActive(false);
                Message3.SetActive(false);
                Message4.SetActive(false);

                about = false;
            
            break;
            case "Pause":
                paused = true;
              menu.SetActive(true);
             Time.timeScale = 0;
              playerController.pauseCheck = false;
              canvas.SetActive(false);
             // playerController.over = true;
             
                break;

            case"Next":

                playerController.LevelFinished = false;
                playerController.over = false;
                playerController.Dead = false;
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 2);
                    AutoFade.LoadLevel("Level2", 0.5f, 1, Color.black);
                }
                else  if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 3);
                    AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 4);
                    AutoFade.LoadLevel("Level4", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 5);
                    AutoFade.LoadLevel("Level5", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 6);
                    AutoFade.LoadLevel("Level6", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 7);
                    AutoFade.LoadLevel("Level7", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 8);
                    AutoFade.LoadLevel("Level8", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 9);
                    AutoFade.LoadLevel("Level9", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 10);
                    AutoFade.LoadLevel("Level10", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 11);
                    AutoFade.LoadLevel("Level11", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 12);
                    AutoFade.LoadLevel("Level12", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 13);
                    AutoFade.LoadLevel("Level13", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 14);
                    AutoFade.LoadLevel("Level14", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 15);
                    AutoFade.LoadLevel("Level15", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 17);
                    AutoFade.LoadLevel("Level17", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 18);
                    AutoFade.LoadLevel("Level18", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 19);
                    AutoFade.LoadLevel("Level19", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 20);
                    AutoFade.LoadLevel("Level20", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 21);
                    AutoFade.LoadLevel("Level21", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 22);
                    AutoFade.LoadLevel("Level22", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 23);
                    AutoFade.LoadLevel("Level23", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 24);
                    AutoFade.LoadLevel("Level24", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 25);
                    AutoFade.LoadLevel("Level25", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 26);
                    AutoFade.LoadLevel("Level26", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 27);
                    AutoFade.LoadLevel("Level27", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 28);
                    AutoFade.LoadLevel("Level28", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 29);
                    AutoFade.LoadLevel("Level29", 0.5f, 1, Color.black);
                }
                else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 30);
                    AutoFade.LoadLevel("Level30", 0.5f, 1, Color.black);
                }
                break;

            case "Resume":

                playerController.pauseCheck = true;
                paused = false;
                canvas.SetActive(true);
                menu.SetActive(false);
                Time.timeScale =1;
               playerController.over = false;
               
                break;
            case "Reload":
                  playerController.LevelFinished = false;
                playerController.over = false;
                playerController.Dead = false;
                
                    
                   
                    paused = false;
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 1)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level1", 0, 1, Color.black);

                 
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level2", 0, 1, Color.black);

                 
                  //  Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level3", 0, 1, Color.black);

                     //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level4", 0, 1, Color.black);

            
                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level5", 0, 1, Color.black);

                  
                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level6", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level7", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level8", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level9", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level10", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level11", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level12", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level13", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level14", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level15", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level16", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level17", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level18", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level19", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level20", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level21", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level22", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level23", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level24", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level25", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level26", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level27", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level28", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level29", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
                {
                    Music.GetComponent<AudioSource>().Stop();
                    Music.GetComponent<AudioSource>().volume = 0;
                    playerController.pauseCheck = true;
                    // Invoke("ReLoadGame", 0.3f);
                    Time.timeScale = 1;
                    AutoFade.LoadLevel("Level30", 0, 1, Color.black);

                    //Time.timeScale = 1;
                }
                break;


            case "MainMenu":
                Music.GetComponent<AudioSource>().Stop();
                Music.GetComponent<AudioSource>().volume = 0;
                //Invoke("LoadMain", 0.3f);
                Time.timeScale = 1;
                playerController.pauseCheck = true;
                PlayerPrefs.SetInt("NumberOfDeath", 0);
                MainMenuNavigation.fromlevel = true;
                AutoFade.LoadLevel("MainMenu", 0, 1, Color.black);
                paused = false;
                mainmenu = true;
                playerController.LevelFinished = false;
                playerController.over = false;
                playerController.Dead = false;
               
                  MainMenuNavigation.about = false;
        MainMenuNavigation.store = false;
                break;
            case "Sound":

                if (sound)
                {
                    // SoundButton.GetComponent<SpriteRenderer>().sprite = Resources.Load("soundoff", typeof(Sprite)) as Sprite;
                    SoundButton.GetComponent<Button>().image.sprite = SoundOffSprite;
                    GetComponent<AudioSource>().enabled = false;
                    sound = false;
                    PlayerPrefs.SetInt("Sound", 0);

                }
                else
                {
                    SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
                    GetComponent<AudioSource>().enabled = true;
                    sound = true;
                    PlayerPrefs.SetInt("Sound", 1);

                }


                break;
            case "Music":

                if (music)
                {
                    GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;

                    MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

                    music = false;
                    PlayerPrefs.SetInt("Music", 0);
                }
                else
                {
                    GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.8f;

                    MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
                    music = true;

                    PlayerPrefs.SetInt("Music", 1);

                }


                break;
                /*
            case "Share":

                AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");

//instantiate the object Intent
AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

//call setAction setting ACTION_SEND as parameter
intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

//instantiate the class Uri
AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");

//instantiate the object Uri with the parse of the url's file
                Texture2D screenTexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, true);
        // put buffer into texture
        screenTexture.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.height), 0, 0);
        // apply
        screenTexture.Apply();
                 byte[] dataToSave = screenTexture.EncodeToPNG();
                string destination = Path.Combine(Application.persistentDataPath,System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png");
                File.WriteAllBytes(destination, dataToSave);
AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
//AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://expl.jpg");

//call putExtra with the uri object of the file
intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

//set the type of file
intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");

//instantiate the class UnityPlayer
AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

//instantiate the object currentActivity
AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

//call the activity with our Intent
currentActivity.Call("startActivity", intentObject);
Time.timeScale = 1;
                break;
                 * */
            
        }
    }
    public void displayabout()
    {
      
       
        //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
        menu.SetActive(false);
        AboutPanel2.SetActive(true);
        
        Message01.SetActive(true);
        Message11.SetActive(false);
        Message21.SetActive(false);
        Message31.SetActive(false);
        Message41.SetActive(false);

      
        Time.timeScale = 0;
    }
    public void displayabout1()
    {

       

        //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
        menu.SetActive(false);
        AboutPanel2.SetActive(true);

        Message01.SetActive(false);
        Message11.SetActive(true);
        Message21.SetActive(false);
        Message31.SetActive(false);
        Message41.SetActive(false);

        Time.timeScale = 0;
    }
    public void displayabout2()
    {

     

        //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
        menu.SetActive(false);
        AboutPanel2.SetActive(true);

        Message01.SetActive(false);
        Message11.SetActive(false);
        Message21.SetActive(true);
        Message31.SetActive(false);
        Message41.SetActive(false);

        Time.timeScale = 0;
    }
    public void displayabout3()
    {


        //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
        menu.SetActive(false);
        AboutPanel2.SetActive(true);

        Message01.SetActive(false);
        Message11.SetActive(false);
        Message21.SetActive(false);
        Message31.SetActive(true);
        Message41.SetActive(false);
       
        Time.timeScale = 0;
    }
    void Awake()
    {
      // eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
      //  eventSystem.sendNavigationEvents = false;



       
        swipedetected = false;
      isCloseScene = true;
        button = true;
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);
        PlayerPrefs.SetInt("floor", 1);
        mainmenu = false;

        swiped = false;
        about = false;
        if (SoundIndex == 0)
        {
            SoundButton.GetComponent<Button>().image.sprite = SoundOffSprite;
            GetComponent<AudioSource>().enabled = false;

            sound = false;

        }
        else if (SoundIndex == 1)
        {

            SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
            GetComponent<AudioSource>().enabled = true;
            sound = true;

        }
        if (MusicIndex == 0)
        {

            Music.GetComponent<AudioSource>().volume = 0;

            MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

            music = false;

        }
        else if (MusicIndex == 1)
        {
            Music.GetComponent<AudioSource>().Stop();
          
            Invoke("volume", 0.3f);
          

            MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
            music = true;

        }

    }
    void volume()
    {
        Music.GetComponent<AudioSource>().volume = 0.6f;
        Music.GetComponent<AudioSource>().Play();

    }
   
}
