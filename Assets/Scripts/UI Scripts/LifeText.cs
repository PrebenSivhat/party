﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeText : MonoBehaviour
{

    private Text _lifeText;
    

    void Start()
    {
        _lifeText = GetComponent<Text>();
    }

    void Update()
    {
        switch (this.tag)
        {
            case ("Player1"):
                _lifeText.text = "Lives: " + HealthController.PlayerHealth1;
                break;
            case ("Player2"):
                _lifeText.text = "Lives: " + HealthController.PlayerHealth2;
                break;
            case ("Player3"):
                _lifeText.text = "Lives: " + HealthController.PlayerHealth3;
                break;
            case("Player4"):
                _lifeText.text = "Lives: " + HealthController.PlayerHealth4;
                break;
        }

    }

    
}
