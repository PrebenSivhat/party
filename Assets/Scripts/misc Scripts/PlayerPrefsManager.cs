using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string PLAYER_KEY = "number_of_players";
    const string LEVEL_KEY = "level_unlocked_";

	// level_unlocked_1

	public static void SetMasterVolume (float volume)
	{
		if (volume >= 0f && volume <= 1f)
		{
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else { Debug.LogError("Master Volume out of range!!!!!"); }
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

    public static void SetNumberOfPlayers(int players)
    {
        if (players >= 0 && players <= 3)
        {
            PlayerPrefs.SetInt(PLAYER_KEY, players);
        } else { Debug.LogError("NUMBER OF PLAYERS OUT OF RANGE!!!!"); }
    }

    public static int GetNumberOfPlayers()
    {
        return PlayerPrefs.GetInt(PLAYER_KEY);
    }
	
	public static void UnlockLevel(int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1)
		{
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);  // Use 1 for true
		} else { Debug.LogError("Trying to unlock level not in build order!"); }
	}

	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= SceneManager.sceneCountInBuildSettings - 1)
		{
			return isLevelUnlocked;
		}
		else
		{
			Debug.LogError("Trying to query level that is not in build order!");
			return false;
		}
	}

	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 0f && difficulty <= 3f)
		{
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		}
		else { Debug.LogError("Difficulty chosen is not possible. ABORT, ABORT!!"); }

	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
}
