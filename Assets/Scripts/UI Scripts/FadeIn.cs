using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	
	public float FadeInTimeSeconds;
	//public float FadeOutTimeSeconds = 2;

	private Image fadePanel;
	private Color currentColor = Color.black;

	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	
	void Update () {
		if (Time.timeSinceLevelLoad < FadeInTimeSeconds)
		{
			float alphaChange = Time.deltaTime / FadeInTimeSeconds;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		}
		else
		{
			gameObject.SetActive(false);
		}
	}
}
