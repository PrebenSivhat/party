using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;

public class HealthController : MonoBehaviour
{

    public static int PlayerHealth1;
    public static int PlayerHealth2;
    public static int PlayerHealth3;
    public static int PlayerHealth4;

    void Start()
    {
        PlayerHealth1 = 1;
        PlayerHealth2 = 1;
        PlayerHealth3 = 1;
        PlayerHealth4 = 1;
    }

    public static void Damage(GameObject player)
    {
        switch (player.tag)
        {
            case ("Player1"):
                PlayerHealth1 -= 1;
                if (PlayerHealth1 <= 0)
                {
                    PlayerHealth1 = 0;
                    ScoreController.UpdateScore(player);
                    player.SetActive(false);
                }
                break;

            case ("Player2"):
                PlayerHealth2 -= 1;
                if (PlayerHealth2 <= 0)
                {
                    PlayerHealth2 = 0;
                    ScoreController.UpdateScore(player);
                    player.SetActive(false);
                }
                break;
            case ("Player3"):
                PlayerHealth3 -= 1;
                if (PlayerHealth3 <= 0)
                {
                    PlayerHealth3 = 0;
                    ScoreController.UpdateScore(player);
                    player.SetActive(false);
                }
                break;
            case ("Player4"):
                PlayerHealth4 -= 1;
                if (PlayerHealth4 <= 0)
                {
                    PlayerHealth4 = 0;
                    ScoreController.UpdateScore(player);
                    player.SetActive(false);
                }
                break;
        }
    }

   
    private void Die()
    {
       Destroy(gameObject);
    }

}
