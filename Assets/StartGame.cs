using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;
public class StartGame : MonoBehaviour {
    float time2 = 2f;
    float time = 2.99f;
	// Use this for initialization
	void Awake () {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("You've successfully logged in");
            }
            else
            {
                Debug.Log("Login failed for some reason");
            }
        });

        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()

            .Build();

        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        

       

      
    }

    void Start()
    {
     /*   PlayGamesPlatform.Activate();
        if (PlayGamesPlatform.Instance.IsAuthenticated())
            PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI3_mdluoIEAIQCA");
        else
            Social.localUser.Authenticate((bool success) =>
            {
                PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI3_mdluoIEAIQCA");
            });
        */

    }
    // Update is called once per frame
	void Update () {
        if (time > 0)
            time -= Time.deltaTime;
        else
        {

            Application.LoadLevel("MainMenu");

            
           

        }
   


	}
}
