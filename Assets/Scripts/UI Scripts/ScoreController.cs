using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreController : MonoBehaviour
{
    public static int PointsPlayer1;
    public static int PointsPlayer2;
    public static int PointsPlayer3;
    public static int PointsPlayer4;
    public static int Points;

    public static bool PlayersAlive;
    public static bool CheckForAlivePlayers = true;
    public GameObject RestartButton;

    private int _numberOfPlayersInGame;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start ()
    {
        _numberOfPlayersInGame = PlayerPrefsManager.GetNumberOfPlayers();
        CheckForAlivePlayers = true;
        Points = 1;

        /*
        if (Points != 1)
        {
            Debug.LogError("Points should be 0! instead points are: " + Points);
        }
        */
        
        //Debug.Log("Player1 has this many points in start of round: " + PointsPlayer1);
        //Debug.Log("Player2 has this many points in start of round: " + PointsPlayer2);

        
    }

    void Update()
    {

            
        if (CheckForAlivePlayers == true && LevelManager.GameLevelActive == true)
        //GameObject.Find("PlayerSpawner").GetComponent<PlayerSpawner>().GameIsStarted == true)
        {
            if (GameObject.Find("Player1(Clone)") == null &&
                GameObject.Find("Player2(Clone)") == null &&
                GameObject.Find("Player3(Clone)") == null &&
                GameObject.Find("Player4(Clone)") == null)
            {
                PlayersAlive = false;
                //CreateRestartButton();
                CheckForAlivePlayers = false;
                LevelManager.GameLevelActive = false;

                GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("02 Level_00");
                //LevelManager.LoadLevel("02 Level_00");


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
    

    public static void UpdateScore(GameObject player)
    {
        switch (player.tag)
        {
            case ("Player1"):
                {
                    PointsPlayer1 += Points;
                    Points++;
                    Debug.Log(player + "got this many points now: " + PointsPlayer1);
                }
                break;
             case ("Player2"):
                {
                    PointsPlayer2 += Points;
                    Points++;
                    Debug.Log(player + "got this many points now: " + PointsPlayer2);


                }
                break;
             case ("Player3"):
                {
                    PointsPlayer3 += Points;
                    Points++;
                    Debug.Log(player + "got this many points now: " + PointsPlayer3);


                }
                break;
             case ("Player4"):
                {
                    PointsPlayer4 += Points;
                    Points++;
                    Debug.Log(player + "got this many points now: " + PointsPlayer4);

                }
                break;
        }
        

    }

    void CheckForPlayers()
    {
       
    }


}
