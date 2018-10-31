using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

using System;
public class MainMenuNavigation : MonoBehaviour {
    public AudioClip clicSound;
 public   bool music =true;
 public   bool sound = true;
 public GameObject SoundButton;
 public GameObject MusicButton;
 public GameObject Music;
 public GameObject Sound;
 public Sprite SoundOffSprite;
 public Sprite SoundOnSprite;
 public Sprite MusicOffSprite;
 public Sprite MusicOnSprite;
    int SoundIndex=1;
    int MusicIndex=1;
    float time = 0.1f;
    public GameObject darkCanvas;
   public bool quitvisible = false;
    public GameObject QuitMenu;
    public GameObject canvasMenu;
    public GameObject WorldCanvas;
    public GameObject BigCanvas;
 public static   bool about = false;

 public static bool store = false;
 public GameObject rate;
    public GameObject AboutPanel;
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject MainButton;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Message0;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject Message3;
    public GameObject Message4;
    public GameObject StorePanel;
    public GameObject Pack1;
    public GameObject Loly1Selected;
    public GameObject Loly1Unselected;
    public GameObject Loly2Locked;
    public GameObject Loly2Selected;
    public GameObject Loly2Unselected;
    public GameObject Loly3Locked;
    public GameObject Loly3Selected;
    public GameObject Loly3Unselected;
    public GameObject Loly4Locked;
    public GameObject Loly4Selected;
    public GameObject Loly4Unselected;
    public GameObject Loly5Locked;
    public GameObject Loly5Selected;
    public GameObject Loly5Unselected;
    public GameObject Loly6Locked;
    public GameObject Loly6Selected;
    public GameObject Loly6Unselected;
    public GameObject Loly7Locked;
    public GameObject Loly7Selected;
    public GameObject Loly7Unselected;
    public GameObject Loly8Locked;
    public GameObject Loly8Selected;
    public GameObject Loly8Unselected;
    public GameObject Loly9Locked;
    public GameObject Loly9Selected;
    public GameObject Loly9Unselected;
    public GameObject Loly10Locked;
    public GameObject Loly10Selected;
    public GameObject Loly10Unselected;
    public GameObject Loly11Locked;
    public GameObject Loly11Selected;
    public GameObject Loly11Unselected;
    public GameObject Loly12Locked;
    public GameObject Loly12Selected;
    public GameObject Loly12Unselected;
    public GameObject Loly13Locked;
    public GameObject Loly13Selected;
    public GameObject Loly13Unselected;
    public GameObject Loly14Locked;
    public GameObject Loly14Selected;
    public GameObject Loly14Unselected;
    public GameObject Loly15Locked;
    public GameObject Loly15Selected;
    public GameObject Loly15Unselected;
    public GameObject Loly16Locked;
    public GameObject Loly16Selected;
    public GameObject Loly16Unselected;
    public GameObject Loly17Locked;
    public GameObject Loly17Selected;
    public GameObject Loly17Unselected;
    public GameObject Loly18Locked;
    public GameObject Loly18Selected;
    public GameObject Loly18Unselected;
    public GameObject Loly19Locked;
    public GameObject Loly19Selected;
    public GameObject Loly19Unselected;
    public GameObject Loly20Locked;
    public GameObject Loly20Selected;
    public GameObject Loly20Unselected;
    public GameObject Loly21Locked;
    public GameObject Loly21Selected;
    public GameObject Loly21Unselected;
    public GameObject Loly22Locked;
    public GameObject Loly22Selected;
    public GameObject Loly22Unselected;
    public GameObject Loly23Locked;
    public GameObject Loly23Selected;
    public GameObject Loly23Unselected;
    public GameObject Loly24Locked;
    public GameObject Loly24Selected;
    public GameObject Loly24Unselected;
    public GameObject MainMenuScore;

    public GameObject Pack2;
    public GameObject Pack3;
    public GameObject RightButtonStore;
    public GameObject LeftButtonStore;
    public GameObject MainButtonStore;
    public GameObject Title;
    int SkinSelected;
    int Unlocked2;
    int Unlocked3; 
    int Unlocked4; 
    int Unlocked5; 
    int Unlocked6; 
    int Unlocked7;
    int Unlocked8;
    int Unlocked9;
    int Unlocked10;
    int Unlocked11;
    int Unlocked12;
    int Unlocked13;
    int Unlocked14;
    int Unlocked15;
    int Unlocked16;
    int Unlocked17;
    int Unlocked18;
    int Unlocked19;
    int Unlocked20;
    int Unlocked21;
    int Unlocked22;
    int Unlocked23;
    int Unlocked24;
    int Total_nb_candy;
    int pos2;
    bool play;
    public static bool playClicked;
    public GameObject rightlevel, leftlevel;
    public GameObject World1;
    public GameObject World2Locked;
    public GameObject World2Unlocked;
    public GameObject World3Locked;
    public GameObject World3Unlocked;
    public GameObject World4Locked;
    public GameObject World4Unlocked;

    public GameObject Level1Done;
    public GameObject Level1Undone;
    public GameObject Level2Undone;
    public GameObject Level2Done;
    public GameObject Level2Locked;

    public GameObject Level3Undone;
    public GameObject Level3Done;
    public GameObject Level3Locked;
    public GameObject Level4Undone;
    public GameObject Level4Done;
    public GameObject Level4Locked;
    public GameObject Level5Undone;
    public GameObject Level5Done;
    public GameObject Level5Locked;
    public GameObject Level6Undone;
    public GameObject Level6Done;
    public GameObject Level6Locked;
    public GameObject Level7Undone;
    public GameObject Level7Done;
    public GameObject Level7Locked;
    public GameObject Level8Undone;
    public GameObject Level8Done;
    public GameObject Level8Locked;
    public GameObject Level9Undone;
    public GameObject Level9Done;
    public GameObject Level9Locked;
    public GameObject Level10Undone;
    public GameObject Level10Done;
    public GameObject Level10Locked;
    public GameObject Level11Undone;
    public GameObject Level11Done;
    public GameObject Level11Locked;
    public GameObject Level12Undone;
    public GameObject Level12Done;
    public GameObject Level12Locked;
    public GameObject Level13Undone;
    public GameObject Level13Done;
    public GameObject Level13Locked;
    public GameObject Level14Undone;
    public GameObject Level14Done;
    public GameObject Level14Locked;
    public GameObject Level15Undone;
    public GameObject Level15Done;
    public GameObject Level15Locked;
    public GameObject Level16Undone;
    public GameObject Level16Done;

    public GameObject Level17Undone;
    public GameObject Level17Done;
    public GameObject Level17Locked;
    public GameObject Level18Undone;
    public GameObject Level18Done;
    public GameObject Level18Locked;
    public GameObject Level19Undone;
    public GameObject Level19Done;
    public GameObject Level19Locked;
    public GameObject Level20Undone;
    public GameObject Level20Done;
    public GameObject Level20Locked;
    public GameObject Level21Undone;
    public GameObject Level21Done;
    public GameObject Level21Locked;
    public GameObject Level22Undone;
    public GameObject Level22Done;
    public GameObject Level22Locked;
    public GameObject Level23Undone;
    public GameObject Level23Done;
    public GameObject Level23Locked;
    public GameObject Level24Undone;
    public GameObject Level24Done;
    public GameObject Level24Locked;
    public GameObject Level25Undone;
    public GameObject Level25Done;
    public GameObject Level25Locked;
    public GameObject Level26Undone;
    public GameObject Level26Done;
    public GameObject Level26Locked;
    public GameObject Level27Undone;
    public GameObject Level27Done;
    public GameObject Level27Locked;
    public GameObject Level28Undone;
    public GameObject Level28Done;
    public GameObject Level28Locked;
    public GameObject Level29Undone;
    public GameObject Level29Done;
    public GameObject Level29Locked;
    public GameObject Level30Undone;
    public GameObject Level30Done;
    public GameObject Level30Locked;
    public GameObject Level31Undone;
    public GameObject Level31Done;
   
    public GameObject Level32Undone;
    public GameObject Level32Done;
    public GameObject Level32Locked;
    public GameObject Level33Undone;
    public GameObject Level33Done;
    public GameObject Level33Locked;
    public GameObject Level34Undone;
    public GameObject Level34Done;
    public GameObject Level34Locked;
    public GameObject Level35Undone;
    public GameObject Level35Done;
    public GameObject Level35Locked;
    public GameObject Level36Undone;
    public GameObject Level36Done;
    public GameObject Level36Locked;
    public GameObject Level37Undone;
    public GameObject Level37Done;
    public GameObject Level37Locked;
    public GameObject Level38Undone;
    public GameObject Level38Done;
    public GameObject Level38Locked;
    public GameObject Level39Undone;
    public GameObject Level39Done;
    public GameObject Level39Locked;
    public GameObject Level40Undone;
    public GameObject Level40Done;
    public GameObject Level40Locked;
    public GameObject Level41Undone;
    public GameObject Level41Done;
    public GameObject Level41Locked;
    public GameObject Level42Undone;
    public GameObject Level42Done;
    public GameObject Level42Locked;
    public GameObject Level43Undone;
    public GameObject Level43Done;
    public GameObject Level43Locked;
    public GameObject Level44Undone;
    public GameObject Level44Done;
    public GameObject Level44Locked;
    public GameObject Level45Undone;
    public GameObject Level45Done;
    public GameObject Level45Locked;
    public GameObject Level46Undone;
    public GameObject Level46Done;
    bool popup;
    public GameObject Level47Undone;
    public GameObject Level47Done;
    public GameObject Level47Locked;
    public GameObject Level48Undone;
    public GameObject Level48Done;
    public GameObject Level48Locked;
    public GameObject Level49Undone;
    public GameObject Level49Done;
    public GameObject Level49Locked;
    public GameObject Level50Undone;
    public GameObject Level50Done;
    public GameObject Level50Locked;
    public GameObject Level51Undone;
    public GameObject Level51Done;
    public GameObject Level51Locked;
    public GameObject Level52Undone;
    public GameObject Level52Done;
    public GameObject Level52Locked;
    public GameObject Level53Undone;
    public GameObject Level53Done;
    public GameObject Level53Locked;
    public GameObject Level54Undone;
    public GameObject Level54Done;
    public GameObject Level54Locked;
    public GameObject Level55Undone;
    public GameObject Level55Done;
    public GameObject Level55Locked;
    public GameObject Level56Undone;
    public GameObject Level56Done;
    public GameObject Level56Locked;
    public GameObject Level57Undone;
    public GameObject Level57Done;
    public GameObject Level57Locked;
    public GameObject Level58Undone;
    public GameObject Level58Done;
    public GameObject Level58Locked;
    public GameObject Level59Undone;
    public GameObject Level59Done;
    public GameObject Level59Locked;
    public GameObject Level60Undone;
    public GameObject Level60Done;
    public GameObject Level60Locked;

