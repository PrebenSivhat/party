using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class PlayerController : Movement
{
    public float PlayerSpeed;
    public float RotationSpeed;
    public float MaxHealth = 5;
    public float CurrentHealth;
    public Rigidbody2D _rbody;
    public static bool slow;

    private string[] _playerInput;

    private void Start()
    {
        GetPlayerInput();
        _rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var inputX = Input.GetAxisRaw(_playerInput[0]);
        var inputY = Input.GetAxisRaw(_playerInput[1]);
        var rotationInputX = Input.GetAxisRaw(_playerInput[2]);
        var rotationInputY = Input.GetAxisRaw(_playerInput[3]);
        Move(_rbody, inputX, inputY, PlayerSpeed);
        Rotate(rotationInputX, rotationInputY, RotationSpeed);
        if (slow == true) { MoveSlow(_rbody, inputX, inputY, PlayerSpeed); }
        if ( Input.GetKeyDown("joystick button 0") ) { slow = true; }
     }

    private void GetPlayerInput()
    {

        if (tag == "Player1")
        {
            _playerInput = new string[] {"Horizontal1", "Vertical1", "RotationX1", "RotationY1"};
        }
        else if (tag == "Player2")
        {
            _playerInput = new string[] {"Horizontal2", "Vertical2", "RotationX2", "RotationY2"};
        }

    }

    }