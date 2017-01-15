using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();

		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	void Update () {
		musicManager.SetVolume(volumeSlider.value);
	}

	public void SaveSettings()
	{
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		Debug.Log("Settings saved!");
	}

	public void SetDefault()
	{
		volumeSlider.value = 0.75f;
		difficultySlider.value = 2f;
	}

}
