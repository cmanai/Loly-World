using UnityEngine;
using System.Collections;

public class MovePlank2 : MonoBehaviour
{
    bool Dead;
    bool collided;

    float velocity = 0.05f;
    float time = 0.0022f;
    float position;
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
    }

    void FixedUpdate()
    {


        if (collidedleft)
        {


            GetComponent<Rigidbody2D>().transform.Translate(Vector3.up * Time.deltaTime, Space.World);

        }
        if (collidedright)
        {

            GetComponent<Rigidbody2D>().transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }



    }
}
