﻿using UnityEngine;
using System.Collections;

public class Movement : Settings
{
    private Rigidbody2D _rbody;


    public void Move(float input_x, float input_y) {
        _rbody = gameObject.GetComponent<Rigidbody2D>();
        switch (tag)
        {         
            case ("Player1"):
            case ("Player2"):
            case ("Player3"):
            case ("Player4"):
            // Lav variabler
                Vector3 pos = transform.position;
                Quaternion rot = transform.rotation;
                float z = rot.eulerAngles.z;
            // Ændr Z angle via input
                z -= input_x * PlayerRotationSpeed * Time.deltaTime;
            // Sæt quaternion
                rot = Quaternion.Euler(0, 0, z);
            // Lav rotationen
                transform.rotation = rot;
            // Bevæg player
                Vector3 velocity = new Vector3(0, input_y * PlayerSpeed * Time.deltaTime, 0);
                pos += rot * velocity; 
                transform.position = pos;
                break;
            case ("Enemy"):
                _rbody.velocity = new Vector2(input_x, input_y);
                break;
        }
    }

    public void MoveSlow(Rigidbody2D rbody, float input_x, float input_y, float speed)
    {
        rbody.velocity = new Vector2(Mathf.Lerp(0, input_x, speed) * speed * 0.4f, Mathf.Lerp(0, input_y, speed) * speed * 0.4f);
    }

    public void MoveFast(Rigidbody2D rbody, float input_x, float input_y, float speed)
    {
        rbody.velocity = new Vector2(Mathf.Lerp(0, input_x, speed) * speed * 1.2f, Mathf.Lerp(0, input_y, speed) * speed * 1.2f);
    }

    public void Rotate(float inputX, float inputY, float speed) {

        switch (tag)
        {
            case ("Player1"):
            case ("Player2"):
            case ("Player3"):
            case ("Player4"):
                gameObject.transform.Rotate(new Vector3(0, 0, (inputX-inputY * (speed / 10))));
                break;
            case ("Enemy"):
                gameObject.transform.Rotate(new Vector3(0, 0, speed / 100));
                break;
        }
        
    }

}