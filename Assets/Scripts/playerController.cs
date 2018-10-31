using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 using GooglePlayGames;
    using UnityEngine.SocialPlatforms;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour
{
   // public GameObject player;
    Quaternion resulting;
    public GameObject particle;
   public Animation animation;
    Quaternion beginning;
    AnimationClip rotation;
    AnimationCurve curve_x;
    AnimationCurve curve_y;
    AnimationCurve curve_z;
    AnimationCurve curve_w;
    public GameObject star1, star2, star3,scoreimage,coinimage;
    public GameObject score, coins;
    public Sprite[] starsprites;
    public static bool tips1=false;
    public static bool tips2 = false;
    public static bool tips3 = false;
    public static bool tips4 = false;
    public Sprite[] messageprites;
   public static  bool LevelFinished;
    static public bool pauseCheck = true;
    public static bool Dead;
    bool collided;
    bool coinscalculated;
    public AudioClip stars;
    public AudioClip coinssound;
    AudioSource audio;
    AudioSource audio2;
    bool message;
    bool collidedleft, collidedright=false;
    public float FirstYPosition = 0f;
    public float SecondYPosition = 0f;
    // Drag your second sprite here
    public static bool isGrounded = false;
    private SpriteRenderer spriteRenderer;
    public static float position = 2;
    float velocity = 0.06f;
    public Sprite[] sprites;
    public static bool jumpedtwice;
    public static bool isFlying = false;
    public static bool movingright, movingleft;
    public static float result;
    public Rigidbody2D rb;
    bool nextstage = false;
    public static bool Showads=false;
   public static float time2 = 0.5f;
   public static float time5 = 0.1f;
   public static float time3 = 1f;
    public GameObject cam;
    bool open = false;
    public GameObject canvas1;
    BoxCollider2D collider;
    public GameObject canvas2;
    public GameObject canvas3;
    public static string direction ="";
    Animator anim;
    public GameObject monsters;
    public LayerMask pause;
    int selectedskin;
    public static bool jumpinvoked;
    Touch touch;
    int i;
    public static bool skinchanged;
    bool starsapeared;
    bool hasPlayed;
    public static bool falled;
    // Use this for initialization
    public static bool over;
    int levelselected;
    public void activatePlayer()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;

    }
    void Awake()
    {
        skinchanged = false;
        message = false;
        coinscalculated = true;
        starsapeared = true;
        levelselected = PlayerPrefs.GetInt("SelectedLevel", 1);
       
        direction = "stop";
        falled = false;
     movingright =false;
     movingleft = false;
        LevelFinished = false;
        jumpinvoked = false;
        jumpedtwice = false;
        Dead = false;
       
        position = 2;
       // monsters.SetActive(true);
        anim = GetComponent<Animator>();
        over = false;
        isFlying = false;
        rb = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.3858734f, 0.2386671f);
        gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.03155269f, -0.005666478f);
     //   gameObject.GetComponent<Animator>().enabled = false;
       // gameObject.GetComponent<SpriteRenderer>().enabled = false;
        PlayerPrefs.SetInt("floor", 1);
        selectedskin = PlayerPrefs.GetInt("SkinSelected", 1);
        switch (selectedskin)
        {


            case 1:
                anim.speed=0;
                anim.SetInteger("skin", 1);
                collider = gameObject.GetComponent<BoxCollider2D>();
                        anim.SetBool("jumped", !open);
                        anim.Play("player1");
                    
                        //0.01594189
           
                break;
            case 2:
             
                anim.SetInteger("skin", 2);
               // anim.SetBool("jumped", !open);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                
                        anim.SetBool("jumped", !open);
                        anim.Play("player2");
                break;
            case 3:

                anim.SetInteger("skin", 3);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player3");
                break;
            case 4:
                anim.SetInteger("skin", 4);
                anim.speed = 1;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player4");
                break;
            case 5:
                anim.SetInteger("skin", 5);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
            
                     

                        anim.SetBool("jumped", !open);
                        anim.Play("player5");
                break;
            case 6:
                anim.SetInteger("skin", 6);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player6");
                break;
            case 7:
                anim.SetInteger("skin", 7);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player7");
                break;
            case 8:
                anim.SetInteger("skin", 8);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player8");
                break;

            case 9:
                anim.SetInteger("skin", 9);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player9");
                break;
            case 10:
                anim.SetInteger("skin", 10);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player10");
                break;
            case 11:
                anim.SetInteger("skin", 11);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player11");
                break;
            case 12:
                anim.SetInteger("skin", 12);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player12");
                break;
            case 13:
                anim.SetInteger("skin", 13);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player13");
                break;
            case 14:
                anim.SetInteger("skin", 14);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player14");
                break;
            case 15:
                anim.SetInteger("skin", 15);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player15");
                break;
            case 16:
                anim.SetInteger("skin", 16);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player16");
                break;
            case 17:
                anim.SetInteger("skin", 17);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player17");
                break;
            case 18:
                anim.SetInteger("skin", 18);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player18");
                break;
            case 19:
                anim.SetInteger("skin", 19);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player19");
                break;
            case 20:
                anim.SetInteger("skin", 20);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player20");
                break;
            case 21:
                anim.SetInteger("skin", 21);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player21");
                break;
            case 22:
                anim.SetInteger("skin", 22);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player22");
                break;
            case 23:
                anim.SetInteger("skin", 23);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player23");
                break;
            case 24:
                anim.SetInteger("skin", 24);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player24");
                break;
        }
    }
    void Start()
    {
       // animation = player.GetComponent<Animation>();
        particle.SetActive(false);
        this.gameObject.layer = LayerMask.NameToLayer("Player");
        rotation = new AnimationClip();
        audio = GetComponent<AudioSource>();
        audio2 = GetComponent<AudioSource>();
         i = 0;
       //  PlayerPrefs.SetInt("CurrentCandy", 20);
         //LevelFinished = true;
         hasPlayed = false;
         isGrounded = true;
    }

    // Update is called once per frame

  public  IEnumerator displayscore()
    {

        switch (levelselected)
        {

            case 1:
                PlayerPrefs.SetInt("Level1Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 10)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel1", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0)+1);

                    }
                  
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {


                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                                }
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 10 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 20))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel1", 0) && (2-PlayerPrefs.GetInt("StarsLevel1", 0)==1))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel1", 0) && (2 - PlayerPrefs.GetInt("StarsLevel1", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {

                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                                }
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 20)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel1", 0) && (3 - PlayerPrefs.GetInt("StarsLevel1", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel1", 0) && (3 - PlayerPrefs.GetInt("StarsLevel1", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel1", 0) && (3 - PlayerPrefs.GetInt("StarsLevel1", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel1", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;

                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {

                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                                }
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 20:
                PlayerPrefs.SetInt("Level20Done", 1);
              

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel20", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {


                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                                }
                            }



                            coins.GetComponent<Text>().text = i + " /28";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 28))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel20", 0) && (2 - PlayerPrefs.GetInt("StarsLevel20", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel20", 0) && (2 - PlayerPrefs.GetInt("StarsLevel20", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {

                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}

                                }
                            }



                            coins.GetComponent<Text>().text = i + " /28";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 28)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel20", 0) && (3 - PlayerPrefs.GetInt("StarsLevel20", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel20", 0) && (3 - PlayerPrefs.GetInt("StarsLevel20", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel20", 0) && (3 - PlayerPrefs.GetInt("StarsLevel20", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel20", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1)
                            {
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                            }

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                                {


                                    if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                                }
                            }



                            coins.GetComponent<Text>().text = i + " /28";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 19:
                PlayerPrefs.SetInt("Level19Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel19", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 25))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel19", 0) && (2 - PlayerPrefs.GetInt("StarsLevel19", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel19", 0) && (2 - PlayerPrefs.GetInt("StarsLevel19", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 25)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel19", 0) && (3 - PlayerPrefs.GetInt("StarsLevel19", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel19", 0) && (3 - PlayerPrefs.GetInt("StarsLevel19", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel19", 0) && (3 - PlayerPrefs.GetInt("StarsLevel19", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel19", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 2:

                PlayerPrefs.SetInt("Level2Done", 1);
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel2", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0)+1);

                    }
                  
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel2", 0) && (2-PlayerPrefs.GetInt("StarsLevel2", 0)==1))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel2", 0) && (2 - PlayerPrefs.GetInt("StarsLevel2", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel2", 0) && (3 - PlayerPrefs.GetInt("StarsLevel2", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel2", 0) && (3 - PlayerPrefs.GetInt("StarsLevel2", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel2", 0) && (3 - PlayerPrefs.GetInt("StarsLevel2", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel2", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }


        
                break;
            case 3:
                PlayerPrefs.SetInt("Level3Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel3", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 29))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel3", 0) && (2 - PlayerPrefs.GetInt("StarsLevel3", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel3", 0) && (2 - PlayerPrefs.GetInt("StarsLevel3", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 25)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel3", 0) && (3 - PlayerPrefs.GetInt("StarsLevel3", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel3", 0) && (3 - PlayerPrefs.GetInt("StarsLevel3", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel3", 0) && (3 - PlayerPrefs.GetInt("StarsLevel3", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel3", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 4:
                PlayerPrefs.SetInt("Level4Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel4", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 27))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel4", 0) && (2 - PlayerPrefs.GetInt("StarsLevel4", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel4", 0) && (2 - PlayerPrefs.GetInt("StarsLevel4", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 27)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel4", 0) && (3 - PlayerPrefs.GetInt("StarsLevel4", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel4", 0) && (3 - PlayerPrefs.GetInt("StarsLevel4", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel4", 0) && (3 - PlayerPrefs.GetInt("StarsLevel4", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel4", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 5:
                PlayerPrefs.SetInt("Level5Done", 1);

              
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel5", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel5", 0) && (2 - PlayerPrefs.GetInt("StarsLevel5", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel5", 0) && (2 - PlayerPrefs.GetInt("StarsLevel5", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel5", 0) && (3 - PlayerPrefs.GetInt("StarsLevel5", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel5", 0) && (3 - PlayerPrefs.GetInt("StarsLevel5", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel5", 0) && (3 - PlayerPrefs.GetInt("StarsLevel5", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel5", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 6:
                PlayerPrefs.SetInt("Level6Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel6", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel6", 0) && (2 - PlayerPrefs.GetInt("StarsLevel6", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel6", 0) && (2 - PlayerPrefs.GetInt("StarsLevel6", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel6", 0) && (3 - PlayerPrefs.GetInt("StarsLevel6", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel6", 0) && (3 - PlayerPrefs.GetInt("StarsLevel6", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel6", 0) && (3 - PlayerPrefs.GetInt("StarsLevel6", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel6", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 21:
                PlayerPrefs.SetInt("Level21Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel21", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 23))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel21", 0) && (2 - PlayerPrefs.GetInt("StarsLevel21", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel21", 0) && (2 - PlayerPrefs.GetInt("StarsLevel21", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 23)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel21", 0) && (3 - PlayerPrefs.GetInt("StarsLevel21", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel21", 0) && (3 - PlayerPrefs.GetInt("StarsLevel21", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel21", 0) && (3 - PlayerPrefs.GetInt("StarsLevel21", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel21", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 7:
                PlayerPrefs.SetInt("Level7Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel7", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel7", 0) && (2 - PlayerPrefs.GetInt("StarsLevel7", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel7", 0) && (2 - PlayerPrefs.GetInt("StarsLevel7", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel7", 0) && (3 - PlayerPrefs.GetInt("StarsLevel7", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel7", 0) && (3 - PlayerPrefs.GetInt("StarsLevel7", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel7", 0) && (3 - PlayerPrefs.GetInt("StarsLevel7", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel7", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 22:
                PlayerPrefs.SetInt("Level22Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel22", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel22", 0) && (2 - PlayerPrefs.GetInt("StarsLevel22", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel22", 0) && (2 - PlayerPrefs.GetInt("StarsLevel22", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel22", 0) && (3 - PlayerPrefs.GetInt("StarsLevel22", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel22", 0) && (3 - PlayerPrefs.GetInt("StarsLevel22", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel22", 0) && (3 - PlayerPrefs.GetInt("StarsLevel22", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel22", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;

            case 8:
                PlayerPrefs.SetInt("Level8Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel8", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel8", 0) && (2 - PlayerPrefs.GetInt("StarsLevel8", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel8", 0) && (2 - PlayerPrefs.GetInt("StarsLevel8", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel8", 0) && (3 - PlayerPrefs.GetInt("StarsLevel8", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel8", 0) && (3 - PlayerPrefs.GetInt("StarsLevel8", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel8", 0) && (3 - PlayerPrefs.GetInt("StarsLevel8", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel8", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 23:
                PlayerPrefs.SetInt("Level23Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 10)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel23", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 10 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 20))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel23", 0) && (2 - PlayerPrefs.GetInt("StarsLevel23", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel23", 0) && (2 - PlayerPrefs.GetInt("StarsLevel23", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 20)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel23", 0) && (3 - PlayerPrefs.GetInt("StarsLevel23", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel23", 0) && (3 - PlayerPrefs.GetInt("StarsLevel23", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel23", 0) && (3 - PlayerPrefs.GetInt("StarsLevel23", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel23", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 9:
                PlayerPrefs.SetInt("Level9Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 25)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel9", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 25 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 40))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel9", 0) && (2 - PlayerPrefs.GetInt("StarsLevel9", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel9", 0) && (2 - PlayerPrefs.GetInt("StarsLevel9", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 40)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel9", 0) && (3 - PlayerPrefs.GetInt("StarsLevel9", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel9", 0) && (3 - PlayerPrefs.GetInt("StarsLevel9", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel9", 0) && (3 - PlayerPrefs.GetInt("StarsLevel9", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel9", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 24:
                PlayerPrefs.SetInt("Level24Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 20)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel24", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 20 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel24", 0) && (2 - PlayerPrefs.GetInt("StarsLevel24", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel24", 0) && (2 - PlayerPrefs.GetInt("StarsLevel24", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel24", 0) && (3 - PlayerPrefs.GetInt("StarsLevel24", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel24", 0) && (3 - PlayerPrefs.GetInt("StarsLevel24", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel24", 0) && (3 - PlayerPrefs.GetInt("StarsLevel24", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel24", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 10:
                PlayerPrefs.SetInt("Level10Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel10", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel10", 0) && (2 - PlayerPrefs.GetInt("StarsLevel10", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel10", 0) && (2 - PlayerPrefs.GetInt("StarsLevel10", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel10", 0) && (3 - PlayerPrefs.GetInt("StarsLevel10", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel10", 0) && (3 - PlayerPrefs.GetInt("StarsLevel10", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel10", 0) && (3 - PlayerPrefs.GetInt("StarsLevel10", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel10", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 25:
                PlayerPrefs.SetInt("Level25Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel25", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 27))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel25", 0) && (2 - PlayerPrefs.GetInt("StarsLevel25", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel25", 0) && (2 - PlayerPrefs.GetInt("StarsLevel25", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 27)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel25", 0) && (3 - PlayerPrefs.GetInt("StarsLevel25", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel25", 0) && (3 - PlayerPrefs.GetInt("StarsLevel25", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel25", 0) && (3 - PlayerPrefs.GetInt("StarsLevel25", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel25", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /27";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 11:
                PlayerPrefs.SetInt("Level11Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 25)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel11", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /45";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 25 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 45))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel11", 0) && (2 - PlayerPrefs.GetInt("StarsLevel11", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel11", 0) && (2 - PlayerPrefs.GetInt("StarsLevel11", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /45";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 45)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel11", 0) && (3 - PlayerPrefs.GetInt("StarsLevel11", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel11", 0) && (3 - PlayerPrefs.GetInt("StarsLevel11", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel11", 0) && (3 - PlayerPrefs.GetInt("StarsLevel11", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel11", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /45";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 26:
                PlayerPrefs.SetInt("Level26Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 25)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel26", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 25 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 35))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel26", 0) && (2 - PlayerPrefs.GetInt("StarsLevel26", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel26", 0) && (2 - PlayerPrefs.GetInt("StarsLevel26", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 35)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel26", 0) && (3 - PlayerPrefs.GetInt("StarsLevel26", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel26", 0) && (3 - PlayerPrefs.GetInt("StarsLevel26", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel26", 0) && (3 - PlayerPrefs.GetInt("StarsLevel26", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel26", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 12:
                PlayerPrefs.SetInt("Level12Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 20)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel12", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 20 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 40))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel12", 0) && (2 - PlayerPrefs.GetInt("StarsLevel12", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel12", 0) && (2 - PlayerPrefs.GetInt("StarsLevel12", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 40)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel12", 0) && (3 - PlayerPrefs.GetInt("StarsLevel12", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel12", 0) && (3 - PlayerPrefs.GetInt("StarsLevel12", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel12", 0) && (3 - PlayerPrefs.GetInt("StarsLevel12", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel12", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 27:
                PlayerPrefs.SetInt("Level27Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 10)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel27", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 10 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 20))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel27", 0) && (2 - PlayerPrefs.GetInt("StarsLevel27", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel27", 0) && (2 - PlayerPrefs.GetInt("StarsLevel27", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 20)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel27", 0) && (3 - PlayerPrefs.GetInt("StarsLevel27", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel27", 0) && (3 - PlayerPrefs.GetInt("StarsLevel27", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel27", 0) && (3 - PlayerPrefs.GetInt("StarsLevel27", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel27", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /20";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 13:
                PlayerPrefs.SetInt("Level13Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 20)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel13", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 20 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 40))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel13", 0) && (2 - PlayerPrefs.GetInt("StarsLevel13", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel13", 0) && (2 - PlayerPrefs.GetInt("StarsLevel13", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 40)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel13", 0) && (3 - PlayerPrefs.GetInt("StarsLevel13", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel13", 0) && (3 - PlayerPrefs.GetInt("StarsLevel13", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel13", 0) && (3 - PlayerPrefs.GetInt("StarsLevel13", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel13", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 28:
                PlayerPrefs.SetInt("Level28Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel28", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 23))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel28", 0) && (2 - PlayerPrefs.GetInt("StarsLevel28", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel28", 0) && (2 - PlayerPrefs.GetInt("StarsLevel28", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 23)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel28", 0) && (3 - PlayerPrefs.GetInt("StarsLevel28", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel28", 0) && (3 - PlayerPrefs.GetInt("StarsLevel28", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel28", 0) && (3 - PlayerPrefs.GetInt("StarsLevel28", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel28", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /23";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 14:
                PlayerPrefs.SetInt("Level14Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 25)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel14", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 25 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 35))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel14", 0) && (2 - PlayerPrefs.GetInt("StarsLevel14", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel14", 0) && (2 - PlayerPrefs.GetInt("StarsLevel14", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 35)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel14", 0) && (3 - PlayerPrefs.GetInt("StarsLevel14", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel14", 0) && (3 - PlayerPrefs.GetInt("StarsLevel14", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel14", 0) && (3 - PlayerPrefs.GetInt("StarsLevel14", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel14", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 29:
                PlayerPrefs.SetInt("Level29Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 25)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel29", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 25 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 35))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel29", 0) && (2 - PlayerPrefs.GetInt("StarsLevel29", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel29", 0) && (2 - PlayerPrefs.GetInt("StarsLevel29", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 35)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel29", 0) && (3 - PlayerPrefs.GetInt("StarsLevel29", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel29", 0) && (3 - PlayerPrefs.GetInt("StarsLevel29", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel29", 0) && (3 - PlayerPrefs.GetInt("StarsLevel29", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel29", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /35";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 15:
                PlayerPrefs.SetInt("Level15Done", 1);


                Social.ReportProgress("CgkIrOSpp-oUEAIQBA", 100.0f, (bool success) =>
                    {
                        // handle success or failure
                    });
                
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 20)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel15", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 20 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 40))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel15", 0) && (2 - PlayerPrefs.GetInt("StarsLevel15", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel15", 0) && (2 - PlayerPrefs.GetInt("StarsLevel15", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 40)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel15", 0) && (3 - PlayerPrefs.GetInt("StarsLevel15", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel15", 0) && (3 - PlayerPrefs.GetInt("StarsLevel15", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel15", 0) && (3 - PlayerPrefs.GetInt("StarsLevel15", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel15", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /40";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 30:
                PlayerPrefs.SetInt("Level30Done", 1);
                Social.ReportProgress("CgkIrOSpp-oUEAIQBQ", 100.0f, (bool success) =>
                {
                    // handle success or failure
                });
                
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel30", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel30", 0) && (2 - PlayerPrefs.GetInt("StarsLevel30", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel30", 0) && (2 - PlayerPrefs.GetInt("StarsLevel30", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel30", 0) && (3 - PlayerPrefs.GetInt("StarsLevel30", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel30", 0) && (3 - PlayerPrefs.GetInt("StarsLevel30", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel30", 0) && (3 - PlayerPrefs.GetInt("StarsLevel30", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel30", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 16:
                PlayerPrefs.SetInt("Level16Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 10)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel16", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 10 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 25))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel16", 0) && (2 - PlayerPrefs.GetInt("StarsLevel16", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel16", 0) && (2 - PlayerPrefs.GetInt("StarsLevel16", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 25)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel16", 0) && (3 - PlayerPrefs.GetInt("StarsLevel16", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel16", 0) && (3 - PlayerPrefs.GetInt("StarsLevel16", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel16", 0) && (3 - PlayerPrefs.GetInt("StarsLevel16", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel16", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /25";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 17:
                PlayerPrefs.SetInt("Level17Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel17", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 30))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel17", 0) && (2 - PlayerPrefs.GetInt("StarsLevel17", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel17", 0) && (2 - PlayerPrefs.GetInt("StarsLevel17", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 30)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel17", 0) && (3 - PlayerPrefs.GetInt("StarsLevel17", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel17", 0) && (3 - PlayerPrefs.GetInt("StarsLevel17", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel17", 0) && (3 - PlayerPrefs.GetInt("StarsLevel17", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel17", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /30";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;
            case 18:
                PlayerPrefs.SetInt("Level18Done", 1);

                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 1 && PlayerPrefs.GetInt("CurrentCandy", 0) < 15)
                {
                    if (1 > PlayerPrefs.GetInt("StarsLevel18", 0))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 1);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }

                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;

                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        hasPlayed = false;
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        star1.GetComponent<Image>().sprite = starsprites[0];
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;

                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        starsapeared = false;

                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /26";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[0];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) >= 15 && (PlayerPrefs.GetInt("CurrentCandy", 0) < 26))
                {

                    if (2 > PlayerPrefs.GetInt("StarsLevel18", 0) && (2 - PlayerPrefs.GetInt("StarsLevel18", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (2 > PlayerPrefs.GetInt("StarsLevel18", 0) && (2 - PlayerPrefs.GetInt("StarsLevel18", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 2);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (starsapeared)
                    {
                        coinscalculated = false;
                        starsapeared = false;
                        yield return new WaitForSeconds(0.5f);

                        star1.SetActive(true);
                        star2.SetActive(true);
                        star3.SetActive(true);
                        star1.GetComponent<Image>().sprite = starsprites[0];

                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }


                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /26";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[1];
                        scoreimage.SetActive(true);
                    }
                    hasPlayed = false;
                }
                if (PlayerPrefs.GetInt("CurrentCandy", 0) == 26)
                {
                    if (3 > PlayerPrefs.GetInt("StarsLevel18", 0) && (3 - PlayerPrefs.GetInt("StarsLevel18", 0) == 3))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 3);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel18", 0) && (3 - PlayerPrefs.GetInt("StarsLevel18", 0) == 2))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 2);

                    }
                    if (3 > PlayerPrefs.GetInt("StarsLevel18", 0) && (3 - PlayerPrefs.GetInt("StarsLevel18", 0) == 1))
                    {
                        PlayerPrefs.SetInt("StarsLevel18", 3);
                        PlayerPrefs.SetInt("TotalStars", PlayerPrefs.GetInt("TotalStars", 0) + 1);

                    }
                    if (starsapeared)
                    {
                        starsapeared = false;
                        coinscalculated = false;
                        yield return new WaitForSeconds(0.5f);


                        hasPlayed = false;

                        star1.GetComponent<Image>().sprite = starsprites[0];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.6f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}
                        }
                        // GameObject.Find("LockSound").GetComponent<AudioSource>().Play();


                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star2.GetComponent<Image>().sprite = starsprites[1];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 2.8f;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.5f);
                        hasPlayed = false;

                        star3.GetComponent<Image>().sprite = starsprites[2];
                        if (hasPlayed == false)
                        {
                            audio.clip = stars;
                            hasPlayed = true;
                            audio.pitch = 3;
                            if (PlayerPrefs.GetInt("Sound", 1) == 1){audio.Play();}

                        }
                        yield return new WaitForSeconds(0.2f);
                        coinscalculated = true;
                    }

                    if (coinscalculated)
                    {
                        coinscalculated = false;
                        hasPlayed = false;
                        //   audio2.clip = coinssound;
                        while (i <= PlayerPrefs.GetInt("CurrentCandy", 0))
                        {
                            coinimage.SetActive(true);
                            if (hasPlayed == false)
                            {

                                hasPlayed = true;

                                GameObject.Find("Clic").GetComponent<AudioSource>().loop = true;
                                GameObject.Find("Clic").GetComponent<AudioSource>().pitch = 2.7f;
                                if (PlayerPrefs.GetInt("Sound", 1) == 1){GameObject.Find("Clic").GetComponent<AudioSource>().Play();}
                            }



                            coins.GetComponent<Text>().text = i + " /26";
                            yield return new WaitForSeconds(0.03f);
                            i++;
                        }
                        GameObject.Find("Clic").GetComponent<AudioSource>().Stop();
                        yield return new WaitForSeconds(0.2f);
                        message = true;
                    }
                    yield return new WaitForSeconds(0.2f);
                    if (message)
                    {
                        message = false;
                        scoreimage.GetComponent<Image>().sprite = messageprites[2];
                        scoreimage.SetActive(true);
                    }

                    hasPlayed = false;
                }



                break;

              
        }
       
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Tips1")
        {
            other.gameObject.SetActive(false);
            tips1 = true;
            tips2 = false;
            tips3 = false;
            tips4 = false;
        }
        if (other.gameObject.tag == "Tips2")
        {
            other.gameObject.SetActive(false);
            tips1 = false;
            tips2 = true;
            tips3 = false;
            tips4 = false;
        }
        if (other.gameObject.tag == "Tips3")
        {
            other.gameObject.SetActive(false);
            tips1 = false;
            tips2 = false;
            tips3 = true;
            tips4 = false;
        }
        if (other.gameObject.tag == "Tips4")
        {
            other.gameObject.SetActive(false);
            tips1 = false;
            tips2 = false;
            tips3 = false;
            tips4 = true;
        }
        if (other.gameObject.tag == "fall")
        {
            other.gameObject.SetActive(false);

            if (PlayerPrefs.GetInt("NumberOfDeath", 0) < 12)
            {
                PlayerPrefs.SetInt("NumberOfDeath", PlayerPrefs.GetInt("NumberOfDeath", 0) + 1);
            }
            Showads = true;
            falled = true;
            Dead = true;
            over = true;
            canvas1.SetActive(false);
         GetComponent<Rigidbody2D>().gravityScale = 0.2f;
         if (PlayerPrefs.GetInt("Sound", 1) == 1)
         {
             GameObject.Find("Hit").GetComponent<AudioSource>().Play();

         }
        
       


        }
        if (other.gameObject.tag == "Ground")
        {
         
            jumpedtwice = true;

            if (other.gameObject.GetComponent<Collider2D>().isTrigger == false)
            {

                isGrounded = true;
            }
            if (nextstage)
            {
                SecondYPosition = this.transform.position.y;
                result = SecondYPosition - FirstYPosition;
                Debug.Log("result " + result);
                if (!Dead)
                {



                    if ((result > 1.99f) && (result < 2.1f))
                    {
                        ScoreScript.AddPoint();
                        //audio.PlayOneShot(jumpSound2, 0.005F);
                        FirstYPosition = this.transform.position.y;
                    }
                }

            }
            else
            {
                FirstYPosition = this.transform.position.y;
            }

            isGrounded = true;
        }

        if (other.gameObject.tag == "BlueButton")
        {
            GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 2)
        {        
            if (other.gameObject.tag == "RedButton")
        {

            GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
        }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 18)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB1").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 4)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 6)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 7)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 22)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 8)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "RedButton2")
            {

                GameObject.Find("RedB2").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 23)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "RedButton2")
            {

                GameObject.Find("RedB2").GetComponent<ActivateRedScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 9)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }
           
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 24)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 10)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 25)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 11)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("YellowB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 26)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("YellowB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 12)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("YellowB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton2")
            {
                GameObject.Find("BlueB2").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 27)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("YellowB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton2")
            {
                GameObject.Find("BlueB2").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 13)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }

        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
               if (PlayerPrefs.GetInt("SelectedLevel", 1) == 14)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {
                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }

        }
               if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
               {
                   if (other.gameObject.tag == "RedButton")
                   {

                       GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
                   }
                   if (other.gameObject.tag == "BlueButton")
                   {
                       GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
                   }

               }
               if (PlayerPrefs.GetInt("SelectedLevel", 1) == 15)
               {
                   if (other.gameObject.tag == "RedButton")
                   {

                       GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
                   }
                   if (other.gameObject.tag == "BlueButton")
                   {
                       GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
                   }

               }
               if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
               {
                   if (other.gameObject.tag == "RedButton")
                   {

                       GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
                   }
                   if (other.gameObject.tag == "BlueButton")
                   {
                       GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
                   }

               }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 5)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {

                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 20)
        {
            if (other.gameObject.tag == "RedButton")
            {

                GameObject.Find("RedB").GetComponent<ActivateRedScript>().enabled = true;
            }
            if (other.gameObject.tag == "BlueButton")
            {

                GameObject.Find("BlueB").GetComponent<ActivateBlueScript>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 3)
        {
            if (PlayerPrefs.GetInt("floor", 1) == 2)
            {
                if (other.gameObject.tag == "RedButton")
                {
                    GameObject.Find("RedB1").GetComponent<ActivateRedScript>().enabled = true;
                }
            }
            if (PlayerPrefs.GetInt("floor", 1) == 4)
            {
                if (other.gameObject.tag == "RedButton")
                {
                    GameObject.Find("RedB2").GetComponent<ActivateRedScript>().enabled = true;
                }
            }
        }
      
        if (other.gameObject.tag == "LeftWall")
        {
            collidedleft = true;
        }
        if (other.gameObject.tag == "RightWall")
        {
            collidedright = true;
        }
        if (other.gameObject.tag == "Ground")
        {
            other.gameObject.GetComponent<Collider2D>().isTrigger = true;
           
        }

        if (other.gameObject.tag == "monster")
        {
            if ( PlayerPrefs.GetInt("NumberOfDeath", 0) < 12)
            {
                PlayerPrefs.SetInt("NumberOfDeath", PlayerPrefs.GetInt("NumberOfDeath", 0) + 1);
            }

            Dead = true;
            Showads = true;
            (cam.GetComponent(typeof(shake)) as shake).enabled = true;
            (other.GetComponent(typeof(MonsterController)) as MonsterController).enabled = false;
            (gameObject.GetComponent(typeof(playerController)) as playerController).enabled = false;
            // monsters.SetActive(false);
            canvas1.SetActive(false);
            // canvas2.SetActive(true);

           
          

            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                other.GetComponent<Collider2D>().enabled = false;
                GameObject.Find("Hit").GetComponent<AudioSource>().Play();
           
               
                //GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
            }
            anim.speed = 0;
            other.GetComponent<Animator>().speed = 0;
            Invoke("StopShake", 0.5f);
            Invoke("GameOver", 1.2f);
            // Application.LoadLevel("sceneGame");

        }


    }
    void GameOver()
    {
        over = true;
        monsters.SetActive(false);
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        gameObject.SetActive(false);
      
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.3f;
       
            
        }
/*
        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("Loose").GetComponent<AudioSource>().Play();

        }
  */
 }

    void LevelCleared()
    {
       // Time.timeScale= 0;

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("Jump").GetComponent<AudioSource>().volume=0;

        }
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;

        }

      
        canvas3.SetActive(true);
        StartCoroutine(displayscore());
      
    }

    void StopShake()
    {
        (cam.GetComponent(typeof(shake)) as shake).enabled = false;


    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            if (!isFlying)
            isGrounded = !isGrounded;
        }

        if (!isFlying)
        {
            if (other.gameObject.tag == "Ground")
            {
                other.gameObject.GetComponent<Collider2D>().isTrigger = true;
            }
        }
        if (other.gameObject.tag == "Ground")
        {

            if (PlayerPrefs.GetInt("Score", 0) > 0 && (PlayerPrefs.GetInt("Score", 0) == PlayerPrefs.GetInt("highScore", 0)))
            {
                if (PlayerPrefs.GetInt("Sound", 1) == 1 && !playerController.Dead)
                {

                    GameObject.Find("HighScoreingame").GetComponent<AudioSource>().Play();


                    //GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
                }
            }
           // other.gameObject.collider2D.isTrigger = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)


    {
        if (collision.gameObject.tag == "Ground")
        {

           
            isGrounded = true;
        }

        if (collision.gameObject.tag == "FinalFloor")
        {

            LevelFinished = true;
            if (PlayerPrefs.GetInt("Music", 1) == 1)
            {
               // GameObject.Find("LevelCSound").GetComponent<AudioSource>().enabled=true;
                GameObject.Find("Music").GetComponent<AudioSource>().enabled = false;
               // GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;


            }
            if (PlayerPrefs.GetInt("Music", 1) == 1 || PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("LevelCSound").GetComponent<AudioSource>().enabled = true;
               


            }
        //    GameObject.Find("LevelCSound").GetComponent<AudioSource>().enabled = true;
            
        }


        if (collision.gameObject.tag == "leftwallintro")
        {
            direction = "right";
        }
        if (collision.gameObject.tag == "rightwallintro")
        {
            direction = "left";
        }


        if (collision.gameObject.tag == "FirstFloor")
        {
            PlayerPrefs.SetInt("floor", 1);
        }


        if (collision.gameObject.tag == "SecondFloor")
        {
            PlayerPrefs.SetInt("floor", 2);
        }
        if (collision.gameObject.tag == "ThirdFloor")
        {
            PlayerPrefs.SetInt("floor", 3);
        }
        if (collision.gameObject.tag == "NeutralFloor")
        {
            PlayerPrefs.SetInt("floor", 0);
        }
        if (collision.gameObject.tag == "FourthFloor")
        {
            PlayerPrefs.SetInt("floor", 4);
        }
        if (collision.gameObject.tag == "FifthFloor")
        {
            PlayerPrefs.SetInt("floor", 5);
        }
        if (collision.gameObject.name == "plank1")
        {
            PlayerPrefs.SetInt("floor", 0);
            transform.parent = collision.transform;
         
            // transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
        if (collision.gameObject.name == "plank2")
        {
            PlayerPrefs.SetInt("floor", 0);
            transform.parent = collision.transform;

            // transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
        if (collision.gameObject.name == "plank3")
        {
            PlayerPrefs.SetInt("floor", 0);
            transform.parent = collision.transform;

            // transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
        if (collision.gameObject.name == "plank4")
        {
            PlayerPrefs.SetInt("floor", 0);
            transform.parent = collision.transform;

            // transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
     
      

    }



    void jump()
    {
        
        jumpedtwice = false;


        if (isGrounded == true)
        {
            transform.parent = null;
            //   rigidbody2D.transform.Translate(new Vector2(0f, 100f) * Time.deltaTime, Space.World);
            rb.velocity = new Vector3(0, 10f, 0);
            //  rigidbody2D.AddForce(new Vector2(0f, 550f));

            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("Jump").GetComponent<AudioSource>().pitch = 1.5f;
                GameObject.Find("Jump").GetComponent<AudioSource>().Play();

            }
            nextstage = false;
            isGrounded = false;
            isFlying = true;
            jumpinvoked = false;
        }

        else if (!isGrounded && isFlying == true)
        {

            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("Jump").GetComponent<AudioSource>().pitch = 1.5f;
                GameObject.Find("Jump").GetComponent<AudioSource>().Play();

            }
            rb.velocity = new Vector3(0, 7.5f, 0);
            //  rigidbody2D.AddForce(new Vector2(0f, 300f));
            // backgroudScrollerScript.current.Go();
           
            isFlying = false;
            nextstage = true;
            jumpinvoked = false;


        }
    }
  
    void OnTouchBegan(Vector2 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            hit.collider.gameObject.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
        }
    }

    void FixedUpdate()
    {
        selectedskin = PlayerPrefs.GetInt("SkinSelected", 1);
        switch (selectedskin)
        {


            case 1:
                anim.speed = 0;
                anim.SetInteger("skin", 1);
                collider = gameObject.GetComponent<BoxCollider2D>();
                anim.SetBool("jumped", !open);
                anim.Play("player1");
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                //0.01594189

                break;
            case 2:

                anim.SetInteger("skin", 2);
                // anim.SetBool("jumped", !open);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);


                anim.SetBool("jumped", !open);
                anim.Play("player2");
                break;
            case 3:

                anim.SetInteger("skin", 3);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player3");
                break;
            case 4:
                anim.SetInteger("skin", 4);
                anim.speed = 1;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player4");
                break;
            case 5:
                anim.SetInteger("skin", 5);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);




                anim.SetBool("jumped", !open);
                anim.Play("player5");
                break;
            case 6:
                anim.SetInteger("skin", 6);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player6");
                break;
            case 7:
                anim.SetInteger("skin", 7);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player7");
                break;
            case 8:
                anim.SetInteger("skin", 8);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player8");
                break;

            case 9:
                anim.SetInteger("skin", 9);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player9");
                break;
            case 10:
                anim.SetInteger("skin", 10);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player10");
                break;
            case 11:
                anim.SetInteger("skin", 11);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player11");
                break;
            case 12:
                anim.SetInteger("skin", 12);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player12");
                break;
            case 13:
                anim.SetInteger("skin", 13);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player13");
                break;
            case 14:
                anim.SetInteger("skin", 14);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player14");
                break;
            case 15:
                anim.SetInteger("skin", 15);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player15");
                break;
            case 16:
                anim.SetInteger("skin", 16);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player16");
                break;
            case 17:
                anim.SetInteger("skin", 17);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player17");
                break;
            case 18:
                anim.SetInteger("skin", 18);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player18");
                break;
            case 19:
                anim.SetInteger("skin", 19);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player19");
                break;
            case 20:
                anim.SetInteger("skin", 20);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player20");
                break;
            case 21:
                anim.SetInteger("skin", 21);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player21");
                break;
            case 22:
                anim.SetInteger("skin", 22);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player22");
                break;
            case 23:
                anim.SetInteger("skin", 23);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player23");
                break;
            case 24:
                anim.SetInteger("skin", 24);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player24");
                break;
        }
        if(LevelFinished){
            canvas1.SetActive(false);



            direction = "";
/*
            if (time3 > 0)
                time3 -= Time.deltaTime;
            else
            {

                rb.velocity = new Vector3(0, 5.5f, 0);
                //  rigidbody2D.AddForce(new Vector2(0f, 550f));
              
              
                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                {
                    GameObject.Find("Jump").GetComponent<AudioSource>().Play();

                }
                time3 = 1f;
            }
 */
            Invoke("LevelCleared", 2);

        }

        if (falled)
        {

            if (movingright)
            {
                Quaternion newRotation = Quaternion.AngleAxis(180, Vector3.right);
                transform.localRotation = Quaternion.Slerp(transform.rotation, newRotation, 0.1f);
            }
            if (movingleft)
            {
                Quaternion newRotation = Quaternion.AngleAxis(180, Vector3.back);
                transform.localRotation = Quaternion.Slerp(transform.rotation, newRotation, 0.1f);

            }
            if (PlayerPrefs.GetInt("NumberOfDeath", 0) < 10)
            {
                PlayerPrefs.SetInt("NumberOfDeath", PlayerPrefs.GetInt("NumberOfDeath", 0) + 1);
            }
            Dead = true;

            Invoke("GameOver", 1.5f);
        }
        if (!Dead && !LevelFinished)
        {







            if (time2 > 0)
                time2 -= Time.deltaTime;
            else
            {
                /*    if (Input.GetTouch(0).phase == TouchPhase.Began)
                    {
                        {
                            RaycastHit2D hit;
                            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                            hit = Physics2D.Raycast(ray.origin, ray.direction, 10, pause);
                            if (hit.transform != null)
                            {
                                Debug.DrawLine(transform.position, Vector3.zero, Color.white, 5f, false);
                                Debug.Log("HIT");

                            }
                        }*/
                /*
                                foreach (Touch touch in Input.touches)
                                {
                                    int pointerID = touch.fingerId;
                                    if (EventSystem.current.IsPointerOverGameObject (pointerID))
                                    {
                                        // at least on touch is over a canvas UI
                       

                                        return;
                                    }
                                    else
                                    {

                      
                                    }

                                    if (touch.phase == TouchPhase.Ended)
                                    {
                                        // here we don't know if the touch was over an canvas UI
                      
                                        return;
                                    }

                                }
                               */


                if (Input.GetKey(KeyCode.RightArrow))
                {

                    transform.localRotation = Quaternion.Euler(0, 180, 0);

                    GetComponent<Rigidbody2D>().transform.Translate(new Vector2(2f, 0) * Time.deltaTime, Space.World);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {


                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    GetComponent<Rigidbody2D>().transform.Translate(new Vector2(-2f, 0) * Time.deltaTime, Space.World);
                }

            
                        if (direction.Equals("left"))
                        {
                            transform.localRotation = Quaternion.Euler(0, 0, 0);
                            GetComponent<Rigidbody2D>().transform.Translate(new Vector2(-2f, 0) * Time.deltaTime, Space.World);
                        }
                        if (direction.Equals("right"))
                        {
                            transform.localRotation = Quaternion.Euler(0, 180, 0);
                            GetComponent<Rigidbody2D>().transform.Translate(new Vector2(2f, 0) * Time.deltaTime, Space.World);
                        }
                  
                
              
                
                if (direction.Equals(""))
                {

                    GetComponent<Rigidbody2D>().transform.Translate(new Vector2(0, 0) * Time.deltaTime, Space.World);
                   
                }

                if (Input.GetKey(KeyCode.UpArrow))
                {

                    jump();
                }

                GetComponent<Rigidbody2D>().gravityScale = 3.6f;

                if (jumpinvoked)

                    jump();



            }

            /*
              
             if ( Application.platform == RuntimePlatform.IPhonePlayer ||
         Application.platform == RuntimePlatform.Android )
     {
         if ( Input.touchCount <= 0 )
             return;
             
         // detect single touch only
         Touch touch  = Input.touches[0];
             
         if ( touch.phase == TouchPhase.Began )
         {
                         Debug.Log( 123 );
             OnTouchBegan( touch.position );
                
         }
     }
     else
     {
         if ( Input.GetMouseButtonDown( 0 ) )
         {
                             
                         Debug.Log(Screen.width-2);

                         if ((Screen.width-Input.mousePosition.x>100) &&(Screen.height-Input.mousePosition.y)>100){
                               
                         }
             OnTouchBegan( Input.mousePosition );
               
         }
     }
     
     
*/







        }


        
    }
    void Animate(Quaternion beginning, Quaternion resulting)
    {
        rotation.ClearCurves();
        curve_x = AnimationCurve.EaseInOut(0, beginning.x, 0.1f, resulting.x);
        curve_y = AnimationCurve.EaseInOut(0, beginning.y, 0.1f, resulting.y);
        curve_z = AnimationCurve.EaseInOut(0, beginning.z, 0.1f, resulting.z);
        curve_w = AnimationCurve.EaseInOut(0, beginning.w, 0.1f, resulting.w);
        rotation.legacy = true;
        rotation.SetCurve("", typeof(Transform), "localRotation.x", curve_x);
        rotation.SetCurve("", typeof(Transform), "localRotation.y", curve_y);
        rotation.SetCurve("", typeof(Transform), "localRotation.z", curve_z);
        rotation.SetCurve("", typeof(Transform), "localRotation.w", curve_w);

     animation.AddClip(rotation,"ro");
       animation.Play("ro");
    }


 /*   public IEnumerator rotat()
    {
           beginning = player.transform.rotation;

                player.transform.Rotate(0, 0,  - 180, Space.World);
                resulting = player.transform.rotation;
                player.transform.rotation = beginning;
                Animate(beginning, resulting);
                yield return new WaitForSeconds(0.1f);
                beginning = player.transform.rotation;

                player.transform.Rotate(0, 0, - 180, Space.World);
                resulting = player.transform.rotation;
                player.transform.rotation = beginning;
                Animate(beginning, resulting);

    }
  */
    void Update()
    {


        if (movingleft || movingright||jumpinvoked)
        {
            particle.SetActive(true);

        }
   

       if(Dead){

           particle.SetActive(false);
       }
        
        /*
        if (jumpinvoked)
        {
            if (movingright)
            {
              //  Quaternion newRotation = Quaternion.AngleAxis(180, Vector3.right);
               // transform.localRotation = Quaternion.Slerp(transform.rotation, newRotation, 0.1f);
              //  StartCoroutine(rotat());
              
              
               
            }
            else if (movingleft)
            {
                Quaternion newRotation = Quaternion.AngleAxis(180, Vector3.back);
                transform.localRotation = Quaternion.Slerp(transform.rotation, newRotation, 0.1f);

            }
        }
         */

     


        if (direction == "right" || direction == "left")
        {
            switch (selectedskin)
            {


                case 1:
                    anim.SetInteger("skin", 1);
                    if (isGrounded)
                    {


                        anim.SetBool("jumped", open);
                        anim.speed = 1;
                        anim.Play("player1");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 2:
                    anim.SetInteger("skin", 2);
                    if (isGrounded)
                    {

                        anim.speed = 1;
                        anim.SetBool("jumped", open);
                        anim.Play("player2");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }




                    break;
                case 3:
                    anim.SetInteger("skin", 3);
                    if (isGrounded)
                    {

                        anim.speed = 1;
                        anim.SetBool("jumped", open);
                        anim.Play("player3");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 4:
                    anim.SetInteger("skin", 4);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player4");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 5:
                    anim.SetInteger("skin", 5);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player5");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 6:
                    anim.SetInteger("skin", 6);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player6");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 7:
                    anim.SetInteger("skin", 7);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player7");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 8:
                    anim.SetInteger("skin", 8);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player8");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 9:
                    anim.SetInteger("skin", 9);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player9");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 10:
                    anim.SetInteger("skin", 10);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player10");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 11:
                    anim.SetInteger("skin", 11);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player11");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 12:
                    anim.SetInteger("skin", 12);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player12");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 13:
                    anim.SetInteger("skin", 13);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player13");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 14:
                    anim.SetInteger("skin", 14);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player14");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 15:
                    anim.SetInteger("skin", 15);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player15");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 16:
                    anim.SetInteger("skin", 16);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player16");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 17:
                    anim.SetInteger("skin", 17);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player17");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 18:
                    anim.SetInteger("skin", 18);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player18");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 19:
                    anim.SetInteger("skin", 19);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player19");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 20:
                    anim.SetInteger("skin", 20);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player20");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 21:
                    anim.SetInteger("skin", 21);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player21");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 22:
                    anim.SetInteger("skin", 22);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player22");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 23:
                    anim.SetInteger("skin", 23);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player23");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 24:
                    anim.SetInteger("skin", 24);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player24");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;

            }
        }
        else
        {

           
            anim.speed = 0;

        }


        }

                  
                





        }



   





