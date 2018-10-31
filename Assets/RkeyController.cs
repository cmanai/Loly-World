using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RkeyController : MonoBehaviour
{
    public GameObject plusone;
    bool collidedleft, collidedright;

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
                    GameObject.Find("KeySound").GetComponent<AudioSource>().Play();

                }

                RedKeyScript.AddPoint();
                gameObject.SetActive(false);
                plusone.SetActive(true);

            }
        }

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
