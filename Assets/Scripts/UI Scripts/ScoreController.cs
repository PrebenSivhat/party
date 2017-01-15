using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour
{

    public static int scorePlayer1;
    public static int scorePlayer2;
    public int[] points = { 1, 2, 3, 4 };
    public static bool PlayersAlive;
    public static bool CheckForAlivePlayers = true;
    public GameObject RestartButton;
    //private bool _isAlivePlayer2;


    void Start () {
        DontDestroyOnLoad(gameObject);

        if (GameObject.Find("Player1") != null)
        {
            Debug.Log("player1 is alive");
        }
        if (GameObject.Find("Player2") != null)
        {
            Debug.Log("player2 is alive");
        }
        if (GameObject.Find("Player3") != null)
        {
            Debug.Log("player3 is alive");
        }
        if (GameObject.Find("Player4") != null)
        {
            Debug.Log("player4 is alive");
        }

    }

    void Update()
    {

        if (CheckForAlivePlayers == true)
        {
            if (GameObject.Find("Player1") == null &&
                GameObject.Find("Player2") == null &&
                GameObject.Find("Player3") == null &&
                GameObject.Find("Player4") == null)
            {
                PlayersAlive = false;
                CreateRestartButton();
                CheckForAlivePlayers = false;

            }
            else
            {
                PlayersAlive = true;
            }
        }



    }

    void CreateRestartButton()
    {
        var instance = Instantiate(RestartButton) as GameObject;
    }
    

    void UpdateScore(int sP1, int sP2)
    {
        scorePlayer1 = sP1;
        scorePlayer2 = sP2;
    }

    void CheckForPlayers()
    {
       
    }


}
