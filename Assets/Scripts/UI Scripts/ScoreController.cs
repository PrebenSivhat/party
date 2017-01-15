using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour
{

    public static int scorePlayer1;
    public static int scorePlayer2;
    public int[] points = { 1, 2, 3, 4 };
    //private bool _isAlivePlayer1;
    //private bool _isAlivePlayer2;


    void Start () {
        DontDestroyOnLoad(gameObject);
    }
	
	void Update () {
	    
	}

    void UpdateScore(int sP1, int sP2)
    {
        scorePlayer1 = sP1;
        scorePlayer2 = sP2;
    }



}
