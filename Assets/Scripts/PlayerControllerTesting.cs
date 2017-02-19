using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTesting : MonoBehaviour {

    public float PlayerSpeed = 5;


    private string[] _playerInput;
    private Rigidbody2D _rbodyTest;

    // Use this for initialization
    void Start () {
        GetPlayerInput();
        _rbodyTest = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {


        var inputX = Input.GetAxisRaw(_playerInput[0]);
        var inputY = Input.GetAxisRaw(_playerInput[1]);
        Move(inputX, inputY);
       
	}

    private void GetPlayerInput()
    {
        if (tag == "Player1")
        {
            _playerInput = new string[] { "Horizontal1", "Vertical1", "RotationX1", "RotationY1" };
        }
        else if (tag == "Player2")
        {
            _playerInput = new string[] { "Horizontal2", "Vertical2", "RotationX2", "RotationY2" };
        }
    }


    public void Move(float input_x, float input_y)
    {
        _rbodyTest = gameObject.GetComponent<Rigidbody2D>();
        switch (tag)
        {
            case ("Player1"):
            case ("Player2"):
            case ("Player3"):
            case ("Player4"):
                // Lav variabler
                Vector3 pos = transform.position;
                //Debug.Log("Vector pos is" + pos);
                       
                // Bevæg player
                Vector3 velocity = new Vector3(input_x * PlayerSpeed * Time.deltaTime, input_y * PlayerSpeed * Time.deltaTime, 0);
                //Debug.Log("Velocity is" + velocity);
                pos += velocity;
                transform.position = pos;

                break;
            case ("Enemy"):
                _rbodyTest.velocity = new Vector2(input_x, input_y);
                break;
        }
    }



}
