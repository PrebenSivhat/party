using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	public float StartFadingAfterSeconds;
	//public float FadeInTimeSeconds = 2;
	public float FadeOutTimeSeconds;

	private Image fadePanel;
	private Color currentColor;

	void Start () {
		fadePanel = GetComponent<Image>();
		
	}
	
	
	void Update () {

		
		if (Time.timeSinceLevelLoad >= StartFadingAfterSeconds)
		{
			float alphaChange = ((Time.deltaTime) / FadeOutTimeSeconds);
			//Debug.Log(alphaChange);
			currentColor.a += alphaChange;
			fadePanel.color = currentColor;
		}
		
		
	}
}
