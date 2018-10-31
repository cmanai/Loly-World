using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class candyController : MonoBehaviour
{
    bool Dead;
    bool collided;
    bool collidedleft, collidedright;
    // Drag your second sprite here
    float time = 0.5f;
    public bool isGrounded = true;
    public GameObject bubble;
    bool jumped = true;
    public Sprite plusone;
    public Sprite candy;
    private SpriteRenderer spriteRenderer;
    List<float> randomElementPositionX = new List<float>();
    List<float> randomElementPositionY = new List<float>();




    // Use this for initialization
    void Start()
    {

        randomElementPositionX.Add(-1.5f);
        randomElementPositionX.Add(0f);
        randomElementPositionX.Add(1.5f);



        randomElementPositionY.Add(15.99f);

        // this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 3)], this.transform.position.y + randomElementPositionY[Random.Range(0, 1)], this.transform.position.z);
    }

    // Update is called once per frame


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "LeftWall")
        {
            collidedleft = true;
            collidedright = false;
        }
        if (other.gameObject.tag == "RightWall")
        {
            collidedright = true;
            collidedleft = false;
        }
        if (other.gameObject.tag == "Finish")
        {

            if (!playerController.Dead)
            {
                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                {
                    GameObject.Find("Candy").GetComponent<AudioSource>().Play();

                }

               // CandyScript.AddPoint();

              
                Invoke("MoveObject", 0.3f);

            }
        }

    }

    public void MoveObject()
    {

        // this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 3)], this.transform.position.y + randomElementPositionY[Random.Range(0, 1)], this.transform.position.z);
        gameObject.SetActive(false);
        gameObject.GetComponent<Collider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().sprite = candy;
        gameObject.transform.localScale = new Vector3(0.3783499f, 0.3783499f, 0.3783499f);
    }

    void FixedUpdate()
    {
        /*
                if (time > 0)
                {
                    time -= Time.deltaTime;
          
                }
                else
                {

                    if (jumped)
                    {
                       // this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.09f, this.transform.position.z);
                        rigidbody2D.transform.Translate(new Vector2(0, 4f) * Time.deltaTime, Space.Self);
                        jumped = false;
                    }
                    else
                    {
                        jumped = true;
                     //   this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.09f, this.transform.position.z);
                        rigidbody2D.transform.Translate(new Vector2(0, -4f) * Time.deltaTime, Space.Self);
                    }
                        //  Debug.Log(position + "");
                    time = 0.5f;
                    //	transform.position = new Vector2(position,0f);
                }
         */







        if (collidedleft)
        {


           // rigidbody2D.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -0.2f, 0);

        }
        if (collidedright)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0.2f, 0);
           // rigidbody2D.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }



    








    }

   



}
