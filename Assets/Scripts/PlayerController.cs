using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class PlayerController : Movement
{
    public float MaxHealth = 5;
    public float CurrentHealth;
    //public Rigidbody2D _rbody;

    private float inputX;
    private float inputY;

    private string[] _playerInput;

    private void Start()
    {
        GetPlayerInput();
        Rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Henter input-X og -Y fra player
        inputX = Input.GetAxisRaw(_playerInput[0]);
        inputY = Input.GetAxisRaw(_playerInput[1]);
        
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
 
}