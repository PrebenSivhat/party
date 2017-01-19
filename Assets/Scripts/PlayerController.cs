using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class PlayerController : Movement
{
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
        //Henter input-X og -Y fra player
        var inputX = Input.GetAxisRaw(_playerInput[0]);
        var inputY = Input.GetAxisRaw(_playerInput[1]);
        //Henter Rotations-X og -Y fra player
        var rotationInputX = Input.GetAxisRaw(_playerInput[2]);
        var rotationInputY = Input.GetAxisRaw(_playerInput[3]);
        //Hvis Fire1 triggers, sættes slow til true og timer ud efter 2s
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(SlowPlayer());
        };


        if (slow == true)
        {
            MoveSlow(_rbody, inputX, inputY, PlayerSpeed);
            Rotate(-rotationInputX, rotationInputY, PlayerRotationSpeed);
        }
        else
        {
            Move(inputX, inputY);
            Rotate(-rotationInputX, rotationInputY, PlayerRotationSpeed);
        };

        if (inputX > 0.2f || inputX < -0.2f || inputY > 0.2f || inputY < -0.2f)
        {

            gameObject.transform.rotation = new Quaternion(inputX, inputY, transform.rotation.z, 0);

        }

        

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

    IEnumerator SlowPlayer()
    {
        slow = true;
        yield return new WaitForSeconds(2);
        slow = false;
    }
}