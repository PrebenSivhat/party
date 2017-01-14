using System;
using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{

    public static int PlayerHealth1 = 5;
    public static int PlayerHealth2 = 5;

    public static void Damage(GameObject player)
    {
        switch (player.tag)
        {
            case ("Player1"):
                PlayerHealth1 -= 1;
                if (PlayerHealth1 <= 0)
                {
                    Destroy(player);
                }
                break;

            case ("Player2"):
                PlayerHealth2 -= 1;
                if (PlayerHealth2 <= 0)
                {
                    Destroy(player);
                }
                break;
        }
    }

   
    private void Die()
    {
       Destroy(gameObject);
    }

}
