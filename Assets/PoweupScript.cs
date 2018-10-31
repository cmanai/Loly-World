using UnityEngine;
using System.Collections;

public class PoweupScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 100 * Time.deltaTime);
	}
}
