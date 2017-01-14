using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    private Text _scoreText;
    

    // Use this for initialization
    void Start()
    {
        _scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (this.tag)
        {
            case ("Player1"):
                _scoreText.text = "Lives: " + HealthController.PlayerHealth1;
                break;
            case ("Player2"):
                _scoreText.text = "Lives: " + HealthController.PlayerHealth2;
                break;
        }
    }
}
