using UnityEngine;
using System.Collections;

public class plusoneController : MonoBehaviour {

	// Use this for initialization
    Color color;
    float time = 0.15f;

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
	// Update is called once per frame
    public void fadout(){

    }
	void FixedUpdate () {
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        else
        {

            color = GetComponent<Renderer>().material.color;
            color.a -= 0.05f;
            GetComponent<Renderer>().material.color = color;
        }
        
     
	}
}
