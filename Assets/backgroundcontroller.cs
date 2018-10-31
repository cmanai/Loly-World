using UnityEngine;
using System.Collections;

public class backgroundcontroller : MonoBehaviour
{
    public Transform cam;
    public float dampTime = 0.20f;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {

    }
    void Awake()
    {


    }

    void FixedUpdate()
    {


        if (!playerController.LevelFinished)
        {
          
            transform.position = new Vector3(cam.position.x , transform.position.y, transform.position.z);
            //transform.position = new Vector3(transform.position.x, player.position.y + 1, transform.position.z);
        }
       
    }
}
