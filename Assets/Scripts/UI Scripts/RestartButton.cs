using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	

	void Start ()
	{
	   

	}
	
	// Update is called once per frame
	void Update () {
	    if (ScoreController.PlayersAlive == true)
	    {
            Destroy(gameObject);
            
	    }
	}
}
