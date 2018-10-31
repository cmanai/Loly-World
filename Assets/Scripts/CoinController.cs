using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinController : MonoBehaviour
{
    public GameObject plusone;
    bool collidedleft, collidedright;
    void OnTriggerEnter2D(Collider2D other)
    {




    
        if (other.gameObject.tag == "Finish")
        {


       
            if (!playerController.Dead)
            {
                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                {
                    GameObject.Find("CoinSound").GetComponent<AudioSource>().Play();

                }
              
                CoinScript.AddPoint();


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






      



    }

    float RandomElementRange(float index_1, float index_2)
    {
        float index;
        index = Random.Range(index_1, index_2);
        index = Mathf.RoundToInt(index);
        return index;
    }


}
