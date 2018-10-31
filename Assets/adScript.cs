using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using GooglePlayGames.BasicApi;
using GooglePlayGames;

public class adScript : MonoBehaviour {
#if UNITY_ANDROID
    private const string Ad_Unit_ID = "ca-app-pub-9499257650407538/6756829606";
    private const string Ad_Intertitial_ID = "ca-app-pub-9499257650407538/8233562809";

    private const string Unity_ID = "81733";

#elif UNITY_IPHONE

    private const string Ad_Unit_ID = "ca-app-pub-9499257650407538/4951816004";
    private const string Ad_Intertitial_ID = "ca-app-pub-9499257650407538/6428549200";

    private const string Unity_ID = "78878";

#endif
    private AdMobPlugin admob;
	// Use this for initialization
    void Awake()
    {


   
        if (Advertisement.isSupported)
        {

           
            Advertisement.Initialize(Unity_ID, false);
        }
      
        admob = GetComponent<AdMobPlugin>();
        admob.CreateBanner(Ad_Unit_ID, AdMobPlugin.AdSize.SMART_BANNER, false, Ad_Intertitial_ID, false);//, Ad_Intertitial_ID
        admob.RequestAd();
    }
	
    public void OnEnable()
    {


        AdMobPlugin.InterstitialLoaded += HandleInterstitialLoaded;
    }
    public void OnDisable()
    {


        AdMobPlugin.InterstitialLoaded -= HandleInterstitialLoaded;
        
        
    }

    public void HandleInterstitialLoaded()
    {
      
        admob.ShowInterstitial();

      
    }
    void Update()
    {

        if (PauseMenuNavigation.paused || playerController.over || playerController.LevelFinished)
        {
            admob.ShowBanner();

        }
        else if (PauseMenuNavigation.paused == false && playerController.over == false && playerController.LevelFinished == false)
        {
            admob.HideBanner();

        }

        
        if (playerController.Showads==true && PlayerPrefs.GetInt("NumberOfDeath", 0) == 6 )
        {

            playerController.over = false;
            playerController.Dead = false;
            playerController.Showads = false;
           admob.RequestInterstitial();



         
        }
        else   if (playerController.Showads==true && PlayerPrefs.GetInt("NumberOfDeath", 0) == 12 )
        {

            PlayerPrefs.SetInt("NumberOfDeath", 0);
            playerController.Dead = false;
            playerController.over = false;
            playerController.Showads = false;
            
              Advertisement.Show(

                   null, new ShowOptions {
                       resultCallback = result =>
                       {

                       }
                   });

           
        }
        
       
    }
	

}
