using UnityEngine;
using System.Collections;

public class FadeScript2 : MonoBehaviour
{
    public Texture2D fadeouttexture;
    public float fadespeed = 0f;
    private int drawdepth = 0;
    private float alpha = 0.5f;


    void OnGUI()
    {

        // alpha += dir * fadespeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawdepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeouttexture);

    }

}
