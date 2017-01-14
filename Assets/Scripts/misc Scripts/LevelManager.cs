using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public int currentLevel;
	private Scene activeScene;

	public float autoLoadNextLevelAfter;

	void Start()
	{
		if(autoLoadNextLevelAfter <= 0)
		{
			Debug.Log("Level auto load disabled");
		}
		else
		{
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}

	}
	

	public void LoadLevel(string name)
	{
		Debug.Log("LoadLevel requested for: " + name + " and Difficulty is:" + PlayerPrefsManager.GetDifficulty());
		SceneManager.LoadScene(name);
		
	}


	

	public void QuitRequest()
	{
		Debug.Log("Quitting requested!");
		Application.Quit();
		
	}



	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log("LoadNextLevel has now been run going to: " + (SceneManager.GetActiveScene().buildIndex + 1));
		
	}


	public void LoadLastLevel ()
	{
		SceneManager.LoadScene("Level_0" + currentLevel);
		
	}


}
