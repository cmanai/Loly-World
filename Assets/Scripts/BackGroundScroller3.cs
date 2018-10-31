using UnityEngine;
using System.Collections;

public class BackGroundScroller3 : MonoBehaviour {

    public float speed1 = 0;
    public float speed2 = 0;
    public static BackGroundScroller3 current;
    float pos1 = 0;
    float pos2 = 0;
    public Texture[] textures;

    // Use this for initialization
    void Start()
    {
        current = this;
      //  GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Texture"); 



            GetComponent<Renderer>().material.mainTexture = textures[0];
    

    }

    // Update is called once per frame
    void Update()
    {
     

        pos1 += speed1;
        if (pos1 > 1.0f)

            pos1 -= 1.0f;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos1, 0);


    }
    public void Go()
    {

        pos2 += speed2;
        if (pos2 > 1.0f)

            pos2 -= 1.0f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos2);


    }
}
