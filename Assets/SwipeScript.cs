using UnityEngine;
using System.Collections;

public class SwipeScript : MonoBehaviour
{

    public float minSwipeDistY;

    public float minSwipeDistX;

    private Vector2 startPos;
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    void Update()
	{
//#if UNITY_ANDROID
		if (Input.touchCount == 1) 
			
		{
			
			Touch touch = Input.touches[0];
			 if(Input.mousePosition.y > (Screen.height/2)-150){


                 switch (touch.phase)
                 {

                     case TouchPhase.Began:

                         startPos = touch.position;


                         break;



                     case TouchPhase.Ended:

                         float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

                         if (swipeDistVertical > minSwipeDistY)
                         {

                             float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                             if (swipeValue > 0)
                             {//up swipe

                                 //Jump ();
                             }
                             else if (swipeValue < 0) { }//down swipe

                             //Shrink ();

                         }

                         float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                         if (swipeDistHorizontal > 100f)
                         {

                             float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                             if (swipeValue > 700f)
                             {
                                 if (!playerController.LevelFinished && !playerController.over && !playerController.Dead && playerController.isGrounded && PauseMenuNavigation.swipedetected == false)
                                 {
                                     PauseMenuNavigation.swipedetected = true;
                                 }
                                 // transform.position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z + 10);

                             }//right swipe

                                 //MoveRight ();

                             else if (swipeValue < 700f) { }//left swipe
                             // 
                             if (!playerController.LevelFinished && !playerController.over && !playerController.Dead && playerController.isGrounded && PauseMenuNavigation.swipedetected == false)
                             {
                                 PauseMenuNavigation.swipedetected = true;
                             }
                             //MoveLeft ();

                         }
                        break;
                 }
			}
		}
	}
}