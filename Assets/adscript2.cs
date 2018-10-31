using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using GooglePlayGames.BasicApi;
using GooglePlayGames;
public class adscript2 : MonoBehaviour
{
    private const string Ad_Unit_ID = "ca-app-pub-9499257650407538/3572719604";
    private const string Ad_Intertitial_ID = "ca-app-pub-9499257650407538/9340051606";

 

    private AdMobPlugin admob;
    // Use this for initialization
  
    void Awake()
    {
      
        admob = GetComponent<AdMobPlugin>();
        admob.CreateBanner(Ad_Unit_ID, AdMobPlugin.AdSize.SMART_BANNER, false, Ad_Intertitial_ID, false);//, Ad_Intertitial_ID
        admob.RequestAd();
       


    }
    void Update()
    {


        if (MainMenuNavigation.playClicked)
        {
            admob.HideBanner();

        }

        if (!MainMenuNavigation.playClicked)
        {
            admob.ShowBanner();

        }

    }
  
   


}
