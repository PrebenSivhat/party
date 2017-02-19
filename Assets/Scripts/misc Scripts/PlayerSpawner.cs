using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] PlayerPrefabs;
    public static int NumberOfPlayers;

    //public bool GameIsStarted = false;


    private GameObject[] _allTagsPlayer1;
    private GameObject[] _allTagsPlayer2;
    private GameObject[] _allTagsPlayer3;
    private GameObject[] _allTagsPlayer4;
    
    void Awake ()
	{
	    NumberOfPlayers = PlayerPrefsManager.GetNumberOfPlayers();
        SpawnPlayers();
        
	}

    void Start()
    {
        //GameIsStarted = true;
        UnityEngine.Debug.Log("Game Is Started!");
    }

    void Update ()
	{
        //CleanPlayers();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log(NumberOfPlayers);
            
            SpawnPlayers();
            UnityEngine.Debug.Log("Players Created. " + NumberOfPlayers);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            UnityEngine.Debug.Log(NumberOfPlayers);

            CleanPlayers();
            UnityEngine.Debug.Log("Players Cleaned. " + NumberOfPlayers);
        }

    }

    public void CleanPlayers()
    {
        _allTagsPlayer1 = GameObject.FindGameObjectsWithTag("Player1");
        foreach (GameObject player in _allTagsPlayer1)
        {
            Destroy(player);
        }

        _allTagsPlayer2 = GameObject.FindGameObjectsWithTag("Player2");
        foreach (GameObject player in _allTagsPlayer2)
        {
            Destroy(player);
        }

        _allTagsPlayer3 = GameObject.FindGameObjectsWithTag("Player3");
        foreach (GameObject player in _allTagsPlayer3)
        {
            Destroy(player);
        }

        _allTagsPlayer3 = GameObject.FindGameObjectsWithTag("Player3");
        foreach (GameObject player in _allTagsPlayer3)
        {
            Destroy(player);
        }
    }

    public void SpawnPlayers()
    {

        UnityEngine.Debug.Log("number of players to spawn: " + (NumberOfPlayers + 1));

        for (int i = 0; i <= NumberOfPlayers; i++)
        {
            Instantiate(PlayerPrefabs[i]);
            // UnityEngine.Debug.Log("Spawned player" + (i + 1));
        }
      
     }

    
}

    

