using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_01 : MonoBehaviour {

	// Use this for initialization
	void Awake ()
	{
	    LevelManager.GameLevelActive = true;
        Debug.Log("Should spawn UI now!");
        GameObject.FindGameObjectWithTag("CanvasUI").GetComponent<SpawnPlayerUI>().SpawnThePlayerUI();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
