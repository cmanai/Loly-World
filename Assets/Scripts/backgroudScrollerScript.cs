using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class backgroudScrollerScript : MonoBehaviour {
    public float speed1= 0;
    public float speed2 = 0;
    public static backgroudScrollerScript current;
    float pos1 = 0;
    float pos2 = 0;
    public Texture[] textures;
    int TextureIndex=0;
    Shader shader;
	// Use this for initialization
    void Awake()
    {
       // shader = Shader.Find("Unlit/Transparent");
        //GetComponent<Renderer>().material.shader = shader;
     
    }
	void Start () {
        current = this;
        
        if (textures.Length == 0)
            return;



        GetComponent<Renderer>().material.mainTexture = textures[0];
        TextureIndex = PlayerPrefs.GetInt("TextureSky", 0);
     
       /* switch (TextureIndex)
        {

            case 0:

              
                PlayerPrefs.SetInt("TextureSky", 1);
                break;
            case 1:
                  renderer.material.mainTexture = textures[1];
                PlayerPrefs.SetInt("TextureSky", 2);
                break;
            case 2:
                  renderer.material.mainTexture = textures[2];
                PlayerPrefs.SetInt("TextureSky", 3);
                break;
            case 3:
                  renderer.material.mainTexture = textures[3];
                PlayerPrefs.SetInt("TextureSky", 4);
                break;
            case 4:
                  renderer.material.mainTexture = textures[4];
                PlayerPrefs.SetInt("TextureSky", 5);
                break;
            case 5:
                  renderer.material.mainTexture = textures[5];
                PlayerPrefs.SetInt("TextureSky", 6);
                break;
            case 6:
                  renderer.material.mainTexture = textures[6];
                PlayerPrefs.SetInt("TextureSky", 7);
                break;
            case 7:
                  renderer.material.mainTexture = textures[7];
                PlayerPrefs.SetInt("TextureSky", 0);
                break;
        }
        * */
       
	}
	
	// Update is called once per frame
	void Update () {
       
        if (!playerController.falled)
        {
            pos1 += speed1;
            if (pos1 > 1.0f)

                pos1 -= 1.0f;

            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos1, 0);
        }
        else
        {
            pos1 += speed1;
            if (pos1 > 1.0f)

                pos1 -= 1.0f;
            pos2 += speed2;
            if (pos2 > 1.0f)

                pos2 -= 1.0f;

            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos1, -pos2);

        }
           
	}
 public   void Go()
    {

        pos2 += speed2;
        if (pos2 > 1.0f)

            pos2 -= 1.0f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos2);


    }
}
