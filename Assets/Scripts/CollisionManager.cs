using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            HealthController.Damage(gameObject);
        }

        if (other.tag == "Portal_Level_01")
        {
            Debug.Log("Should load level_01 now!");
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("02 Level_01");

            // LevelManager.LoadLevel("02 Level_01");
        }

    }


}
