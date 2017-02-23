using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnPlayerUI : MonoBehaviour
{
    public GameObject[] PlayerPrefabsUI;
    private int _playerz;

    void Awake()
    {
        _playerz = PlayerSpawner.NumberOfPlayers;
    }

    public void SpawnThePlayerUI()
    {
        //_playerz += 1;
        Debug.Log("number of players to make UI for: " + (_playerz + 1));


        for (int i = 0; i <= _playerz; i++)
        {
            //Debug.Log("Creating UI for player: " + (i));

            var instance = Instantiate(PlayerPrefabsUI[i]);
            instance.transform.SetParent(transform);
            instance.transform.position += new Vector3(0, 275, 0);
        }
    }

}
