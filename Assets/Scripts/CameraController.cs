using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform player;
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


        if (!playerController.falled)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(player.position);
            Vector3 delta = player.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = new Vector3(player.position.x + delta.x + 2, player.position.y + delta.y + 1, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            //transform.position = new Vector3(transform.position.x, player.position.y + 1, transform.position.z);
        }
        if (playerController.falled)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(player.position);
            Vector3 delta = player.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = new Vector3(player.position.x, player.position.y + delta.y -2 , transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            //transform.position = new Vector3(transform.position.x, player.position.y + 1, transform.position.z);
        }
    }
}
