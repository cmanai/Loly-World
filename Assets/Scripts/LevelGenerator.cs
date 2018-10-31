using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
   
    public GameObject slime;

    // Use this for initialization
    void Start()
    {
        slime = GameObject.FindGameObjectWithTag("Finish");
       

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > slime.transform.position.y)
        {
           // if (playerController.isGrounded == true)
               // this.collider2D.isTrigger = true;
        }
        if (slime.transform.position.y - this.transform.position.y > 4)
        {
            //this.transform.position = new Vector3(0, this.transform.position.y + 8, 0);
           // this.collider2D.isTrigger = true;
            //this.GetComponentInChildren<MonsterController>().position = 1;
        }
    }
}