    public GameObject OtherGAme;
    public GameObject OtherGAmeText;
    public GameObject unlockpanel;
    public GameObject UnlockMessage;
    public Sprite[] UnlockMessages;
    public static bool fromlevel;
    public GameObject W1Decor;
       public GameObject W2Decor;
       public GameObject W3Decor;
       public GameObject W4Decor;
       public GameObject Background1;
      public GameObject Background2;
      public GameObject Background3;
      public GameObject Background4;
      public Sprite[] World2Stars;
      public GameObject World2starsnumber;
    public Sprite[] level1Stars;
    public Sprite[] level2Stars;
    public Sprite[] level3Stars;
    public Sprite[] level4Stars;
    public Sprite[] level5Stars;
    public Sprite[] level6Stars;
    public Sprite[] level7Stars;
    public Sprite[] level8Stars;
    public Sprite[] level9Stars;
    public Sprite[] level10Stars;
    public Sprite[] level11Stars;
    public Sprite[] level12Stars;
    public Sprite[] level13Stars;
    public Sprite[] level14Stars;
    public Sprite[] level15Stars;
    public Sprite[] level16Stars;
    public Sprite[] level17Stars;
    public Sprite[] level18Stars;
    public Sprite[] level19Stars;
    public Sprite[] level20Stars;
    public Sprite[] level21Stars;
    public Sprite[] level22Stars;
    public Sprite[] level23Stars;
    public Sprite[] level24Stars;
    public Sprite[] level25Stars;
    public Sprite[] level26Stars;
    public Sprite[] level27Stars;
    public Sprite[] level28Stars;
    public Sprite[] level29Stars;
    public Sprite[] level30Stars;
    public Sprite[] level31Stars;
    public Sprite[] level32Stars;
    public Sprite[] level33Stars;
    public Sprite[] level34Stars;
    public Sprite[] level35Stars;
    public Sprite[] level36Stars;
    public Sprite[] level37Stars;
    public Sprite[] level38Stars;
    public Sprite[] level39Stars;
    public Sprite[] level40Stars;
    public Sprite[] level41Stars;
    public Sprite[] level42Stars;
    public Sprite[] level43Stars;
    public Sprite[] level44Stars;
    public Sprite[] level45Stars;
    public Sprite[] level46Stars;
    public Sprite[] level47Stars;
    public Sprite[] level48Stars;
    public Sprite[] level49Stars;
    public Sprite[] level50Stars;
    public Sprite[] level51Stars;
    public Sprite[] level52Stars;
    public Sprite[] level53Stars;
    public Sprite[] level54Stars;
    public Sprite[] level55Stars;
    public Sprite[] level56Stars;
    public Sprite[] level57Stars;
    public Sprite[] level58Stars;
    public Sprite[] level59Stars;
    public Sprite[] level60Stars;
    float time2=1.5f;
 //SoundSource.playOnAwake = false; //SoundSource.rolloffMode = AudioRolloffMode.Logarithmic; //SoundSource.loop = true; }


    void Start()
    {

        PlayGamesPlatform.Activate();
      

        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()

            .Build();

        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
    }

   
   

    void Update()
    {

        if (World1.activeInHierarchy)
        {
            PlayerPrefs.SetInt("WorldShown", 1);
            W1Decor.SetActive(true);
            W2Decor.SetActive(false);
            W3Decor.SetActive(false);
            W4Decor.SetActive(false);
            leftlevel.SetActive(false);
            rightlevel.SetActive(true);
            World1.SetActive(true);
            WorldCanvas.SetActive(true);
            canvasMenu.SetActive(false);
            Title.SetActive(false);



        }
      /*  if (play)
        {

            darkCanvas.SetActive(true);
            if (time > 0)
                time -= Time.deltaTime;
            else
            {
                darkCanvas.SetActive(false);
                play = false;
                time = 0.1f;
            }
        }*/

        
        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 7)
        {
            Social.ReportProgress("CgkIrOSpp-oUEAIQAQ", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 15)
        {
            Social.ReportProgress("CgkIrOSpp-oUEAIQAg", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 23)
        {
            Social.ReportProgress("CgkIrOSpp-oUEAIQAw", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
         SkinSelected =  PlayerPrefs.GetInt("SkinSelected",1);
        Unlocked2 = PlayerPrefs.GetInt("Loly2lock", 0);
        Unlocked3 = PlayerPrefs.GetInt("Loly3lock", 0);
        Unlocked4 = PlayerPrefs.GetInt("Loly4lock", 0);
        Unlocked5 = PlayerPrefs.GetInt("Loly5lock", 0);
        Unlocked6 = PlayerPrefs.GetInt("Loly6lock", 0);
        Unlocked7 = PlayerPrefs.GetInt("Loly7lock", 0);
        Unlocked8 = PlayerPrefs.GetInt("Loly8lock", 0);
        Unlocked9 = PlayerPrefs.GetInt("Loly9lock", 0);
        Unlocked10 = PlayerPrefs.GetInt("Loly10lock", 0);
        Unlocked11 = PlayerPrefs.GetInt("Loly11lock", 0);
        Unlocked12 = PlayerPrefs.GetInt("Loly12lock", 0);
        Unlocked13 = PlayerPrefs.GetInt("Loly13lock", 0);
        Unlocked14 = PlayerPrefs.GetInt("Loly14lock", 0);
        Unlocked15 = PlayerPrefs.GetInt("Loly15lock", 0);
        Unlocked16 = PlayerPrefs.GetInt("Loly16lock", 0);
        Unlocked17 = PlayerPrefs.GetInt("Loly17lock", 0);
        Unlocked18 = PlayerPrefs.GetInt("Loly18lock", 0);
        Unlocked19 = PlayerPrefs.GetInt("Loly19lock", 0);
        Unlocked20 = PlayerPrefs.GetInt("Loly20lock", 0);
        Unlocked21 = PlayerPrefs.GetInt("Loly21lock", 0);
        Unlocked22 = PlayerPrefs.GetInt("Loly22lock", 0);
        Unlocked23 = PlayerPrefs.GetInt("Loly23lock", 0);
        Unlocked24 = PlayerPrefs.GetInt("Loly24lock", 0);

        if (Unlocked2 == 1)
        {
            Loly2Locked.SetActive(false);
        }
        else
        {
            Loly2Locked.SetActive(true);

        }
        if (Unlocked3 == 1)
        {
            Loly3Locked.SetActive(false);
        }
        else
        {
            Loly3Locked.SetActive(true);

        }
        if (Unlocked4 == 1)
        {
            Loly4Locked.SetActive(false);
        }
        else
        {
            Loly4Locked.SetActive(true);

        }
        if (Unlocked5 == 1)
        {
            Loly5Locked.SetActive(false);
        }
        else
        {
            Loly5Locked.SetActive(true);

        }
        if (Unlocked6 == 1)
        {
            Loly6Locked.SetActive(false);
        }
        else
        {
            Loly6Locked.SetActive(true);

        }
        if (Unlocked7 == 1)
        {
            Loly7Locked.SetActive(false);
        }
        else
        {
            Loly7Locked.SetActive(true);

        }
        if (Unlocked8 == 1)
        {
            Loly8Locked.SetActive(false);
        }
        else
        {
            Loly8Locked.SetActive(true);

        }
        if (Unlocked9 == 1)
        {
            Loly9Locked.SetActive(false);
        }
        else
        {
            Loly9Locked.SetActive(true);

        }
        if (Unlocked10 == 1)
        {
            Loly10Locked.SetActive(false);
        }
        else
        {
            Loly10Locked.SetActive(true);

        }
        if (Unlocked11 == 1)
        {
            Loly11Locked.SetActive(false);
        }
        else
        {
            Loly11Locked.SetActive(true);

        }
        if (Unlocked12 == 1)
        {
            Loly12Locked.SetActive(false);
        }
        else
        {
            Loly12Locked.SetActive(true);

        }
        if (Unlocked13 == 1)
        {
            Loly13Locked.SetActive(false);
        }
        else
        {
            Loly13Locked.SetActive(true);

        }
        if (Unlocked14 == 1)
        {
            Loly14Locked.SetActive(false);
        }
        else
        {
            Loly14Locked.SetActive(true);

        }
        if (Unlocked15 == 1)
        {
            Loly15Locked.SetActive(false);
        }
        else
        {
            Loly15Locked.SetActive(true);

        }
        if (Unlocked16 == 1)
        {
            Loly16Locked.SetActive(false);
        }
        else
        {
            Loly16Locked.SetActive(true);

        }
        if (Unlocked17 == 1)
        {
            Loly17Locked.SetActive(false);
        }
        else
        {
            Loly17Locked.SetActive(true);

        }
        if (Unlocked18 == 1)
        {
            Loly18Locked.SetActive(false);
        }
        else
        {
            Loly18Locked.SetActive(true);

        }
        if (Unlocked19 == 1)
        {
            Loly19Locked.SetActive(false);
        }
        else
        {
            Loly19Locked.SetActive(true);

        }
        if (Unlocked20 == 1)
        {
            Loly20Locked.SetActive(false);
        }
        else
        {
            Loly20Locked.SetActive(true);

        }
        if (Unlocked21 == 1)
        {
            Loly21Locked.SetActive(false);
        }
        else
        {
            Loly21Locked.SetActive(true);

        }
        if (Unlocked22 == 1)
        {
            Loly22Locked.SetActive(false);
        }
        else
        {
            Loly22Locked.SetActive(true);

        }
        if (Unlocked23 == 1)
        {
            Loly23Locked.SetActive(false);
        }
        else
        {
            Loly23Locked.SetActive(true);

        }
        if (Unlocked24 == 1)
        {
            Loly24Locked.SetActive(false);
        }
        else
        {
            Loly24Locked.SetActive(true);

        }

        switch (SkinSelected)
        {
            case 1:
                Loly1Selected.SetActive(true);
                Loly1Unselected.SetActive(false);
                if (Unlocked2 == 1)
                {
                  Loly2Selected.SetActive(false);
                  Loly2Unselected.SetActive(true);

                }
                if (Unlocked3 == 1)
                {
                    Loly3Selected.SetActive(false);
                    Loly3Unselected.SetActive(true);

                }
                if (Unlocked4 == 1)
                {
                    Loly4Selected.SetActive(false);
                    Loly4Unselected.SetActive(true);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Selected.SetActive(false);
                    Loly5Unselected.SetActive(true);

                }
                if (Unlocked6 == 1)
                {

                    Loly6Selected.SetActive(false);
                    Loly6Unselected.SetActive(true);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Selected.SetActive(false);
                    Loly7Unselected.SetActive(true);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Selected.SetActive(false);
                    Loly8Unselected.SetActive(true);

                }
                if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 2:
                
                if (Unlocked2 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly2Selected.SetActive(true);
                    Loly2Unselected.SetActive(false);

                }
                if (Unlocked3 == 1)
                {
                   
                  
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 3:
                  if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly3Selected.SetActive(true);
                    Loly3Unselected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 4:
                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly4Selected.SetActive(true);
                    Loly4Unselected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 5:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly5Selected.SetActive(true);
                    Loly5Unselected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 6:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly6Selected.SetActive(true);
                    Loly6Unselected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 7:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {

                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly7Selected.SetActive(true);
                    Loly7Unselected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 8:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {

                    Loly8Unselected.SetActive(false);
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly8Selected.SetActive(true);
                  
                   

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }

            break;
            case 9:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
                      if (Unlocked9 == 1)
                {
                    Loly9Unselected.SetActive(false);
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly9Selected.SetActive(true);
                

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 10:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
             
                Loly10Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly10Selected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 11:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
               
                Loly11Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly11Selected.SetActive(true);
            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 12:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly12Selected.SetActive(true);
              

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 13:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly13Selected.SetActive(true);


            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 14:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly14Selected.SetActive(true);
                

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 15:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

             


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly15Selected.SetActive(true);
                
            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 16:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);
             

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly16Selected.SetActive(true);
                

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 17:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

               


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly17Selected.SetActive(true);
                

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 18:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly18Selected.SetActive(true);
                

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 19:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly19Selected.SetActive(true);
                

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 20:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly20Selected.SetActive(true);
                

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 21:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly21Selected.SetActive(true);
                

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 22:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly22Selected.SetActive(true);
                

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 23:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly23Selected.SetActive(true);
                

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 24:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly24Selected.SetActive(true);
                

            }
            break;
        }


        /*


              if (about)
              {
                if (time > 0)
                  {
                      time -= Time.deltaTime;
                    //  canvasMenu.rigidbody2D.transform.Translate(new Vector2(40, 0), Space.World);
               //   }
               //   else
                 // {
           
                 //}
           
          
              }*/
        /* if (canvasMenu.transform.position.x == 900)
          {
           
        
              about = false;
          }*/
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);
      
        if (Input.GetKeyDown("escape"))
        {
            if (!playerController.Dead)
            {
                if (!about&&!store&&!play&&!rate.activeInHierarchy)
                {

                    if (SoundIndex == 1)
                    {

                        Sound.GetComponent<AudioSource>().Play();

                    }
                    if (!quitvisible)
                    {
                        QuitMenu.SetActive(true);
                        popup = true;
                        // canvas.SetActive(false);
                        quitvisible = true;
                        if (MusicIndex == 1)
                        {

                            Music.GetComponent<AudioSource>().volume = 0.3f;

                        }

                    }
                    else if (quitvisible)
                    {
                        QuitMenu.SetActive(false);
                        popup = false;
                        // canvas.SetActive(true);
                        quitvisible = false;
                        if (MusicIndex == 1)
                        {


                            Music.GetComponent<AudioSource>().volume = 0.5f;
                        }

                    }
                }
                else if (play&& !popup)
                {
                    OtherGAme.SetActive(true);
                    OtherGAmeText.SetActive(true);
                    Title.SetActive(true);
                    if (SoundIndex == 1)
                    {

                        Sound.GetComponent<AudioSource>().Play();

                    }
                    play = false;
                    PlayerPrefs.SetInt("WorldShown", 0);
                    WorldCanvas.SetActive(false);
                    canvasMenu.SetActive(true);
                }
                else if (store && !popup)
                {
                    if (SoundIndex == 1)
                    {

                        Sound.GetComponent<AudioSource>().Play();

                    }
                    store = false;
                    StorePanel.SetActive(false);
                    canvasMenu.SetActive(true);
                }
                else if (about && !popup)
                {
                    if (SoundIndex == 1)
                    {

                        Sound.GetComponent<AudioSource>().Play();

                    }
                    about = false;
                    AboutPanel.SetActive(false);
                    canvasMenu.SetActive(true);
                }
            }
        }
    }

   
    public void Navigate(string buttonName)
    {
       
       // audio.PlayOneShot(clicSound, 0.1F);
        switch (buttonName)
        {

            case "RightLevel":
                if (!popup)
                {
                    {
                        play = true;
                        if (World1.activeInHierarchy)
                        {
                            World1.SetActive(false);
                            leftlevel.SetActive(true);
                           
                            if (PlayerPrefs.GetInt("World2Unlocked", 0) == 1)
                            {
                                World2Unlocked.SetActive(true);
                            }
                            if (PlayerPrefs.GetInt("World2Unlocked", 0) == 0)
                            {
                                World2Locked.SetActive(true);
                            }
                            PlayerPrefs.SetInt("WorldShown", 2);
                            W1Decor.SetActive(false);
                            W2Decor.SetActive(true);
                            W3Decor.SetActive(false);
                            W4Decor.SetActive(false);
                            rightlevel.SetActive(false);
                           
                        }
                        else if (World2Locked.activeInHierarchy)
                        {
                            World2Locked.SetActive(false);
                            PlayerPrefs.SetInt("WorldShown", 3);
                            World3Locked.SetActive(true);
                            W1Decor.SetActive(false);
                            W2Decor.SetActive(false);
                            W3Decor.SetActive(true);
                            W4Decor.SetActive(false);
                          
                        }
                        else if (World2Unlocked.activeInHierarchy)
                        {
                            PlayerPrefs.SetInt("WorldShown", 3);
                            W1Decor.SetActive(false);
                            W2Decor.SetActive(false);
                            W3Decor.SetActive(true);
                            W4Decor.SetActive(false);
                          
                            World2Unlocked.SetActive(false);
                            if (PlayerPrefs.GetInt("World3Unlocked", 0) == 1)
                            {
                                World3Unlocked.SetActive(true);
                            }
                            if (PlayerPrefs.GetInt("World3Unlocked", 0) == 0)
                            {
                                World3Locked.SetActive(true);
                            }
                        }
                        else if (World3Locked.activeInHierarchy)
                        {
                            PlayerPrefs.SetInt("WorldShown", 4);
                            W1Decor.SetActive(false);
                            W2Decor.SetActive(false);
                            W3Decor.SetActive(false);
                            W4Decor.SetActive(true);
                          
                            World3Locked.SetActive(false);

                            rightlevel.SetActive(false);
                            World4Locked.SetActive(true);
                        }
                        else if (World3Unlocked.activeInHierarchy)
                        {
                            PlayerPrefs.SetInt("WorldShown", 4);
                            W1Decor.SetActive(false);
                            W2Decor.SetActive(false);
                            W3Decor.SetActive(false);
                            W4Decor.SetActive(true);
                          
                            World3Locked.SetActive(false);
                            World3Unlocked.SetActive(false);
                            rightlevel.SetActive(false);
                            if (PlayerPrefs.GetInt("World4Unlocked", 0) == 1)
                            {
                                World4Unlocked.SetActive(true);
                            }
                            if (PlayerPrefs.GetInt("World4Unlocked", 0) == 0)
                            {
                                World4Locked.SetActive(true);
                            }
                        }
                    }
                }
                break;
            case "LeftLevel":
                if (!popup)
                {
                    play = true;
                    if (World2Locked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 1);
                        W1Decor.SetActive(true);
                        W2Decor.SetActive(false);
                        W3Decor.SetActive(false);
                        W4Decor.SetActive(false);
                     
                        World2Locked.SetActive(false);
                        leftlevel.SetActive(false);
                        rightlevel.SetActive(true);
                        World1.SetActive(true);
                    }
                    else if (World2Unlocked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 1);
                        W1Decor.SetActive(true);
                        W2Decor.SetActive(false);
                        W3Decor.SetActive(false);
                        W4Decor.SetActive(false);
                      
                        World2Unlocked.SetActive(false);
                        leftlevel.SetActive(false);
                        rightlevel.SetActive(true);
                        World1.SetActive(true);
                    }
                    else if (World3Locked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 2);
                        W1Decor.SetActive(false);
                        W2Decor.SetActive(true);
                        W3Decor.SetActive(false);
                        W4Decor.SetActive(false);
                     
                        World3Locked.SetActive(false);
                        if (PlayerPrefs.GetInt("World2Unlocked", 0) == 1)
                        {
                            World2Unlocked.SetActive(true);
                        }
                        if (PlayerPrefs.GetInt("World2Unlocked", 0) == 0)
                        {
                            World2Locked.SetActive(true);
                        }

                    }
                    else if (World3Unlocked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 2);
                        World3Unlocked.SetActive(false);
                        if (PlayerPrefs.GetInt("World2Unlocked", 0) == 1)
                        {
                            World2Unlocked.SetActive(true);
                        }
                        if (PlayerPrefs.GetInt("World2Unlocked", 0) == 0)
                        {
                            World2Locked.SetActive(true);
                        }
                        W1Decor.SetActive(false);
                        W2Decor.SetActive(true);
                        W3Decor.SetActive(false);
                        W4Decor.SetActive(false);
                       
                    }
                    else if (World4Locked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 3);
                        W1Decor.SetActive(false);
                        W2Decor.SetActive(false);
                        W3Decor.SetActive(true);
                        W4Decor.SetActive(false);
                     
                        World4Locked.SetActive(false);

                        rightlevel.SetActive(true);
                        if (PlayerPrefs.GetInt("World3Unlocked", 0) == 1)
                        {
                            World3Unlocked.SetActive(true);
                        }
                        if (PlayerPrefs.GetInt("World3Unlocked", 0) == 0)
                        {
                            World3Locked.SetActive(true);
                        }
                    }
                    else if (World4Unlocked.activeInHierarchy)
                    {
                        PlayerPrefs.SetInt("WorldShown", 3);
                        W1Decor.SetActive(false);
                        W2Decor.SetActive(false);
                        W3Decor.SetActive(true);
                        W4Decor.SetActive(false);
                      
                        World4Unlocked.SetActive(false);
                        if (PlayerPrefs.GetInt("World3Unlocked", 0) == 1)
                        {
                            World3Unlocked.SetActive(true);
                        }
                        if (PlayerPrefs.GetInt("World3Unlocked", 0) == 0)
                        {
                            World3Locked.SetActive(true);
                        }
                    }
                }
                break;


