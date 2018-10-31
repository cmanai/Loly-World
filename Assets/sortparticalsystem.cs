using UnityEngine;
using System.Collections;

public class sortparticalsystem : MonoBehaviour {
    public string sortinglayername = "Particles";
	// Use this for initialization
	public void Start () {

        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortinglayername;
	}
	
}
