using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TransitionDemo : MonoBehaviour
{
	public EMTransition transition1;
	public EMTransition transition2;
	bool button =true;
	float delay = 0.5f;
	bool isCloseScene = true;

	public void OnTransitionStart()
	{
		if(!button) return;
		if(isCloseScene) {
            button = false;
		}
	}

	public void OnTransitionComplete()
	{
		if(!button) return;
		if(isCloseScene) {
			isCloseScene = false;
			Invoke ("OnStartAnimation", delay);
		} else {
			button=true;
			isCloseScene = true;
		}
	}

	public void OnStartAnimation()
	{
		transition1.Play();
		transition2.Play();
	}
	
}
