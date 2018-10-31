using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackGroundScroller2 : MonoBehaviour
{
    public float speed1 = 0;
    public float speed2 = 0;
    public static BackGroundScroller2 current;
    float pos1 = 0;
    float pos2 = 0;
    public Texture[] textures;

    // Use this for initialization
    void Start()
    {
      current = this;

     // GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Texture"); 

      if (PlayerPrefs.GetInt("WorldShown", 1)==1)
      {

          GetComponent<Renderer>().material.mainTexture = textures[0];
      }
      if (PlayerPrefs.GetInt("WorldShown", 1) == 2)
      {

          GetComponent<Renderer>().material.mainTexture = textures[1];
      }
      if (PlayerPrefs.GetInt("WorldShown", 1) == 3)
      {

          GetComponent<Renderer>().material.mainTexture = textures[2];
      }
      if (PlayerPrefs.GetInt("WorldShown", 1) == 4)
      {

          GetComponent<Renderer>().material.mainTexture = textures[3];
      }
  
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("WorldShown", 1) == 1)
        {

            GetComponent<Renderer>().material.mainTexture = textures[0];
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 2)
        {

            GetComponent<Renderer>().material.mainTexture = textures[1];
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 3)
        {

            GetComponent<Renderer>().material.mainTexture = textures[2];
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 4)
        {

            GetComponent<Renderer>().material.mainTexture = textures[3];
        }

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