            case "UnlockW2":
                if (!popup)
                {
                    if (PlayerPrefs.GetInt("TotalStars", 0) >= 30)
                    {
                        PlayerPrefs.SetInt("World2Unlocked", 1);
                        World2Locked.SetActive(false);
                        World2Unlocked.SetActive(true);
                        if (SoundIndex == 1)
                        {

                            GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                        }
                    }

                    else
                    {
                        if (SoundIndex == 1)
                        {
                            GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                        }
                        popup = true;
                        unlockpanel.SetActive(true);
                        UnlockMessage.GetComponent<Image>().sprite = UnlockMessages[0];

                    }
                }
            break;
            case "UnlockW3":
            if (!popup)
            {
                if (PlayerPrefs.GetInt("TotalStars", 0) >= 75)
                {
                    PlayerPrefs.SetInt("World3Unlocked", 1);
                    World3Locked.SetActive(false);
                    World3Unlocked.SetActive(true);
                    if (SoundIndex == 1)
                    {

                        GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                    }
                }

                else
                {
                    popup = true;
                    unlockpanel.SetActive(true);
                    UnlockMessage.GetComponent<Image>().sprite = UnlockMessages[1];
                }
            }
            break;
            case "UnlockW4":
            if (!popup)
            {
                if (PlayerPrefs.GetInt("TotalStars", 0) >= 120)
                {
                    PlayerPrefs.SetInt("World4Unlocked", 1);
                    World4Locked.SetActive(false);
                    World4Unlocked.SetActive(true);
                    if (SoundIndex == 1)
                    {

                        GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                    }

                }

                else
                {
                    popup = true;
                    unlockpanel.SetActive(true);
                    UnlockMessage.GetComponent<Image>().sprite = UnlockMessages[2];
                }
            }
            break;
            case "Ok":

            popup = false;
            unlockpanel.SetActive(false);

            break;
            
            case "FB":
            if (!popup)
            {

                // WWW www = new WWW("fb://page/DroidBoy-Games");
                //StartCoroutine(WaitForRequest(www));
                Application.OpenURL("fb://page/502024229946633");

            }
            break;
            case "TW":
            if (!popup)
            {
                Application.OpenURL("twitter://user?user_id=3381721191");
            }
                break;
            case "LoadLevel1":
                if (!popup)
                {
                    PlayerPrefs.SetInt("SelectedLevel", 1);
                    AutoFade.LoadLevel("Level1", 0.5f, 1, Color.black);
                }
            

