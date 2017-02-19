using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
    public Slider playersSlider;
    public static int NumberOfPlayersSetting;
    public LevelManager levelManager;

	private MusicManager musicManager;

	void Awake () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();

		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	    playersSlider.value = PlayerPrefsManager.GetNumberOfPlayers();
	    NumberOfPlayersSetting = (int)playersSlider.value;
	}
	
	void Update () {
		musicManager.SetVolume(volumeSlider.value);

	}

	public void SaveSettings()
	{
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        PlayerPrefsManager.SetNumberOfPlayers((int)playersSlider.value);
	    NumberOfPlayersSetting = (int) playersSlider.value;
		Debug.Log("Settings saved!");
	}

	public void SetDefault()
	{
		volumeSlider.value = 0.75f;
		difficultySlider.value = 2f;
	    playersSlider.value = 1;
	}

  

}
