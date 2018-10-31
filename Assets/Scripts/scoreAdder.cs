using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreAdder : MonoBehaviour
{
		public Text scoreText;
		public Text scoreTextFader;
		public float fadeSpeed = 1f;
		Vector3 posFrom;
		Vector3 posTo;
		Color fadeColorFrom;
		Color fadeColorTo;
		float startTime;
		int actualScore = 0;

		void Awake ()
		{
				posFrom = scoreTextFader.transform.position;
				posTo = posFrom + new Vector3 (0, 50f, 0);
				fadeColorFrom = scoreTextFader.color;
				fadeColorTo = new Color (0, 0, 0, 0);
				scoreTextFader.color = fadeColorTo;
				//auto add a score just for showcase purpose
				InvokeRepeating ("addScoreTest", 0f, 3f);
		}
	
		void addScoreTest ()
		{
				addScore (2);
		}

		void addScore (int scoreToAdd)
		{
				actualScore += scoreToAdd;
				scoreText.text = actualScore.ToString ();
				scoreTextFader.text = "+" + scoreToAdd;
				scoreTextFader.transform.position = posFrom;
				scoreTextFader.color = fadeColorFrom;
				startTime = Time.time;
		}

		void Update ()
		{
				if (scoreTextFader.transform.position != posTo) {
						scoreTextFader.transform.position = Vector3.Slerp (posFrom, posTo, (Time.time - startTime) * fadeSpeed);
						scoreTextFader.color = Color.Lerp (fadeColorFrom, fadeColorTo, (Time.time - startTime) * fadeSpeed);
				}
		}
}