            break;
            case "LoadLevel2":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 2);
                AutoFade.LoadLevel("Level2", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel3":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 3);
                AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel4":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 4);
                AutoFade.LoadLevel("Level4", 0.5f, 1, Color.black);

            }


            break;
            case "LoadLevel5":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 5);
                AutoFade.LoadLevel("Level5", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel6":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 6);
                AutoFade.LoadLevel("Level6", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel7":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 7);
                AutoFade.LoadLevel("Level7", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel8":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 8);
                AutoFade.LoadLevel("Level8", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel9":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 9);
                AutoFade.LoadLevel("Level9", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel10":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 10);
                AutoFade.LoadLevel("Level10", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel11":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 11);
                AutoFade.LoadLevel("Level11", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel12":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 12);
                AutoFade.LoadLevel("Level12", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel13":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 13);
                AutoFade.LoadLevel("Level13", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel14":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 14);
                AutoFade.LoadLevel("Level14", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel15":


            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 15);
                AutoFade.LoadLevel("Level15", 0.5f, 1, Color.black);
            }
            break;
            case "LoadLevel16":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 16);
                AutoFade.LoadLevel("Level16", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel17":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 17);
                AutoFade.LoadLevel("Level17", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel18":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 18);
                AutoFade.LoadLevel("Level18", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel19":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 19);
                AutoFade.LoadLevel("Level19", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel20":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 20);
                AutoFade.LoadLevel("Level20", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel21":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 21);
                AutoFade.LoadLevel("Level21", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel22":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 22);
                AutoFade.LoadLevel("Level22", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel23":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 23);
                AutoFade.LoadLevel("Level23", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel24":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 24);
                AutoFade.LoadLevel("Level24", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel25":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 25);
                AutoFade.LoadLevel("Level25", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel26":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 26);
                AutoFade.LoadLevel("Level26", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel27":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 27);
                AutoFade.LoadLevel("Level27", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel28":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 28);
                AutoFade.LoadLevel("Level28", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel29":
            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 29);
                AutoFade.LoadLevel("Level29", 0.5f, 1, Color.black);
            }


            break;
            case "LoadLevel30":

            if (!popup)
            {
                PlayerPrefs.SetInt("SelectedLevel", 30);
                AutoFade.LoadLevel("Level30", 0.5f, 1, Color.black);
            }

            break;
            case "LoadLevel31":

            if (!popup)
            {
            }

            break;
            case "LoadLevel32":
            if (!popup)
            {
            }


            break;
            case "LoadLevel33":
            if (!popup)
            {
            }


            break;
            case "LoadLevel34":

            if (!popup)
            {
            }

            break;
            case "LoadLevel35":
            if (!popup)
            {
            }


            break;
            case "LoadLevel36":

            if (!popup)
            {
            }

            break;
            case "LoadLevel37":
            if (!popup)
            {
            }


            break;
            case "LoadLevel38":
            if (!popup)
            {
            }


            break;
            case "LoadLevel39":

            if (!popup)
            {
            }

            break;
            case "LoadLevel40":

            if (!popup)
            {
            }

            break;
            case "LoadLevel41":

            if (!popup)
            {
            }

            break;
            case "LoadLevel42":

            if (!popup)
            {
            }

            break;
            case "LoadLevel43":
            if (!popup)
            {
            }


            break;
            case "LoadLevel44":
            if (!popup)
            {
            }


            break;
            case "LoadLevel45":
            if (!popup)
            {
            }


            break;
            case "LoadLevel46":

            if (!popup)
            {
            }

            break;
            case "LoadLevel47":

            if (!popup)
            {
            }

            break;
            case "LoadLevel48":

            if (!popup)
            {
            }

            break;
            case "LoadLevel49":

            if (!popup)
            {
            }

            break;
            case "LoadLevel50":
            if (!popup)
            {
            }


            break;
            case "LoadLevel51":
            if (!popup)
            {
            }


            break;
            case "LoadLevel52":
            if (!popup)
            {
            }


            break;
            case "LoadLevel53":
            if (!popup)
            {
            }


            break;
            case "LoadLevel54":
            if (!popup)
            {
            }


            break;
            case "LoadLevel55":
            if (!popup)
            {
            }


            break;
            case "LoadLevel56":
            if (!popup)
            {
            }


            break;
            case "LoadLevel57":
            if (!popup)
            {
            }


            break;
            case "LoadLevel58":
            if (!popup)
            {
            }


            break;
            case "LoadLevel59":

            if (!popup)
            {
            }

            break;
            case "LoadLevel60":
            if (!popup)
            {
            }


            break;

            case "NotNow":
            rate.SetActive(false);
                 PlayerPrefs.SetInt("NumberOfOpen", 0);
                 popup = false;
            break;
            case "Rateus":
            Application.OpenURL("market://details?id=droidboy.lolyworld.world");
            PlayerPrefs.SetInt("rated", 1);
            PlayerPrefs.SetInt("NumberOfOpen", 0);
            rate.SetActive(false);
            popup = false;
            break;
            case "OtherGame":
            if (!popup)
            {

                //playClicked = true;
                //              Invoke("loadgame", 0.3f);
                Application.OpenURL("market://details?id=droidboy.lolyjump.loly");

            }
            break;
            case "Play":
            if (!popup)
            {

                //playClicked = true;
                //              Invoke("loadgame", 0.3f);
                play = true;
                WorldCanvas.SetActive(true);
                canvasMenu.SetActive(false);
                // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                Title.SetActive(false);
                fromlevel = false;
                 OtherGAme.SetActive(false);
                 OtherGAmeText.SetActive(false); ;
                 if (PlayerPrefs.GetInt("WorldShown", 1) == 1&&!fromlevel)
                 {
                     W1Decor.SetActive(true);
                     W2Decor.SetActive(false);
                     W3Decor.SetActive(false);
                     W4Decor.SetActive(false);
                     rightlevel.SetActive(true);

                     World1.SetActive(true);
                 
                     canvasMenu.SetActive(false);
                     fromlevel = false;
                     // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                     Title.SetActive(false);
                     play = true;
                  

                 }

                 if (PlayerPrefs.GetInt("WorldShown", 1) == 2 && !fromlevel)
                 {
                    
                     W1Decor.SetActive(false);
                     W2Decor.SetActive(true);
                     W3Decor.SetActive(false);
                     W4Decor.SetActive(false);
                     rightlevel.SetActive(false);
                     World1.SetActive(false);
                     if (PlayerPrefs.GetInt("World2Unlocked", 0) == 1)
                     {
                         World2Unlocked.SetActive(true);
                     }
                     else
                     {
                         World2Locked.SetActive(true);
                     }
                  
                     canvasMenu.SetActive(false);
                     // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                     Title.SetActive(false);
                     fromlevel = false;
                     play = true;
                 }
              /* 
                 if (PlayerPrefs.GetInt("WorldShown", 1) == 3 )
                 {
                     WorldCanvas.SetActive(true);
                     W1Decor.SetActive(false);
                     W2Decor.SetActive(false);
                     W3Decor.SetActive(true);
                     W4Decor.SetActive(false);
                     World1.SetActive(false);
                     World2Unlocked.SetActive(false);
                     play = true;
                     World3Unlocked.SetActive(true);

                     canvasMenu.SetActive(false);
                     // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                     Title.SetActive(false);
                     fromlevel = false;
                 }
               
                 if (PlayerPrefs.GetInt("WorldShown", 1) == 4 )
                 {
                     WorldCanvas.SetActive(true);
                     W1Decor.SetActive(false);
                     W2Decor.SetActive(false);
                     W3Decor.SetActive(false);
                     W4Decor.SetActive(true);

                     play = true;
                     World4Unlocked.SetActive(true);

                     canvasMenu.SetActive(false);
                     // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
                     Title.SetActive(false);
                     fromlevel = false;

                 }
                 */
              
            }
               
            break;
            case "Yes":
          

                Application.Quit();
                QuitMenu.SetActive(false);
                if (MusicIndex == 1)
                {

                    GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.5f;
                }
                popup = false;
            
            break;
            case "No":

            QuitMenu.SetActive(false);
                  
                   // canvas.SetActive(true);
                    quitvisible = false;
                    if (MusicIndex == 1)
                    {

                        GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.5f;
                    }
                    popup = false;


            break;
            case "Sound":
            if (!popup)
            {
            
            if (sound) {
               // SoundButton.GetComponent<SpriteRenderer>().sprite = Resources.Load("soundoff", typeof(Sprite)) as Sprite;
                 SoundButton.GetComponent<Button>().image.sprite=SoundOffSprite;
                GetComponent<AudioSource>().enabled=false;
                sound = false;
                PlayerPrefs.SetInt("Sound", 0);

            }
            else
            {
                SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
                GetComponent<AudioSource>().enabled = true;
                sound = true;
                PlayerPrefs.SetInt("Sound", 1);

            }

                
    }
            break;
            case "Music":
      if (!popup)
                {
                
            if (PlayerPrefs.GetInt("Music", 1)==1)
            {
             
                Music.GetComponent<AudioSource>().volume = 0;
               
                MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;
    
                music = false;
                PlayerPrefs.SetInt("Music", 0);
            }
            else
            {
                Music.GetComponent<AudioSource>().enabled = true;
                Music.GetComponent<AudioSource>().volume = 0.5f;
             
                MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
                music = true;

                PlayerPrefs.SetInt("Music", 1);

            }

      }
            break;

           

            case "Store":
            if (!popup)
            {

                store = true;
                canvasMenu.SetActive(false);
                StorePanel.SetActive(true);
                Pack1.SetActive(true);
                // Title.SetActive(false);

                LeftButtonStore.SetActive(false);
            }
            break;

            case "Achiev":
            if (!popup)
            {

                Social.localUser.Authenticate((bool success) =>
                {
                    // handle success or failure
                });
                Social.ShowAchievementsUI();
            }
            break;

            case "Leader":
            if (!popup)
            {

                Social.localUser.Authenticate((bool success) =>
                {
                    // handle success or failure
                });
                Social.ShowLeaderboardUI();
            }
            break;
            case "About":
            if (!popup)
            {

                about = true;
                //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
                canvasMenu.SetActive(false);
                AboutPanel.SetActive(true);
                RightButton.SetActive(true);
                Message0.SetActive(true);
                Message1.SetActive(false);
                Message2.SetActive(false);
                Message3.SetActive(false);
                Message4.SetActive(false);
                LeftButton.SetActive(false);
                MainButton.SetActive(true);

            }
            break;
            case "Left":
            if (!popup)
            {

                if (Message1.activeInHierarchy)
                {


                    LeftButton.SetActive(false);
                    Message1.SetActive(false);
                    Message0.SetActive(true);
                }
                else if (Message2.activeInHierarchy)
                {


                    Message2.SetActive(false);
                    Message1.SetActive(true);
                }
                else if (Message3.activeInHierarchy)
                {



                    Message3.SetActive(false);
                    Message2.SetActive(true);
                }
                else if (Message4.activeInHierarchy)
                {


                    RightButton.SetActive(true);
                    Message4.SetActive(false);
                    Message3.SetActive(true);
                }

              
            }
            break;
            case "Right":
            if (!popup)
            {
                if (Message0.activeInHierarchy)
                {


                    LeftButton.SetActive(true);
                    Message0.SetActive(false);
                    Message1.SetActive(true);
                }
                else if (Message1.activeInHierarchy)
                {


                  
                    Message1.SetActive(false);
                    Message2.SetActive(true);
                }
                else if (Message2.activeInHierarchy)
                {


                   
                    Message2.SetActive(false);
                    Message3.SetActive(true);
                }
                else if (Message3.activeInHierarchy)
                {


                    RightButton.SetActive(false);
                    Message3.SetActive(false);
                    Message4.SetActive(true);
                }

            }

            break;

            case "Main":
            if (!popup)
            {

                AboutPanel.SetActive(false);
                canvasMenu.SetActive(true);
                WorldCanvas.SetActive(false);
                MainButton.SetActive(false);
                Title.SetActive(true);
                play = false;
                RightButton.SetActive(true);
                LeftButton.SetActive(false);
              
                Message1.SetActive(true);
              
                Message2.SetActive(false);
                Message3.SetActive(false);
                Message4.SetActive(false);

                about = false;
                OtherGAme.SetActive(true);
                OtherGAmeText.SetActive(true);
            }
                break;
            
            case "Rate":
            if (!popup)
            {
            
          //  Application.OpenURL("http://play.google.com/store/apps/details?id=droidboy.lolyjump.loly");
                Application.OpenURL("market://details?id=droidboy.lolyworld.world");
            }
            break;
            case "LeftStore":
            if (!popup)
            {

                if (pos2 == 3)
                {
                    RightButtonStore.SetActive(true);
                    Pack3.SetActive(false);
                    Pack2.SetActive(true);
                    pos2 = 2;
                }
                else if (pos2 == 2)
                {
                    LeftButtonStore.SetActive(false);
                    Pack2.SetActive(false);
                    Pack1.SetActive(true);
                    pos2 = 1;
                }
            }
                      break;
            
            case "RightStore":
                  if (!popup)
                {
                
              if (pos2==1){
            LeftButtonStore.SetActive(true);
            Pack1.SetActive(false);
            Pack2.SetActive(true);
                   pos2=2;
               }
              else if (pos2==2){
            RightButtonStore.SetActive(false);
            Pack2.SetActive(false);
            Pack3.SetActive(true);
                   pos2=3;
               }
                  }
            break;
            case "MainStore":
                  if (!popup)
                {
                
            canvasMenu.SetActive(true);
            StorePanel.SetActive(false);
            Pack1.SetActive(false);
            Title.SetActive(true);
            store = false;
            Pack3.SetActive(false);
            Pack2.SetActive(false);
            LeftButtonStore.SetActive(false);
            RightButtonStore.SetActive(true);
                pos2=1;
                  }
            break;

            case "Loly1Select":

            PlayerPrefs.SetInt("SkinSelected",1);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }


            break;
            case "Loly2Unlock":
            if (Total_nb_candy >= 5)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
               
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly2lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy-5);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }

            break;
            case "Loly2Select":

            PlayerPrefs.SetInt("SkinSelected", 2);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly3Unlock":
            if (Total_nb_candy >= 10)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly3lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 10);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly3Select":
            PlayerPrefs.SetInt("SkinSelected", 3);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly4Unlock":
            if (Total_nb_candy >= 15)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly4lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 15);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly4Select":

            PlayerPrefs.SetInt("SkinSelected", 4);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }
            break;
            case "Loly5Unlock":
            if (Total_nb_candy >= 20)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly5lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 20);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }

            break;
            case "Loly5Select":
            PlayerPrefs.SetInt("SkinSelected",5);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly6Unlock":
            if (Total_nb_candy >= 25)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly6lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 25);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly6Select":
            PlayerPrefs.SetInt("SkinSelected",6);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly7Unlock":
            if (Total_nb_candy >= 30)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly7lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 30);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly7Select":
            PlayerPrefs.SetInt("SkinSelected", 7);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly8Unlock":
            if (Total_nb_candy >= 35)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly8lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 35);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly8Select":
            PlayerPrefs.SetInt("SkinSelected", 8);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly9Unlock":
            if (Total_nb_candy >= 50)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly9lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 50);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly9Select":
            PlayerPrefs.SetInt("SkinSelected", 9);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly10Unlock":
            if (Total_nb_candy >= 50)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly10lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 50);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly10Select":
            PlayerPrefs.SetInt("SkinSelected", 10);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly11Unlock":
            if (Total_nb_candy >= 100)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly11lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 100);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly11Select":
            PlayerPrefs.SetInt("SkinSelected", 11);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly12Unlock":
            if (Total_nb_candy >= 100)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly12lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 100);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly12Select":
            PlayerPrefs.SetInt("SkinSelected", 12);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly13Unlock":
            if (Total_nb_candy >= 150)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly13lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 150);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly13Select":
            PlayerPrefs.SetInt("SkinSelected", 13);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly14Unlock":
            if (Total_nb_candy >= 150)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly14lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 150);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly14Select":
            PlayerPrefs.SetInt("SkinSelected", 14);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly15Unlock":
            if (Total_nb_candy >= 200)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly15lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 200);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly15Select":
            PlayerPrefs.SetInt("SkinSelected", 15);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly16Unlock":
            if (Total_nb_candy >= 300)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly16lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 300);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly16Select":
            PlayerPrefs.SetInt("SkinSelected", 16);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly17Unlock":
            if (Total_nb_candy >= 350)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly17lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 350);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly17Select":
            PlayerPrefs.SetInt("SkinSelected", 17);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly18Unlock":
            if (Total_nb_candy >= 400)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly18lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 400);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly18Select":
            PlayerPrefs.SetInt("SkinSelected", 18);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly19Unlock":
            if (Total_nb_candy >= 500)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly19lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 450);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly19Select":
            PlayerPrefs.SetInt("SkinSelected", 19);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly20Unlock":
            if (Total_nb_candy >= 600)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly20lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 500);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly20Select":
            PlayerPrefs.SetInt("SkinSelected", 20);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly21Unlock":
            if (Total_nb_candy >= 700)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly21lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 600);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly21Select":
            PlayerPrefs.SetInt("SkinSelected", 21);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly22Unlock":
            if (Total_nb_candy >= 800)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly22lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 800);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly22Select":
            PlayerPrefs.SetInt("SkinSelected", 22);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly23Unlock":
            if (Total_nb_candy >= 900)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly23lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 900);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly23Select":
            PlayerPrefs.SetInt("SkinSelected", 23);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly24Unlock":
            if (Total_nb_candy >= 1000)
            {
                PlayerPrefs.SetInt("UnlockedSkins",   PlayerPrefs.GetInt("UnlockedSkins", 0)+1);

                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly24lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 1000);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly24Select":
            PlayerPrefs.SetInt("SkinSelected", 24);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
        }

    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("MainMenuFade", 0);
    }

    void StopShake()
    {
       (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = false;


    }
    public void loadgame()
    {
  //    GameObject.Find("GM").GetComponent<FadeScript>().BeginFade(1);

       
        PlayerPrefs.SetInt("MainMenuFade", 0);
        Application.LoadLevel("sceneGame");
    }
    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("Sucess!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error + " Opening Safari...");
            //error. Open normal address
            Application.OpenURL("https://www.facebook.com/pages/DroidBoy-Games/502024229946633?fref=ts");

        }
    }
    void Awake()
    {
        gameObject.GetComponent<Canvas>().sortingLayerName = "myLayer1";

        // fromlevel = false;

        pos2 = 1;
        quitvisible = false;
        about = false;
        store = false;
        playClicked = false;
        play = false;
        popup = false;

        if (fromlevel)
        {
            OtherGAme.SetActive(false);
            OtherGAmeText.SetActive(false);
        }
        else
        {

            OtherGAme.SetActive(true);
            OtherGAmeText.SetActive(true);
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 1 && fromlevel)
        {
            W1Decor.SetActive(true);
            W2Decor.SetActive(false);
            W3Decor.SetActive(false);
            W4Decor.SetActive(false);
            rightlevel.SetActive(true);
          
            World1.SetActive(true);
            WorldCanvas.SetActive(true);
            canvasMenu.SetActive(false);
            // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
            Title.SetActive(false);
            play = true; 
            popup = false;

        }
        else if (PlayerPrefs.GetInt("WorldShown", 1) == 1 && !fromlevel)
        {
            Title.SetActive(true);
            rightlevel.SetActive(true);
            W1Decor.SetActive(true);
            W2Decor.SetActive(false);
            W3Decor.SetActive(false);
            W4Decor.SetActive(false);
          
            play = true;
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 2 && fromlevel)
        {
            WorldCanvas.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(true);
            W3Decor.SetActive(false);
            W4Decor.SetActive(false);
            rightlevel.SetActive(false);
            World1.SetActive(false);
            World2Unlocked.SetActive(true);

            canvasMenu.SetActive(false);
            // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
            Title.SetActive(false);
            fromlevel = false;
            play = true;
        }
        else if (PlayerPrefs.GetInt("WorldShown", 1) == 2 && !fromlevel)
        {
            rightlevel.SetActive(false);
            Title.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(true);
            W3Decor.SetActive(false);
            W4Decor.SetActive(false);
           
            play = true;
        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 3 && fromlevel)
        {
            WorldCanvas.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(false);
            W3Decor.SetActive(true);
            W4Decor.SetActive(false);
            World1.SetActive(false);
            World2Unlocked.SetActive(false);
            play = true;
            World3Unlocked.SetActive(true);

            canvasMenu.SetActive(false);
            // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
            Title.SetActive(false);
            fromlevel = false;
        }
        else if (PlayerPrefs.GetInt("WorldShown", 1) == 3 && !fromlevel)
        {
            Title.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(false);
            W3Decor.SetActive(true);
            W4Decor.SetActive(false);
           
            play = true;

        }
        if (PlayerPrefs.GetInt("WorldShown", 1) == 4 && fromlevel)
        {
            WorldCanvas.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(false);
            W3Decor.SetActive(false);
            W4Decor.SetActive(true);
           
            play = true;
            World4Unlocked.SetActive(true);

            canvasMenu.SetActive(false);
            // AutoFade.LoadLevel("Level3", 0.5f, 1, Color.black);
            Title.SetActive(false);
            fromlevel = false;

        }
        else if (PlayerPrefs.GetInt("WorldShown", 1) == 4 && !fromlevel)
        {
            Title.SetActive(true);
            W1Decor.SetActive(false);
            W2Decor.SetActive(false);
            W3Decor.SetActive(false);
            W4Decor.SetActive(true);
           
            play = true;

        }
     

      
            if (PlayerPrefs.GetInt("NumberOfOpen", 0) < 6 && PlayerPrefs.GetInt("rated", 0) == 0)
            {
                PlayerPrefs.SetInt("NumberOfOpen", PlayerPrefs.GetInt("NumberOfOpen", 0) + 1);
            }
            else if (PlayerPrefs.GetInt("NumberOfOpen", 0) == 6)
            {



                rate.SetActive(true);

            }

            switch (PlayerPrefs.GetInt("TotalStars", 0))
            {
                case 0:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[0];
                    break;
                case 1:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[1];
                    break;
                case 2:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[2];
                    break;
                case 3:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[3];
                    break;
                case 4:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[4];
                    break;
                case 5:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[5];
                    break;
                case 6:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[6];
                    break;
                case 7:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[7];
                    break;
                case 8:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[8];
                    break;
                case 9:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[9];
                    break;
                case 10:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[10];
                    break;
                case 11:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[11];
                    break;
                case 12:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[12];
                    break;
                case 13:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[13];
                    break;
                case 14:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[14];
                    break;
                case 15:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[15];
                    break;
                case 16:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[16];
                    break;
                case 17:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[17];
                    break;
                case 18:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[18];
                    break;
                case 19:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[19];
                    break;
                case 20:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[20];
                    break;
                case 21:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[21];
                    break;
                case 22:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[22];
                    break;
                case 23:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[23];
                    break;
                case 24:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[24];
                    break;
                case 25:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[25];
                    break;
                case 26:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[26];
                    break;
                case 27:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[27];
                    break;
                case 28:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[28];
                    break;
                case 29:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[29];
                    break;
                case 30:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[30];
                    break;
                case 31:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[31];
                    break;
                case 32:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[32];
                    break;
                case 33:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[33];
                    break;
                case 34:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[34];
                    break;
                case 35:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[35];
                    break;
                case 36:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[36];
                    break;
                case 37:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[37];
                    break;
                case 38:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[38];
                    break;
                case 39:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[39];
                    break;
                case 40:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[40];
                    break;
                case 41:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[41];
                    break;
                case 42:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[42];
                    break;
                case 43:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[43];
                    break;
                case 44:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[44];
                    break;
                case 45:
                    World2starsnumber.GetComponent<Image>().sprite = World2Stars[45];
                    break;

            }
        //PlayerPrefs.SetInt("StarsLevel1", 0);
        //PlayerPrefs.SetInt("StarsLevel2", 0);
         //PlayerPrefs.SetInt("TotalStars", 30);
        Debug.Log("total stars"+PlayerPrefs.GetInt("TotalStars", 0));
        if (PlayerPrefs.GetInt("TotalStars", 0) == 15)
        {
            Social.ReportProgress("CgkIrOSpp-oUEAIQBg", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (PlayerPrefs.GetInt("TotalStars", 0) == 60)
        {
            Social.ReportProgress("CgkIrOSpp-oUEAIQBw", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }

      //  PlayerPrefs.SetInt("NumberOfDeath", 0); 
    //  PlayerPrefs.SetInt("World2Unlocked", 0);
     // PlayerPrefs.SetInt("World3Unlocked", 0);
     // PlayerPrefs.SetInt("World4Unlocked", 0);

       // PlayerPrefs.SetInt("Level1Done", 0);
        //PlayerPrefs.SetInt("Level2Done", 0);
        /*
         PlayerPrefs.SetInt("Level3Done", 0);
         PlayerPrefs.SetInt("Level4Done", 0);
         PlayerPrefs.SetInt("Level5Done", 0);
         PlayerPrefs.SetInt("Level6Done", 0);
         PlayerPrefs.SetInt("Level7Done", 0);
         PlayerPrefs.SetInt("Level8Done", 0);
         PlayerPrefs.SetInt("Level9Done", 0);
         PlayerPrefs.SetInt("Level10Done", 0);
         PlayerPrefs.SetInt("Level11Done", 0);
         PlayerPrefs.SetInt("Level12Done", 0);
         PlayerPrefs.SetInt("Level13Done", 0);
         PlayerPrefs.SetInt("Level14Done", 0);
         PlayerPrefs.SetInt("Level15Done", 0);
         PlayerPrefs.SetInt("Level16Done", 0);
         PlayerPrefs.SetInt("Level17Done", 0);
         PlayerPrefs.SetInt("Level18Done", 0);
         PlayerPrefs.SetInt("Level19Done", 0);
         PlayerPrefs.SetInt("Level20Done", 0);
         PlayerPrefs.SetInt("Level21Done", 0);
         PlayerPrefs.SetInt("Level22Done", 0);
         PlayerPrefs.SetInt("Level23Done", 0);
         PlayerPrefs.SetInt("Level24Done", 0);
         PlayerPrefs.SetInt("Level25Done", 0);
         PlayerPrefs.SetInt("Level26Done", 0);
         PlayerPrefs.SetInt("Level27Done", 0);
         PlayerPrefs.SetInt("Level28Done", 0);
         PlayerPrefs.SetInt("Level29Done", 0);
         PlayerPrefs.SetInt("Level30Done", 0);
         PlayerPrefs.SetInt("Level31Done", 0);
         PlayerPrefs.SetInt("Level32Done", 0);
         PlayerPrefs.SetInt("Level33Done", 0);
         PlayerPrefs.SetInt("Level34Done", 0);
         PlayerPrefs.SetInt("Level35Done", 0);
         PlayerPrefs.SetInt("Level36Done", 0);
         PlayerPrefs.SetInt("Level37Done", 0);
         PlayerPrefs.SetInt("Level38Done", 0);
         PlayerPrefs.SetInt("Level39Done", 0);
         PlayerPrefs.SetInt("Level40Done", 0);
         PlayerPrefs.SetInt("Level41Done", 0);
         PlayerPrefs.SetInt("Level42Done", 0);
         PlayerPrefs.SetInt("Level43Done", 0);
         PlayerPrefs.SetInt("Level44Done", 0);
         PlayerPrefs.SetInt("Level45Done", 0);
         PlayerPrefs.SetInt("Level46Done", 0);
         PlayerPrefs.SetInt("Level47Done", 0);
         PlayerPrefs.SetInt("Level48Done", 0);
         PlayerPrefs.SetInt("Level49Done", 0);
         PlayerPrefs.SetInt("Level50Done", 0);
         PlayerPrefs.SetInt("Level51Done", 0);
         PlayerPrefs.SetInt("Level52Done", 0);
         PlayerPrefs.SetInt("Level53Done", 0);
         PlayerPrefs.SetInt("Level54Done", 0);
         PlayerPrefs.SetInt("Level55Done", 0);
         PlayerPrefs.SetInt("Level56Done", 0);
         PlayerPrefs.SetInt("Level57Done", 0);
         PlayerPrefs.SetInt("Level58Done", 0);
         PlayerPrefs.SetInt("Level59Done", 0);
         PlayerPrefs.SetInt("Level60Done", 0);

         */

       
        if (PlayerPrefs.GetInt("Level1Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel1", 0) == 1)
            {
                Level1Done.GetComponent<Image>().sprite=level1Stars[0];

            }
            if(PlayerPrefs.GetInt("StarsLevel1", 0)==2){
                Level1Done.GetComponent<Image>().sprite=level1Stars[1];

            }
                
            if(PlayerPrefs.GetInt("StarsLevel1", 0)==3){
                Level1Done.GetComponent<Image>().sprite=level1Stars[2];

            }
            Level1Done.SetActive(true);
            Level1Undone.SetActive(false);
            Level2Locked.SetActive(false);
            Level2Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level2Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel2", 0) == 1)
            {
                Level2Done.GetComponent<Image>().sprite = level2Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel2", 0) == 2)
            {
                Level2Done.GetComponent<Image>().sprite = level2Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel2", 0) == 3)
            {
                Level2Done.GetComponent<Image>().sprite = level2Stars[2];

            }
            Level2Done.SetActive(true);
            Level2Undone.SetActive(false);
            Level3Locked.SetActive(false);
            Level3Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level3Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel3", 0) == 1)
            {
                Level3Done.GetComponent<Image>().sprite = level3Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel3", 0) == 2)
            {
                Level3Done.GetComponent<Image>().sprite = level3Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel3", 0) == 3)
            {
                Level3Done.GetComponent<Image>().sprite = level3Stars[2];

            }
            Level3Done.SetActive(true);
            Level3Undone.SetActive(false);
            Level4Locked.SetActive(false);
            Level4Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level4Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel4", 0) == 1)
            {
                Level4Done.GetComponent<Image>().sprite = level4Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel4", 0) == 2)
            {
                Level4Done.GetComponent<Image>().sprite = level4Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel4", 0) == 3)
            {
                Level4Done.GetComponent<Image>().sprite = level4Stars[2];

            }
            Level4Done.SetActive(true);
            Level4Undone.SetActive(false);
            Level5Locked.SetActive(false);
            Level5Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level5Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel5", 0) == 1)
            {
                Level5Done.GetComponent<Image>().sprite = level5Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel5", 0) == 2)
            {
                Level5Done.GetComponent<Image>().sprite = level5Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel5", 0) == 3)
            {
                Level5Done.GetComponent<Image>().sprite = level5Stars[2];

            }
            Level5Done.SetActive(true);
            Level5Undone.SetActive(false);
            Level6Locked.SetActive(false);
            Level6Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level6Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel6", 0) == 1)
            {
                Level6Done.GetComponent<Image>().sprite = level6Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel6", 0) == 2)
            {
                Level6Done.GetComponent<Image>().sprite = level6Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel6", 0) == 3)
            {
                Level6Done.GetComponent<Image>().sprite = level6Stars[2];

            }
            Level6Done.SetActive(true);
            Level6Undone.SetActive(false);
            Level7Locked.SetActive(false);
            Level7Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level7Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel7", 0) == 1)
            {
                Level7Done.GetComponent<Image>().sprite = level7Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel7", 0) == 2)
            {
                Level7Done.GetComponent<Image>().sprite = level7Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel7", 0) == 3)
            {
                Level7Done.GetComponent<Image>().sprite = level7Stars[2];

            }
            Level7Done.SetActive(true);
            Level7Undone.SetActive(false);
            Level8Locked.SetActive(false);
            Level8Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level8Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel8", 0) == 1)
            {
                Level8Done.GetComponent<Image>().sprite = level8Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel8", 0) == 2)
            {
                Level8Done.GetComponent<Image>().sprite = level8Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel8", 0) == 3)
            {
                Level8Done.GetComponent<Image>().sprite = level8Stars[2];

            }
            Level8Done.SetActive(true);
            Level8Undone.SetActive(false);
            Level9Locked.SetActive(false);
            Level9Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level9Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel9", 0) == 1)
            {
                Level9Done.GetComponent<Image>().sprite = level9Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel9", 0) == 2)
            {
                Level9Done.GetComponent<Image>().sprite = level9Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel9", 0) == 3)
            {
                Level9Done.GetComponent<Image>().sprite = level9Stars[2];

            }
            Level9Done.SetActive(true);
            Level9Undone.SetActive(false);
            Level10Locked.SetActive(false);
            Level10Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level10Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel10", 0) == 1)
            {
                Level10Done.GetComponent<Image>().sprite = level10Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel10", 0) == 2)
            {
                Level10Done.GetComponent<Image>().sprite = level10Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel10", 0) == 3)
            {
                Level10Done.GetComponent<Image>().sprite = level10Stars[2];

            }
            Level10Done.SetActive(true);
            Level10Undone.SetActive(false);
            Level11Locked.SetActive(false);
            Level11Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level11Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel11", 0) == 1)
            {
                Level11Done.GetComponent<Image>().sprite = level11Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel11", 0) == 2)
            {
                Level11Done.GetComponent<Image>().sprite = level11Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel11", 0) == 3)
            {
                Level11Done.GetComponent<Image>().sprite = level11Stars[2];

            }
            Level11Done.SetActive(true);
            Level11Undone.SetActive(false);
            Level12Locked.SetActive(false);
            Level12Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level12Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel12", 0) == 1)
            {
                Level12Done.GetComponent<Image>().sprite = level12Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel12", 0) == 2)
            {
                Level12Done.GetComponent<Image>().sprite = level12Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel12", 0) == 3)
            {
                Level12Done.GetComponent<Image>().sprite = level12Stars[2];

            }
            Level12Done.SetActive(true);
            Level12Undone.SetActive(false);
            Level13Locked.SetActive(false);
            Level13Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level13Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel13", 0) == 1)
            {
                Level13Done.GetComponent<Image>().sprite = level13Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel13", 0) == 2)
            {
                Level13Done.GetComponent<Image>().sprite = level13Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel13", 0) == 3)
            {
                Level13Done.GetComponent<Image>().sprite = level13Stars[2];

            }
            Level13Done.SetActive(true);
            Level13Undone.SetActive(false);
            Level14Locked.SetActive(false);
            Level14Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level14Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel14", 0) == 1)
            {
                Level14Done.GetComponent<Image>().sprite = level14Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel14", 0) == 2)
            {
                Level14Done.GetComponent<Image>().sprite = level14Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel14", 0) == 3)
            {
                Level14Done.GetComponent<Image>().sprite = level14Stars[2];

            }
            Level14Done.SetActive(true);
            Level14Undone.SetActive(false);
            Level15Locked.SetActive(false);
            Level15Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level15Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel15", 0) == 1)
            {
                Level15Done.GetComponent<Image>().sprite = level15Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel15", 0) == 2)
            {
                Level15Done.GetComponent<Image>().sprite = level15Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel15", 0) == 3)
            {
                Level15Done.GetComponent<Image>().sprite = level15Stars[2];

            }
            Level15Done.SetActive(true);
            Level15Undone.SetActive(false);
          

        }
        if (PlayerPrefs.GetInt("Level16Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel16", 0) == 1)
            {
                Level16Done.GetComponent<Image>().sprite = level16Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel16", 0) == 2)
            {
                Level16Done.GetComponent<Image>().sprite = level16Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel16", 0) == 3)
            {
                Level16Done.GetComponent<Image>().sprite = level16Stars[2];

            }
            Level16Done.SetActive(true);
            Level16Undone.SetActive(false);
            Level17Locked.SetActive(false);
            Level17Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level17Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel17", 0) == 1)
            {
                Level17Done.GetComponent<Image>().sprite = level17Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel17", 0) == 2)
            {
                Level17Done.GetComponent<Image>().sprite = level17Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel17", 0) == 3)
            {
                Level17Done.GetComponent<Image>().sprite = level17Stars[2];

            }
            Level17Done.SetActive(true);
            Level17Undone.SetActive(false);
            Level18Locked.SetActive(false);
            Level18Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level18Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel18", 0) == 1)
            {
                Level18Done.GetComponent<Image>().sprite = level18Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel18", 0) == 2)
            {
                Level18Done.GetComponent<Image>().sprite = level18Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel18", 0) == 3)
            {
                Level18Done.GetComponent<Image>().sprite = level18Stars[2];

            }
            Level18Done.SetActive(true);
            Level18Undone.SetActive(false);
            Level19Locked.SetActive(false);
            Level19Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level19Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel19", 0) == 1)
            {
                Level19Done.GetComponent<Image>().sprite = level19Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel19", 0) == 2)
            {
                Level19Done.GetComponent<Image>().sprite = level19Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel19", 0) == 3)
            {
                Level19Done.GetComponent<Image>().sprite = level19Stars[2];

            }
            Level19Done.SetActive(true);
            Level19Undone.SetActive(false);
            Level20Locked.SetActive(false);
            Level20Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level20Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel20", 0) == 1)
            {
                Level20Done.GetComponent<Image>().sprite = level20Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel20", 0) == 2)
            {
                Level20Done.GetComponent<Image>().sprite = level20Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel20", 0) == 3)
            {
                Level20Done.GetComponent<Image>().sprite = level20Stars[2];

            }
            Level20Done.SetActive(true);
            Level20Undone.SetActive(false);
            Level21Locked.SetActive(false);
            Level21Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level21Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel21", 0) == 1)
            {
                Level21Done.GetComponent<Image>().sprite = level21Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel21", 0) == 2)
            {
                Level21Done.GetComponent<Image>().sprite = level21Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel21", 0) == 3)
            {
                Level21Done.GetComponent<Image>().sprite = level21Stars[2];

            }
            Level21Done.SetActive(true);
            Level21Undone.SetActive(false);
            Level22Locked.SetActive(false);
            Level22Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level22Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel22", 0) == 1)
            {
                Level22Done.GetComponent<Image>().sprite = level22Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel22", 0) == 2)
            {
                Level22Done.GetComponent<Image>().sprite = level22Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel22", 0) == 3)
            {
                Level22Done.GetComponent<Image>().sprite = level22Stars[2];

            }
            Level22Done.SetActive(true);
            Level22Undone.SetActive(false);
            Level23Locked.SetActive(false);
            Level23Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level23Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel23", 0) == 1)
            {
                Level23Done.GetComponent<Image>().sprite = level23Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel23", 0) == 2)
            {
                Level23Done.GetComponent<Image>().sprite = level23Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel23", 0) == 3)
            {
                Level23Done.GetComponent<Image>().sprite = level23Stars[2];

            }
            Level23Done.SetActive(true);
            Level23Undone.SetActive(false);
            Level24Locked.SetActive(false);
            Level24Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level24Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel24", 0) == 1)
            {
                Level24Done.GetComponent<Image>().sprite = level24Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel24", 0) == 2)
            {
                Level24Done.GetComponent<Image>().sprite = level24Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel24", 0) == 3)
            {
                Level24Done.GetComponent<Image>().sprite = level24Stars[2];

            }
            Level24Done.SetActive(true);
            Level24Undone.SetActive(false);
            Level25Locked.SetActive(false);
            Level25Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level25Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel25", 0) == 1)
            {
                Level25Done.GetComponent<Image>().sprite = level25Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel25", 0) == 2)
            {
                Level25Done.GetComponent<Image>().sprite = level25Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel25", 0) == 3)
            {
                Level25Done.GetComponent<Image>().sprite = level25Stars[2];

            }
            Level25Done.SetActive(true);
            Level25Undone.SetActive(false);
            Level26Locked.SetActive(false);
            Level26Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level26Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel26", 0) == 1)
            {
                Level26Done.GetComponent<Image>().sprite = level26Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel26", 0) == 2)
            {
                Level26Done.GetComponent<Image>().sprite = level26Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel26", 0) == 3)
            {
                Level26Done.GetComponent<Image>().sprite = level26Stars[2];

            }
            Level26Done.SetActive(true);
            Level26Undone.SetActive(false);
            Level27Locked.SetActive(false);
            Level27Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level27Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel27", 0) == 1)
            {
                Level27Done.GetComponent<Image>().sprite = level27Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel27", 0) == 2)
            {
                Level27Done.GetComponent<Image>().sprite = level27Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel27", 0) == 3)
            {
                Level27Done.GetComponent<Image>().sprite = level27Stars[2];

            }
            Level27Done.SetActive(true);
            Level27Undone.SetActive(false);
            Level28Locked.SetActive(false);
            Level28Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level28Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel28", 0) == 1)
            {
                Level28Done.GetComponent<Image>().sprite = level28Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel28", 0) == 2)
            {
                Level28Done.GetComponent<Image>().sprite = level28Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel28", 0) == 3)
            {
                Level28Done.GetComponent<Image>().sprite = level28Stars[2];

            }
            Level28Done.SetActive(true);
            Level28Undone.SetActive(false);
            Level29Locked.SetActive(false);
            Level29Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level29Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel29", 0) == 1)
            {
                Level29Done.GetComponent<Image>().sprite = level29Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel29", 0) == 2)
            {
                Level29Done.GetComponent<Image>().sprite = level29Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel29", 0) == 3)
            {
                Level29Done.GetComponent<Image>().sprite = level29Stars[2];

            }
            Level29Done.SetActive(true);
            Level29Undone.SetActive(false);
            Level30Locked.SetActive(false);
            Level30Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level30Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel30", 0) == 1)
            {
                Level30Done.GetComponent<Image>().sprite = level30Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel30", 0) == 2)
            {
                Level30Done.GetComponent<Image>().sprite = level30Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel30", 0) == 3)
            {
                Level30Done.GetComponent<Image>().sprite = level30Stars[2];

            }
            Level30Done.SetActive(true);
            Level30Undone.SetActive(false);

        }
        if (PlayerPrefs.GetInt("Level31Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel31", 0) == 1)
            {
                Level31Done.GetComponent<Image>().sprite = level31Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel31", 0) == 2)
            {
                Level31Done.GetComponent<Image>().sprite = level31Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel31", 0) == 3)
            {
                Level31Done.GetComponent<Image>().sprite = level31Stars[2];

            }
            Level31Done.SetActive(true);
            Level31Undone.SetActive(false);
            Level32Locked.SetActive(false);
            Level32Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level32Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel32", 0) == 1)
            {
                Level32Done.GetComponent<Image>().sprite = level32Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel32", 0) == 2)
            {
                Level32Done.GetComponent<Image>().sprite = level32Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel32", 0) == 3)
            {
                Level32Done.GetComponent<Image>().sprite = level32Stars[2];

            }
            Level32Done.SetActive(true);
            Level32Undone.SetActive(false);
            Level33Locked.SetActive(false);
            Level33Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level33Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel33", 0) == 1)
            {
                Level33Done.GetComponent<Image>().sprite = level33Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel33", 0) == 2)
            {
                Level33Done.GetComponent<Image>().sprite = level33Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel33", 0) == 3)
            {
                Level33Done.GetComponent<Image>().sprite = level33Stars[2];

            }
            Level33Done.SetActive(true);
            Level33Undone.SetActive(false);
            Level34Locked.SetActive(false);
            Level34Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level34Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel34", 0) == 1)
            {
                Level34Done.GetComponent<Image>().sprite = level34Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel34", 0) == 2)
            {
                Level34Done.GetComponent<Image>().sprite = level34Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel34", 0) == 3)
            {
                Level34Done.GetComponent<Image>().sprite = level34Stars[2];

            }

            Level34Done.SetActive(true);
            Level34Undone.SetActive(false);
            Level35Locked.SetActive(false);
            Level35Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level35Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel35", 0) == 1)
            {
                Level35Done.GetComponent<Image>().sprite = level35Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel35", 0) == 2)
            {
                Level35Done.GetComponent<Image>().sprite = level35Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel35", 0) == 3)
            {
                Level35Done.GetComponent<Image>().sprite = level35Stars[2];

            }
            Level35Done.SetActive(true);
            Level35Undone.SetActive(false);
            Level36Locked.SetActive(false);
            Level36Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level36Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel36", 0) == 1)
            {
                Level36Done.GetComponent<Image>().sprite = level36Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel36", 0) == 2)
            {
                Level36Done.GetComponent<Image>().sprite = level36Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel36", 0) == 3)
            {
                Level36Done.GetComponent<Image>().sprite = level36Stars[2];

            }
            Level36Done.SetActive(true);
            Level36Undone.SetActive(false);
            Level37Locked.SetActive(false);
            Level37Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level37Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel37", 0) == 1)
            {
                Level37Done.GetComponent<Image>().sprite = level37Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel37", 0) == 2)
            {
                Level37Done.GetComponent<Image>().sprite = level37Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel37", 0) == 3)
            {
                Level37Done.GetComponent<Image>().sprite = level37Stars[2];

            }
            Level37Done.SetActive(true);
            Level37Undone.SetActive(false);
            Level38Locked.SetActive(false);
            Level38Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level38Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel38", 0) == 1)
            {
                Level38Done.GetComponent<Image>().sprite = level38Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel38", 0) == 2)
            {
                Level38Done.GetComponent<Image>().sprite = level38Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel38", 0) == 3)
            {
                Level38Done.GetComponent<Image>().sprite = level38Stars[2];

            }
            Level38Done.SetActive(true);
            Level38Undone.SetActive(false);
            Level39Locked.SetActive(false);
            Level39Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level39Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel39", 0) == 1)
            {
                Level39Done.GetComponent<Image>().sprite = level39Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel39", 0) == 2)
            {
                Level39Done.GetComponent<Image>().sprite = level39Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel39", 0) == 3)
            {
                Level39Done.GetComponent<Image>().sprite = level39Stars[2];

            }
            Level39Done.SetActive(true);
            Level39Undone.SetActive(false);
            Level40Locked.SetActive(false);
            Level40Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level40Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel40", 0) == 1)
            {
                Level40Done.GetComponent<Image>().sprite = level40Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel40", 0) == 2)
            {
                Level40Done.GetComponent<Image>().sprite = level40Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel40", 0) == 3)
            {
                Level40Done.GetComponent<Image>().sprite = level40Stars[2];

            }
            Level40Done.SetActive(true);
            Level40Undone.SetActive(false);
            Level41Locked.SetActive(false);
            Level41Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level41Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel41", 0) == 1)
            {
                Level41Done.GetComponent<Image>().sprite = level41Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel41", 0) == 2)
            {
                Level41Done.GetComponent<Image>().sprite = level41Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel41", 0) == 3)
            {
                Level41Done.GetComponent<Image>().sprite = level41Stars[2];

            }
            Level41Done.SetActive(true);
            Level41Undone.SetActive(false);
            Level42Locked.SetActive(false);
            Level42Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level42Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel42", 0) == 1)
            {
                Level42Done.GetComponent<Image>().sprite = level42Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel42", 0) == 2)
            {
                Level42Done.GetComponent<Image>().sprite = level42Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel42", 0) == 3)
            {
                Level42Done.GetComponent<Image>().sprite = level42Stars[2];

            }
            Level42Done.SetActive(true);
            Level42Undone.SetActive(false);
            Level43Locked.SetActive(false);
            Level43Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level43Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel43", 0) == 1)
            {
                Level43Done.GetComponent<Image>().sprite = level43Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel43", 0) == 2)
            {
                Level43Done.GetComponent<Image>().sprite = level43Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel43", 0) == 3)
            {
                Level43Done.GetComponent<Image>().sprite = level43Stars[2];

            }
            Level43Done.SetActive(true);
            Level43Undone.SetActive(false);
            Level44Locked.SetActive(false);
            Level44Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level44Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel44", 0) == 1)
            {
                Level44Done.GetComponent<Image>().sprite = level44Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel44", 0) == 2)
            {
                Level44Done.GetComponent<Image>().sprite = level44Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel44", 0) == 3)
            {
                Level44Done.GetComponent<Image>().sprite = level44Stars[2];

            }
            Level44Done.SetActive(true);
            Level44Undone.SetActive(false);
            Level45Locked.SetActive(false);
            Level45Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level45Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel45", 0) == 1)
            {
                Level45Done.GetComponent<Image>().sprite = level45Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel45", 0) == 2)
            {
                Level45Done.GetComponent<Image>().sprite = level45Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel45", 0) == 3)
            {
                Level45Done.GetComponent<Image>().sprite = level45Stars[2];

            }
            Level45Done.SetActive(true);
            Level45Undone.SetActive(false);

        }
        if (PlayerPrefs.GetInt("Level46Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel46", 0) == 1)
            {
                Level46Done.GetComponent<Image>().sprite = level46Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel46", 0) == 2)
            {
                Level46Done.GetComponent<Image>().sprite = level46Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel46", 0) == 3)
            {
                Level46Done.GetComponent<Image>().sprite = level46Stars[2];

            }
            Level46Done.SetActive(true);
            Level46Undone.SetActive(false);
            Level47Locked.SetActive(false);
            Level47Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level47Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel47", 0) == 1)
            {
                Level47Done.GetComponent<Image>().sprite = level47Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel47", 0) == 2)
            {
                Level47Done.GetComponent<Image>().sprite = level47Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel47", 0) == 3)
            {
                Level47Done.GetComponent<Image>().sprite = level47Stars[2];

            }

            Level47Done.SetActive(true);
            Level47Undone.SetActive(false);
            Level48Locked.SetActive(false);
            Level48Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level48Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel48", 0) == 1)
            {
                Level48Done.GetComponent<Image>().sprite = level48Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel48", 0) == 2)
            {
                Level48Done.GetComponent<Image>().sprite = level48Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel48", 0) == 3)
            {
                Level48Done.GetComponent<Image>().sprite = level48Stars[2];

            }

            Level48Done.SetActive(true);
            Level48Undone.SetActive(false);
            Level49Locked.SetActive(false);
            Level49Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level49Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel49", 0) == 1)
            {
                Level49Done.GetComponent<Image>().sprite = level49Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel49", 0) == 2)
            {
                Level49Done.GetComponent<Image>().sprite = level49Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel49", 0) == 3)
            {
                Level49Done.GetComponent<Image>().sprite = level49Stars[2];

            }
            Level49Done.SetActive(true);
            Level49Undone.SetActive(false);
            Level50Locked.SetActive(false);
            Level50Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level50Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel50", 0) == 1)
            {
                Level50Done.GetComponent<Image>().sprite = level50Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel50", 0) == 2)
            {
                Level50Done.GetComponent<Image>().sprite = level50Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel50", 0) == 3)
            {
                Level50Done.GetComponent<Image>().sprite = level50Stars[2];

            }
            Level50Done.SetActive(true);
            Level50Undone.SetActive(false);
            Level51Locked.SetActive(false);
            Level51Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level51Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel51", 0) == 1)
            {
                Level51Done.GetComponent<Image>().sprite = level51Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel51", 0) == 2)
            {
                Level51Done.GetComponent<Image>().sprite = level51Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel51", 0) == 3)
            {
                Level51Done.GetComponent<Image>().sprite = level51Stars[2];

            }
            Level51Done.SetActive(true);
            Level51Undone.SetActive(false);
            Level52Locked.SetActive(false);
            Level52Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level52Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel52", 0) == 1)
            {
                Level52Done.GetComponent<Image>().sprite = level52Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel52", 0) == 2)
            {
                Level52Done.GetComponent<Image>().sprite = level52Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel52", 0) == 3)
            {
                Level52Done.GetComponent<Image>().sprite = level52Stars[2];

            }
            Level52Done.SetActive(true);
            Level52Undone.SetActive(false);
            Level53Locked.SetActive(false);
            Level53Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level53Done", 0) == 1)
        {

            if (PlayerPrefs.GetInt("StarsLevel53", 0) == 1)
            {
                Level53Done.GetComponent<Image>().sprite = level53Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel53", 0) == 2)
            {
                Level53Done.GetComponent<Image>().sprite = level53Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel53", 0) == 3)
            {
                Level53Done.GetComponent<Image>().sprite = level53Stars[2];

            }
            Level53Done.SetActive(true);
            Level53Undone.SetActive(false);
            Level54Locked.SetActive(false);
            Level54Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level54Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel54", 0) == 1)
            {
                Level54Done.GetComponent<Image>().sprite = level54Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel54", 0) == 2)
            {
                Level54Done.GetComponent<Image>().sprite = level54Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel54", 0) == 3)
            {
                Level54Done.GetComponent<Image>().sprite = level54Stars[2];

            }
            Level54Done.SetActive(true);
            Level54Undone.SetActive(false);
            Level55Locked.SetActive(false);
            Level55Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level55Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel55", 0) == 1)
            {
                Level55Done.GetComponent<Image>().sprite = level55Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel55", 0) == 2)
            {
                Level55Done.GetComponent<Image>().sprite = level55Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel55", 0) == 3)
            {
                Level55Done.GetComponent<Image>().sprite = level55Stars[2];

            }
            Level55Done.SetActive(true);
            Level55Undone.SetActive(false);
            Level56Locked.SetActive(false);
            Level56Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level56Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel56", 0) == 1)
            {
                Level56Done.GetComponent<Image>().sprite = level56Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel56", 0) == 2)
            {
                Level56Done.GetComponent<Image>().sprite = level56Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel56", 0) == 3)
            {
                Level56Done.GetComponent<Image>().sprite = level56Stars[2];

            }

            Level56Done.SetActive(true);
            Level56Undone.SetActive(false);
            Level57Locked.SetActive(false);
            Level57Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level57Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel57", 0) == 1)
            {
                Level57Done.GetComponent<Image>().sprite = level57Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel57", 0) == 2)
            {
                Level57Done.GetComponent<Image>().sprite = level57Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel57", 0) == 3)
            {
                Level57Done.GetComponent<Image>().sprite = level57Stars[2];

            }
            Level57Done.SetActive(true);
            Level57Undone.SetActive(false);
            Level58Locked.SetActive(false);
            Level58Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level58Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel58", 0) == 1)
            {
                Level58Done.GetComponent<Image>().sprite = level58Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel58", 0) == 2)
            {
                Level58Done.GetComponent<Image>().sprite = level58Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel58", 0) == 3)
            {
                Level58Done.GetComponent<Image>().sprite = level58Stars[2];

            }
            Level58Done.SetActive(true);
            Level58Undone.SetActive(false);
            Level59Locked.SetActive(false);
            Level59Undone.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Level59Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel59", 0) == 1)
            {
                Level59Done.GetComponent<Image>().sprite = level59Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel59", 0) == 2)
            {
                Level59Done.GetComponent<Image>().sprite = level59Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel59", 0) == 3)
            {
                Level59Done.GetComponent<Image>().sprite = level59Stars[2];

            }

            Level59Done.SetActive(true);
            Level59Undone.SetActive(false);
            Level60Locked.SetActive(false);
            Level60Undone.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Level60Done", 0) == 1)
        {
            if (PlayerPrefs.GetInt("StarsLevel60", 0) == 1)
            {
                Level60Done.GetComponent<Image>().sprite = level60Stars[0];

            }
            if (PlayerPrefs.GetInt("StarsLevel60", 0) == 2)
            {
                Level60Done.GetComponent<Image>().sprite = level60Stars[1];

            }

            if (PlayerPrefs.GetInt("StarsLevel60", 0) == 3)
            {
                Level60Done.GetComponent<Image>().sprite = level60Stars[2];

            }
            Level60Done.SetActive(true);
            Level60Undone.SetActive(false);
        }
      


        about = false;
        store = false;
     
 

       // PlayerPrefs.SetInt("Total_Candy", 0);
   //  PlayerPrefs.SetInt("highScore", 602);
   // PlayerPrefs.SetInt("Total_Candy", 187);
    /*   PlayerPrefs.SetInt("Loly2lock", 0);
        PlayerPrefs.SetInt("Loly3lock", 0);
        PlayerPrefs.SetInt("Loly4lock", 0);
        PlayerPrefs.SetInt("Loly5lock", 0);
        PlayerPrefs.SetInt("Loly6lock", 0);
        PlayerPrefs.SetInt("Loly7lock", 0);
        PlayerPrefs.SetInt("Loly8lock", 0);
        PlayerPrefs.SetInt("Loly9lock", 0);
        PlayerPrefs.SetInt("Loly10lock", 0);
        PlayerPrefs.SetInt("Loly11lock", 0);
        PlayerPrefs.SetInt("Loly12lock", 0);
        PlayerPrefs.SetInt("Loly13lock", 0);
        PlayerPrefs.SetInt("Loly14lock", 0);
        PlayerPrefs.SetInt("Loly15lock", 0);
        PlayerPrefs.SetInt("Loly16lock", 0);
        PlayerPrefs.SetInt("Loly17lock", 0);
        PlayerPrefs.SetInt("Loly18lock", 0);
        PlayerPrefs.SetInt("Loly19lock", 0);
        PlayerPrefs.SetInt("Loly20lock", 0);
        PlayerPrefs.SetInt("Loly21lock", 0);
        PlayerPrefs.SetInt("Loly22lock", 0);
        PlayerPrefs.SetInt("Loly23lock", 0);
        PlayerPrefs.SetInt("Loly24lock", 0);*/
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        SkinSelected =  PlayerPrefs.GetInt("SkinSelected",1);
        Unlocked2 = PlayerPrefs.GetInt("Loly2lock", 0);
        Unlocked3 = PlayerPrefs.GetInt("Loly3lock", 0);
        Unlocked4 = PlayerPrefs.GetInt("Loly4lock", 0);
        Unlocked5 = PlayerPrefs.GetInt("Loly5lock", 0);
        Unlocked6 = PlayerPrefs.GetInt("Loly6lock", 0);
        Unlocked7 = PlayerPrefs.GetInt("Loly7lock", 0);
        Unlocked8 = PlayerPrefs.GetInt("Loly8lock", 0);
        Unlocked9 = PlayerPrefs.GetInt("Loly9lock", 0);
        Unlocked10 = PlayerPrefs.GetInt("Loly10lock", 0);
        Unlocked11 = PlayerPrefs.GetInt("Loly11lock", 0);
        Unlocked12 = PlayerPrefs.GetInt("Loly12lock", 0);
        Unlocked13 = PlayerPrefs.GetInt("Loly13lock", 0);
        Unlocked14 = PlayerPrefs.GetInt("Loly14lock", 0);
        Unlocked15 = PlayerPrefs.GetInt("Loly15lock", 0);
        Unlocked16 = PlayerPrefs.GetInt("Loly16lock", 0);
        Unlocked17 = PlayerPrefs.GetInt("Loly17lock", 0);
        Unlocked18 = PlayerPrefs.GetInt("Loly18lock", 0);
        Unlocked19 = PlayerPrefs.GetInt("Loly19lock", 0);
        Unlocked20 = PlayerPrefs.GetInt("Loly20lock", 0);
        Unlocked21 = PlayerPrefs.GetInt("Loly21lock", 0);
        Unlocked22 = PlayerPrefs.GetInt("Loly22lock", 0);
        Unlocked23 = PlayerPrefs.GetInt("Loly23lock", 0);
        Unlocked24 = PlayerPrefs.GetInt("Loly24lock", 0);



        Music.GetComponent<AudioSource>().enabled = false;
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);

        if (SoundIndex == 0)
        {
            SoundButton.GetComponent<Button>().image.sprite = SoundOffSprite;
            GetComponent<AudioSource>().enabled = false;
     
            sound = false;

        }
        else if (SoundIndex == 1)
        {

            SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
            GetComponent<AudioSource>().enabled = true;
            sound = true;

        }
        if (MusicIndex == 0)
        {
            Music.GetComponent<AudioSource>().enabled = true;
            Music.GetComponent<AudioSource>().volume = 0;
            MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

            music = false;

        }
        else if (MusicIndex == 1)
        {
            Music.GetComponent<AudioSource>().enabled = true;
            Music.GetComponent<AudioSource>().Stop();

           
        
            Invoke("volume", 0.3f);
           

            MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
            music = true;

        }

    }
    void volume()
    {
        Music.GetComponent<AudioSource>().volume = 0.5f;
        Music.GetComponent<AudioSource>().Play();

    }
   

   

 
       

    
}
