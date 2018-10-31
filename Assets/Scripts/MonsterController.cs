using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterController : MonoBehaviour
{

    bool collidedleft, collidedright = false;
   

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
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
     
    }




    void FixedUpdate()
    {

/*
        if (bubble.transform.position.y - this.transform.position.y > 4)
        {
            this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 2)], this.transform.position.y + randomElementPositionY[Random.Range(0, 2)], -5.04f);

            velocity = randomElementVelocity[Random.Range(0, 5)];
        }
        */
        if (collidedleft)
        {

            transform.localRotation = Quaternion.Euler(0, 180, 0);
            GetComponent<Rigidbody2D>().transform.Translate(Vector3.right * Time.deltaTime, Space.World);

        }
        if (collidedright)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
          
            GetComponent<Rigidbody2D>().transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }



       


        }





  

}
